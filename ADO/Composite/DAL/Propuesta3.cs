using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Propuesta3 : IDisposable
    {
        private readonly string connectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;
              Initial Catalog=Composite;
              Integrated Security=True";

        private SqlConnection connection;

        public DataSet Leer(string pSQL, List<SqlParameter> pParameters = null)
        {
            using (connection = new SqlConnection(connectionString))
            using (var command = CrearComando(pSQL, pParameters, connection))
            {
                connection.Open();
                var dataset = new DataSet();
                using (var adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dataset);
                }
                return dataset;
            }
        }

        public int ContarFilas(string pSQL, List<SqlParameter> pParameters = null)
        {
            using (connection = new SqlConnection(connectionString))
            using (var command = CrearComando(pSQL, pParameters, connection))
            {
                connection.Open();
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }

        public int Escribir(string pSQL, List<SqlParameter> pParameters = null)
        {
            using (connection = new SqlConnection(connectionString))
            using (var transaction = connection.BeginTransaction())
            using (var command = CrearComando(pSQL, pParameters, connection, transaction))
            {
                try
                {
                    connection.Open();
                    int respuesta = command.ExecuteNonQuery();
                    transaction.Commit();
                    return respuesta;
                }
                catch (SqlException)
                {
                    transaction.Rollback();
                    return -1;
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    return -1;
                }
            }
        }

        private SqlCommand CrearComando(string pSQL, List<SqlParameter> pParameters, SqlConnection connection, SqlTransaction transaction = null)
        {
            var command = new SqlCommand(pSQL, connection, transaction)
            {
                CommandType = CommandType.Text
            };

            if (pParameters != null)
            {
                foreach (SqlParameter parameter in pParameters)
                {
                    command.Parameters.AddWithValue(parameter.ParameterName, parameter.Value);
                }
            }
            return command;
        }

        public void Dispose()
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
                connection.Dispose();
            }
        }
    }
}
