using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/* ************************************************************************** *\
La capa de acceso a datos (DAL) tiene como responsabilidad principal gestionar
la ubicación y persistencia de los datos, determinando "dónde" se almacenan los
datos del sistema. Esto implica proporcionar mecanismos para interactuar con el
repositorio de datos correspondiente, ya sea un servidor SQL o archivos XML. La
DAL recibe la información estructurada desde la capa mapeadora y utiliza esta
información para realizar las operaciones de almacenamiento y recuperación en el
repositorio de datos específico, manteniendo así la separación de preocupaciones
en cuanto a la persistencia.
\* ************************************************************************** */

namespace DAL
{
    public class ConexionSql : IDisposable
    {
        private readonly string cadena = ConfigurationManager.ConnectionStrings["Final"].ToString();
        private readonly SqlConnection conexion;
        private SqlCommand comando;
        private SqlTransaction transaccion;

        public ConexionSql()
        {
            conexion = new SqlConnection(cadena);
            conexion.Open();
        }

        public void Dispose()
        {
            if (conexion != null && conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
            GC.SuppressFinalize(this);
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||| HERRAMIENTAS

        // Los defaults son para procedimientos almacenados y sin parámetros.
        private void ConfigurarComando(string consulta, Dictionary<string, object> parametros = null, bool esProcedimientoAlmacenado = true)
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
                    comando.Parameters.Add(new SqlParameter(parametro.Key, parametro.Value ?? DBNull.Value));
                }
            }
        }

        // |||||||||||||||||||||||||||||||||||||||||||||||||||| MÉTODOS DE CLASE

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
            catch (SqlException ex) { throw new Exception(ex.Message); }
            catch (Exception ex) { throw new Exception(ex.Message); }
            finally { adaptador?.Dispose(); }

            return tabla;
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
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                transaccion.Rollback();
                throw new Exception(ex.Message);
            }
            finally { comando?.Dispose(); }
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
