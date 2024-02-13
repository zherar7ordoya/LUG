using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

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
            catch (SqlException ex)
            {
                string mensaje = $"Error: {ex.Message}";
                throw new Exception(mensaje, ex);
            }
            catch (Exception ex)
            {
                string mensaje = $"Error: {ex.Message}";
                throw new Exception(mensaje, ex);

            }
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
                string mensaje = $"Error: {ex.Message}";
                throw new Exception(mensaje, ex);
            }
            catch (Exception ex)
            {
                transaccion.Rollback();
                string mensaje = $"Error: {ex.Message}";
                throw new Exception(mensaje, ex);
            }
            finally { comando?.Dispose(); }
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
