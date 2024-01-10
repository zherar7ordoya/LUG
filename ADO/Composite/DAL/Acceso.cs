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
