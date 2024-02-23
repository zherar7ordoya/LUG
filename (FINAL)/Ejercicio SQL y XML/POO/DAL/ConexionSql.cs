using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

/* ************************************************************************** *\
La capa de acceso a datos (DAL) tiene como única responsabilidad la de gestionar
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
    // IDisposable: Ver comentario en Dispose(). Es necesario Dispose() porque
    //              no se me permite usar "using" (el bloque using asegura que
    //              el método Dispose se llame automáticamente cuando el bloque
    //              se completa, liberando así los recursos no administrados.
    
    /// <summary>
    /// ¿Por qué DataTable y no DataSet? ...
    /// </summary>
    public class ConexionSql : IDisposable
    {
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
         */

        //*--------------------------------------------------------------------*
        private void ConfigurarComando(
            bool stored,
            string consulta,
            Dictionary<string, object> parametros = null)
        {
            comando = new SqlCommand
            {
                CommandText = consulta,
                Connection = conexion,
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
             * recuperando un conjunto de datos, sino ejecutando una acción
             * directa en la base de datos. */

            try
            {
                transaccion = conexion.BeginTransaction();
                ConfigurarComando(stored, consulta, parametros);
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
