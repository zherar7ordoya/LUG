using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


namespace DAL
{
    // IDisposable: Ver comentario en Dispose(). Es necesario Dispose() porque
    //              no se me permite usar "using" (el bloque using asegura que
    //              el método Dispose se llame automáticamente cuando el bloque
    //              se completa, liberando así los recursos no administrados.

    /**
     * ¿Por qué DataTable y no DataSet?
     * DataTable representa una sola tabla de datos. Es más liviano y eficiente
     * cuando solo se necesita trabajar con una única tabla de resultados.
     * DataSet representa un conjunto de datos que puede contener múltiples
     * tablas, relaciones y restricciones. Es más adecuado cuando se necesita
     * trabajar con múltiples tablas o se necesita mantener la estructura
     * relacional entre las tablas.
     */
    public class ConexionSql : IDisposable
    {
        // Ver comentario en App.config en la GUI.
        // A pesar de ello, se usa ConfigurationManager para obtener la cadena
        // de conexión por ser un ítem en la evaluación de la materia.
        private readonly string cadena =
            ConfigurationManager
            .ConnectionStrings["Final"]
            .ToString();
        private readonly SqlConnection conexion;
        private SqlCommand comando;
        private SqlTransaction transaccion;

        public ConexionSql()
        {
            conexion = new SqlConnection(cadena);
            conexion.Open();
        }


        /**
         * El método Dispose se implementa porque esta clase está gestionando un
         * recurso no administrado (la conexión a la base de datos). La
         * implementación de IDisposable permite liberar esos recursos cuando ya
         * no son necesarios, lo que es crucial para evitar posibles fugas de
         * memoria y garantizar la correcta gestión de recursos.
         */
        public void Dispose()
        {
            if (conexion != null && conexion.State == ConnectionState.Open) conexion.Close();
            GC.SuppressFinalize(this);
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||| HERRAMIENTAS

        /**
         * ¿Por qué no estoy usando HashTable en los métodos?
         * La clase HashTable estaba presente en versiones anteriores de .NET
         * Framework y se utilizaba para almacenar pares clave-valor de manera
         * similar a Dictionary. Sin embargo, HashTable tiene algunas
         * limitaciones y se considera obsoleto en favor de Dictionary. Una de
         * las limitaciones de HashTable es que no es fuertemente tipada, lo que
         * significa que puede contener elementos de cualquier tipo de datos.
         * La falta de seguridad de tipo de HashTable significa que no hace 
         * verificaciones de tipo en tiempo de compilación y, por lo tanto, se
         * pueden introducir errores difíciles de detectar hasta tiempo de
         * ejecución.
         * De manera similar a HashTable, ArrayList es otra estructura de datos
         * que ha quedado desaconsejada en favor de las implementaciones más
         * modernas y tipo seguro de List<T>.
         * Finalmente, ¿por qué Dictionary y no List? Porque List trabaja con un
         * tipo de dato. En cambio, Dictionary trabaja con pares clave-valor, lo
         * que es más adecuado para el manejo de parámetros de consulta (donde
         * las claves son strings y los valores pueden ser de cualquier tipo,
         * lo que es adecuado para representar una colección heterogénea de
         * parámetros).
         */

        //*--------------------------------------------------------------------*

        // TODO => El tema con este método es que tuve que traer cada uno de los 
        //         parámetros del método desde la PML (pasaron por MPP sin hacer
        //         nada) para llegar aquí. No me parece que sea la mejor forma
        //         de hacerlo. Tal vez debería usar el constructor...
        private void ConfigurarComando(
            bool stored,
            string consulta,
            Dictionary<string, object> parametros = null)
        {
            comando = new SqlCommand
            {
                Connection = conexion,
                CommandText = consulta,
                // Esto debería evitarse: un stored procedure se lleva parte de
                // la lógica de la aplicación a la base de datos.
                CommandType = stored ? CommandType.StoredProcedure : CommandType.Text
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

        /// <summary>
        /// Lectura de datos desde la base de datos.
        /// </summary>
        /// <param name="stored">
        /// TRUE para procedimiento almacenado,
        /// FALSE para consulta de texto plana
        /// </param>
        /// <param name="consulta">
        /// Procedimiento almacenado: nombre del stored procedure.
        /// Consulta de texto: literal de la consulta.
        /// </param>
        /// <param name="parametros">
        /// Diccionario de parámetros para la consulta.
        /// NULL si no hay parámetros.
        /// </param>
        public DataTable Leer(
            bool stored,
            string consulta,
            Dictionary<string, object> parametros)
        {
            /* Lectura (Select): En operaciones de lectura, como SELECT, se
             * utiliza SqlDataAdapter junto con DataTable para llenar un conjunto
             * de datos (DataTable) con los resultados de la consulta.
             * El SqlDataAdapter actúa como un puente que llena el DataTable con
             * los datos recuperados de la base de datos. */

            DataTable tabla = new DataTable();
            SqlDataAdapter adaptador = null;

            try
            {
                ConfigurarComando(stored, consulta, parametros);
                adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(tabla);
            }
            catch (SqlException ex) { throw new Exception(ex.Message); }
            catch (Exception ex) { throw new Exception(ex.Message); }

            // La expresión ?. se utiliza para invocar a Dispose si adaptador no
            // es nulo. Dispose se utiliza para liberar los recursos asociados
            // al adaptador cuando ya no son necesarios.
            finally { adaptador?.Dispose(); }

            return tabla;
        }


        /// <summary>
        /// Escritura de datos en la base de datos.
        /// </summary>
        /// <param name="stored">
        /// TRUE para procedimiento almacenado,
        /// FALSE para consulta de texto plana
        /// </param>
        /// <param name="consulta">
        /// Procedimiento almacenado: nombre del stored procedure.
        /// Consulta de texto: literal de la consulta.
        /// </param>
        /// <param name="parametros">
        /// Diccionario de parámetros para la consulta.
        /// NULL si no hay parámetros.
        /// </param>
        public bool Escribir(
            bool stored,
            string consulta,
            Dictionary<string, object> parametros)
        {
            /* Escritura (Insert, Update, Delete): En operaciones de escritura,
             * como INSERT, UPDATE, DELETE, se utiliza directamente SqlCommand.
             * En este caso, no se necesita un DataAdapter porque no se está
             * recuperando un conjunto de datos sino ejecutando una acción
             * directa en la base de datos. */

            try
            {
                transaccion = conexion.BeginTransaction();
                ConfigurarComando(stored, consulta, parametros);
                comando.Transaction = transaccion;
                comando.ExecuteNonQuery(); // Ejecutar el comando y no devolver nada
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
