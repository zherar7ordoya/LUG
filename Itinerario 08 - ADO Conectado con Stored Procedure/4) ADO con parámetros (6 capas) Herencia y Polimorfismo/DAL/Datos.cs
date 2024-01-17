using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Configuration;

namespace DAL
{
    public class Datos
    {
        readonly string cadena = ConfigurationManager.ConnectionStrings["Equipo"].ToString();
        private readonly SqlConnection conexion;
        private SqlTransaction transaccion;
        private SqlCommand comando;

        public Datos()
        {
            conexion = new SqlConnection(cadena);

            // No es necesario abrir y cerrar la conexión en cada método. Se puede abrir
            // la conexión en el constructor y cerrarla al finalizar las operaciones.
            conexion.Open();
        }

        //|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| HELPERS

        // Método privado que se encarga de la creación y configuración del comando.
        // Esto reduce la duplicación de código.
        private void ConfigurarComando(string consulta, Hashtable parametros = null)
        {
            comando = new SqlCommand(consulta, conexion)
            {
                CommandType = CommandType.StoredProcedure
            };

            if (parametros != null)
            {
                AgregarParametros(parametros);
            }
        }

        private void AgregarParametros(Hashtable parametros)
        {
            foreach (string parametro in parametros.Keys)
            {
                comando.Parameters.AddWithValue(parametro, parametros[parametro]);
            }
        }

        //|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| MÉTODOS

        public DataTable Leer(string consulta, Hashtable parametros)
        {
            DataTable tabla = new DataTable();
            SqlDataAdapter adaptador;

            try
            {
                ConfigurarComando(consulta, parametros);
                adaptador = new SqlDataAdapter(comando);
            }
            catch (SqlException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
            finally { conexion.Close(); }

            adaptador.Fill(tabla);
            return tabla;
        }

        public bool Existe(string consulta, Hashtable parametros)
        {
            try
            {
                ConfigurarComando(consulta, parametros);
                int respuesta = Convert.ToInt32(comando.ExecuteScalar());
                return respuesta > 0;
            }
            catch (SqlException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
            finally { conexion.Close(); }
        }

        public bool Escribir(string consulta, Hashtable parametros)
        {
            try
            {
                transaccion = conexion.BeginTransaction();
                ConfigurarComando(consulta, parametros);
                comando.ExecuteNonQuery();
                transaccion.Commit();
                return true;
            }
            catch (SqlException ex)
            {
                transaccion.Rollback();
                return false;
                throw ex;
            }
            catch (Exception ex)
            {
                transaccion.Rollback();
                return false;
                throw ex;
            }
            finally { conexion.Close(); }
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
