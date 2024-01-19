using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;

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

        //|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| HELPERS

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

        #region ¿Por qué usar IDisposable?
        /* Cuando implementamos IDisposable, le estamos diciendo a los consumidores
         * de nuestra clase que estamos utilizando recursos no administrados por el
         * sistema, y debido a esom estos recursos deben ser indicados de forma manual
         * para ser limpiados por el GC (Garbage Collector, recolector de basura). 
         * Implementar, utilizar y comprender IDisposable es muy sencillo, pero la
         * documentación es muy confusa ya que está siempre haciendo referencia a
         * “recursos no administrados por el sistema” lo que te hace pensar que no
         * te afecta, pero en verdad, sí. Cuando trabajamos en una aplicación en .NET
         * y esta aplicación tiene contacto con el sistema de ficheros o una consulta
         * SQL o la mayoría de los servicios de la nube (como puede ser S3 en Amazon
         * Web Services) se está utilizando recursos no administrados por el sistema.
         * Ejemplo: en el caso concreto de la conexión SQL utilizamos System.Data que
         * sí está administrado por el sistema, pero la conexión a la base de datos
         * como tal NO lo está, por lo que debemos invocar Dispose para liberar la
         * memoria. Pero no solo sirve con llamar al método Dispose(), sino que
         * debemos saber que hacer en él, por ejemplo en una conexión a la base de
         * datos, debemos cerrar dicha conexión.
         * ¿Qué pasa si no utilizamos Dispose? En el caso de que no utilicemos el
         * Dispose(), o no instanciemos el objeto dentro de un bloque using, no
         * recibiremos ningún error. Ni en tiempo de ejecución ni en tiempo de
         * compilación. En la mayoría de casos de uso reales, nuestro problema será
         * con la memoria o también conectando a la base de datos: cuando realizamos
         * llamadas a la base de datos, estas están limitadas a un número (el cual
         * llamamos “pool de conexiones”). Una vez que pasamos este número, la 
         * aplicación se cuelga.
         */
        #endregion
        public void Dispose()
        {
            if (conexion != null && conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }

            // SuppressFinalize solo debe ser llamado por una clase que tenga un
            // finalizador (como este Dispose, por ejemplo). Está informando al GC
            // que este objeto ya se limpió por completo, que no necesita venir.
            GC.SuppressFinalize(this);
        }

        //|||||||||||||||||||||||||||||||||||||||||||||||||| MÉTODOS DE LA CLASE

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


        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
