using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System;
using System.Linq;

// Teoría:
// Manuel Torres Remon
// Programación Orientada a Objetos con Visual C# 2015 y ADO.NET 4.6

namespace DAL
{
    public class AccesoDatos : IDisposable
    {
        // La p185 presenta otra manera, muy similar, de obtener la cadena de conexión.
        private readonly string cadena = 
            ConfigurationManager
            .ConnectionStrings["Equipo"]
            .ToString();
        
        // p179: SqlConnection tiene 3 métodos (Open, Close y Dispose). Aquí no usamos Dispose.
        private readonly SqlConnection conexion;
        private SqlCommand comando;
        private SqlTransaction transaccion;

        public AccesoDatos()
        {
            conexion = new SqlConnection(cadena); // p178: Ésta es la forma más sencilla.
            conexion.Open();
        }

        //|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| HELPERS

        private void ConfigurarComando(string consulta, Dictionary<string, object> parametros = null)
        {
            #region Teoría y herramientas usadas en CommandType
            /* El código verifica si al menos una clave en el diccionario de parámetros
             * comienza con "@". Si es así, asume que se trata de un procedimiento 
             * almacenado y establece CommandType en CommandType.StoredProcedure; 
             * de lo contrario, asume que es una consulta de texto plano y establece 
             * CommandType en CommandType.Text. Este código utiliza características 
             * de C# modernas, como el operador de propagación de nulos (?.), LINQ
             * (Any), el operador ternario condicional (? :).
             * 
             * 1) parametros?.Keys:
             *    El operador ?. se llama "operador de propagación de nulos" o
             *    "null-conditional operator". Este operador se usa con el objetivo
             *    de evitar una excepción si "parametros" es null. Si "parametros"
             *    es null, toda la expresión se evalúa como null. En este caso,
             *    estamos accediendo a las keys del diccionario parametros.
             *    
             * 2) .Any(x => x.StartsWith("@")):
             *    .Any es un método de LINQ que devuelve true si al menos un elemento
             *    en la colección satisface la condición dada. En este caso, estamos
             *    verificando si al menos una de las claves del diccionario comienza
             *    con "@".
             *    
             * 3) Expresión Lambda (x => x.StartsWith("@")):
             *    Esta expresión lambda se utiliza dentro del método Any. La parte
             *    (x => x.StartsWith("@")) representa una función anónima que toma
             *    un parámetro x (en este caso, cada clave en el diccionario) y
             *    verifica si esa clave comienza con "@". La expresión lambda se
             *    evalúa a true si la condición se cumple para al menos una clave
             *    en el diccionario.
             */
            #endregion
            comando = new SqlCommand
            {
                CommandText = consulta, // p195.
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

        // Para escenarios más complejos, usar DataSet.
        public DataTable Leer(string consulta, Dictionary<string, object> parametros)
        {
            DataTable tabla = new DataTable();

            // Hay dos formas de lectura con SqlDataAdapter: una que usó Cardacci
            // en su AAS (que usa las propiedades del adaptador) y otra que usa
            // Prinzo (aquí) que es más genérica (p183, con SqlCommand).
            SqlDataAdapter adaptador = null;

            try
            {
                ConfigurarComando(consulta, parametros);

                // p189: Muestra un procedimiento más simple, pero imagino que aquí
                //       la opción se decanta por ésta por el uso de parámetros.
                adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(tabla);
            }
            catch (SqlException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
            finally { adaptador?.Dispose(); } // p185, p188.

            return tabla;
        }


        // Este método no se ha usado a lo largo de esta solución.
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

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

    }
}
