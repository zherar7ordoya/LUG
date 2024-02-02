using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System;


namespace DAL
{
    public class AccesoDatos : IDisposable
    {
        private readonly string cadena = 
            ConfigurationManager
            .ConnectionStrings["Equipo"]
            .ToString();
        private readonly SqlConnection conexion;
        private SqlCommand comando;
        private SqlTransaction transaccion;


        public AccesoDatos()
        {
            conexion = new SqlConnection(cadena);
            conexion.Open();
        }


        /*
        private void ConfigurarComando(string consulta, Dictionary<string, object> parametros = null)
        {
            comando = new SqlCommand
            {
                CommandText = consulta,
                Connection = conexion,
                CommandType = parametros?.Keys.Any(x => x.StartsWith("@")) == true
                    ? CommandType.StoredProcedure
                    : CommandType.Text
            };

            if (parametros != null)
            {
                foreach (var parametro in parametros)
                {
                    comando.Parameters.AddWithValue(parametro.Key, parametro.Value);
                }
            }
        }
        */


        //---------------------------------------------------------------------*
        // CONSIDERAR ESTE MÉTODO COMO REEMPLAZO DEL ANTERIOR.
        // Vino de la siguiente consulta:
        // Pregunta:  ¿Un CommandType.Text está pensado para hacer uso de Parameters?
        // Respuesta: Cuando utilizas CommandType.Text, tu consulta SQL puede ser
        //            una cadena de texto directa, y puedes incluir parámetros en ella.

        private void ConfigurarComando(string consulta, Dictionary<string, object> parametros = null, bool esProcedimientoAlmacenado = false)
        {
            comando = new SqlCommand
            {
                CommandText = consulta,
                Connection = conexion,
                CommandType = esProcedimientoAlmacenado ? CommandType.StoredProcedure : CommandType.Text
            };

            if (parametros != null)
            {
                foreach (var parametro in parametros)
                {
                    // Cambiado de AddWithValue a Add con tipo de datos específico
                    comando.Parameters.Add(new SqlParameter(parametro.Key, parametro.Value ?? DBNull.Value));
                }
            }
        }

        // ACLARACIONES:
        // 1. Uso de CommandType: La lógica para determinar el tipo de comando
        //    (CommandType) basada en la presencia de parámetros que comienzan
        //    con "@" puede ser propensa a errores.
        // 2. Uso de AddWithValue: El método AddWithValue tiene algunas desventajas,
        //    como la inferencia automática del tipo de datos del parámetro, que
        //    puede no ser siempre lo que necesitas. Es preferible especificar 
        //    explícitamente el tipo de datos para evitar sorpresas.
        // 3. Ten en cuenta el uso de ?? DBNull.Value para manejar valores nulos
        //    correctamente.
        //---------------------------------------------------------------------*


        public void Dispose()
        {
            if (conexion != null && conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
            GC.SuppressFinalize(this);
        }


        public DataTable Leer(string consulta, Dictionary<string, object> parametros)
        {
            DataTable tabla = new DataTable();
            SqlDataAdapter adaptador = null;

            try
            {
                ConfigurarComando(consulta, parametros);
                adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(tabla);
            }
            catch (SqlException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
            finally { adaptador?.Dispose(); }

            return tabla;
        }


        public bool Existe(string consulta, Dictionary<string, object> parametros)
        {
            try
            {
                ConfigurarComando(consulta, parametros);
                object resultado = comando.ExecuteScalar();
                return resultado != null && (int)resultado > 0;
            }
            catch (SqlException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
            finally { comando?.Dispose(); }
        }


        public bool Escribir(string consulta, Dictionary<string, object> parametros)
        {
            try
            {
                transaccion = conexion.BeginTransaction();
                ConfigurarComando(consulta, parametros);
                comando.Transaction = transaccion;
                comando.ExecuteNonQuery();
                transaccion.Commit();
                return true;
            }
            catch (SqlException ex)
            {
                transaccion.Rollback();
                throw ex;
            }
            catch (Exception ex)
            {
                transaccion.Rollback();
                throw ex;
            }
            finally { comando?.Dispose(); }
        }

    }
}
