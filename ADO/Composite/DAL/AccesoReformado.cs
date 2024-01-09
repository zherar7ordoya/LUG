using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Acceso
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Composite;Integrated Security=True";

        private void LimpiarConexion(SqlConnection connection)
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
                connection.Dispose();
            }
        }

        private void ConfigurarParametros(SqlCommand command, List<SqlParameter> pListaParametros)
        {
            if (pListaParametros != null)
            {
                foreach (SqlParameter dato in pListaParametros)
                {
                    command.Parameters.Add(new SqlParameter(dato.ParameterName, dato.Value));
                }
            }
        }

        private void ManejarExcepcion(SqlTransaction transaction, Exception ex)
        {
            transaction?.Rollback();
            throw ex; // Re-lanza la excepción para mantener la trazabilidad
        }

        public DataSet Leer(string pConsulta, List<SqlParameter> pListaParametros)
        {
            DataSet dataset = new DataSet();
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand(pConsulta, connection)
                {
                    CommandType = CommandType.Text
                };

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                ConfigurarParametros(command, pListaParametros);
                adapter.Fill(dataset);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                LimpiarConexion(connection);
            }

            return dataset;
        }

        public int Leer(string pConsulta, List<SqlParameter> pListaParametros)
        {
            int respuesta = 0;
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand(pConsulta, connection)
                {
                    CommandType = CommandType.Text
                };

                ConfigurarParametros(command, pListaParametros);
                respuesta = Convert.ToInt32(command.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                LimpiarConexion(connection);
            }

            return respuesta;
        }

        public bool Escribir(string pConsulta, List<SqlParameter> pListaParametros)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        SqlCommand command = new SqlCommand(pConsulta, connection, transaction)
                        {
                            CommandType = CommandType.Text
                        };

                        ConfigurarParametros(command, pListaParametros);
                        int respuesta = command.ExecuteNonQuery();

                        transaction.Commit();
                        return true;
                    }
                    catch (SqlException ex)
                    {
                        ManejarExcepcion(transaction, ex);
                        return false;
                    }
                    catch (Exception ex)
                    {
                        ManejarExcepcion(transaction, ex);
                        return false;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                LimpiarConexion(connection);
            }
        }
    }
}
