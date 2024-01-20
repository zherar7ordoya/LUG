using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System;

namespace DAL
{
    public class AccesoDatos : IDisposable
    {
        private readonly string cadena = ConfigurationManager.ConnectionStrings["Equipo"].ToString();
        private readonly SqlConnection conexion;
        private SqlCommand comando;
        private SqlTransaction transaccion;


        public AccesoDatos()
        {
            conexion = new SqlConnection(cadena);
            conexion.Open();
        }


        private void ConfigurarComando(string consulta, Dictionary<string, object> parametros = null)
        {
            comando = new SqlCommand(consulta, conexion)
            {
                CommandType = CommandType.StoredProcedure
            };

            if (parametros != null)
            {
                foreach (var parametro in parametros)
                {
                    comando.Parameters.AddWithValue(parametro.Key, parametro.Value);
                }
            }
        }


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
                int respuesta = Convert.ToInt32(comando.ExecuteScalar());
                return respuesta > 0;
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
