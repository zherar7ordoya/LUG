using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Acceso
    {
        private readonly string connectionString
            = @"Data Source=(LocalDB)\MSSQLLocalDB;
                Initial Catalog=Composite;
                Integrated Security=True";
        private SqlCommand command;
        private SqlTransaction transaction;
        private SqlConnection connection;

        //|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| MÉTODOS

        /// <summary>
        /// Tipo de Consulta:
        /// Se utiliza para ejecutar consultas SQL que devuelven conjuntos de resultados, como SELECT.
        /// Método de retorno:
        /// Devuelve un objeto DataSet que puede contener múltiples tablas y relaciones.
        /// Esto es útil cuando la consulta puede devolver múltiples conjuntos de resultados o cuando
        /// necesitas trabajar con datos de manera más compleja, como relaciones entre tablas.
        /// Ejemplo de uso:
        /// SELECT* FROM TableName
        /// </summary>
        /// <param name="pConsulta"></param>
        /// <param name="pListaParametros"></param>
        /// <returns></returns>
        public DataSet Leer(string pConsulta, List<SqlParameter> pListaParametros)
        {
            DataSet dataset = new DataSet();

            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();

                command = new SqlCommand(pConsulta, connection)
                {
                    CommandType = CommandType.Text
                };

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                if (pListaParametros != null)
                {
                    foreach (SqlParameter dato in pListaParametros)
                    {
                        command.Parameters.AddWithValue(dato.ParameterName, dato.Value);
                    }
                }

                adapter.Fill(dataset);
            }
            catch (SqlException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                    connection.Dispose();
                    connection = null;
                    GC.Collect();
                }
            }
            return dataset;
        }

        /// <summary>
        /// Tipo de Consulta:
        /// Diseñado para ejecutar consultas SQL que devuelven un solo valor,
        /// como una función de agregación o una consulta que devuelve una única columna y fila.
        /// Método de retorno:
        /// Devuelve un valor escalar, generalmente un entero, que es el resultado de la consulta.
        /// Es útil cuando necesitas obtener un solo valor de la base de datos.
        /// Ejemplo de uso:
        /// SELECT COUNT(*) FROM TableName
        /// </summary>
        /// <param name="pConsulta"></param>
        /// <param name="pListaParametros"></param>
        /// <returns></returns>
        public int ObtenerEscalar(string pConsulta, List<SqlParameter> pListaParametros)
        {
            int respuesta = 0;

            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();

                command = new SqlCommand(pConsulta, connection)
                {
                    CommandType = CommandType.Text
                };

                if (pListaParametros != null)
                {
                    foreach (SqlParameter dato in pListaParametros)
                    {
                        command.Parameters.AddWithValue(dato.ParameterName, dato.Value);
                    }
                }

                respuesta = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (SqlException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                    connection.Dispose();
                    connection = null;
                    GC.Collect();
                }
            }
            return respuesta;
        }


        public bool Escribir(string pConsulta, List<SqlParameter> pListaParametros)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                transaction = connection.BeginTransaction();

                command = new SqlCommand(pConsulta, connection, transaction)
                {
                    CommandType = CommandType.Text
                };

                if (pListaParametros != null)
                {
                    foreach (SqlParameter dato in pListaParametros)
                    {
                        command.Parameters.AddWithValue(dato.ParameterName, dato.Value);
                    }
                }

                int respuesta = command.ExecuteNonQuery();
                transaction.Commit();
                return true;
            }
            catch (SqlException)
            {
                transaction?.Rollback();
                return false;
            }
            catch (Exception)
            {
                transaction?.Rollback();
                return false;
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                    connection.Dispose();
                    connection = null;
                    GC.Collect();
                }
            }
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
