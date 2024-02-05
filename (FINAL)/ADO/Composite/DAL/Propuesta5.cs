using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Acceso2
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Composite;Integrated Security=True";
        private SqlCommand command;
        private SqlTransaction transaction;
        private SqlConnection connection;

        // MÉTODOS

        public DataSet Leer(string pSQL, List<SqlParameter> pParameters)
        {
            DataSet dataset = new DataSet();
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();

                command = new SqlCommand(pSQL, connection)
                {
                    CommandType = CommandType.Text
                };

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                if (pParameters != null)
                {
                    foreach (SqlParameter dato in pParameters)
                    {
                        command.Parameters.AddWithValue(dato.ParameterName, dato.Value);
                    }
                }

                adapter.Fill(dataset);
            }
            catch (SqlException ex)
            {
                HandleSqlException(ex);
            }
            catch (Exception ex)
            {
                HandleGeneralException(ex);
            }
            finally
            {
                CerrarConexion();
            }

            return dataset;
        }

        public int ContarFilas(string pSQL, List<SqlParameter> pParameters)
        {
            int respuesta = 0;
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();

                command = new SqlCommand(pSQL, connection)
                {
                    CommandType = CommandType.Text
                };

                if (pParameters != null)
                {
                    foreach (SqlParameter dato in pParameters)
                    {
                        command.Parameters.AddWithValue(dato.ParameterName, dato.Value);
                    }
                }

                respuesta = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                HandleSqlException(ex);
            }
            catch (Exception ex)
            {
                HandleGeneralException(ex);
            }
            finally
            {
                CerrarConexion();
            }

            return respuesta;
        }

        public bool Escribir(string pSQL, List<SqlParameter> pParameters)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                transaction = connection.BeginTransaction();

                command = new SqlCommand(pSQL, connection, transaction)
                {
                    CommandType = CommandType.Text
                };

                if (pParameters != null)
                {
                    foreach (SqlParameter dato in pParameters)
                    {
                        command.Parameters.AddWithValue(dato.ParameterName, dato.Value);
                    }
                }

                int respuesta = command.ExecuteNonQuery();
                transaction.Commit();
                return true;
            }
            catch (SqlException ex)
            {
                HandleSqlException(ex);
            }
            catch (Exception ex)
            {
                HandleGeneralException(ex);
            }
            finally
            {
                CerrarConexion();
            }

            return false;
        }

        private void HandleSqlException(SqlException ex)
        {
            // Aquí puedes realizar acciones específicas para las excepciones de SQL Server
            throw ex;
        }

        private void HandleGeneralException(Exception ex)
        {
            // Aquí puedes realizar acciones específicas para las excepciones generales
            throw ex;
        }

        private void CerrarConexion()
        {
            try
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            finally
            {
                connection?.Dispose();
                connection = null;
                GC.Collect();
            }
        }
    }
}
