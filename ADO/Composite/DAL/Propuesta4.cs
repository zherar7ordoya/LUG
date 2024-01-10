using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DataAccess : IDisposable
    {
        private readonly string connectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;
              Initial Catalog=Composite;
              Integrated Security=True";

        private SqlConnection connection;

        public DataSet Consultar(string sqlQuery, List<SqlParameter> parameters = null)
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = CrearComando(sqlQuery, parameters, connection))
                using (var adapter = new SqlDataAdapter(command))
                {
                    var dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    return dataSet;
                }
            }
        }

        public int ContarFilas(string sqlQuery, List<SqlParameter> parameters = null)
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = CrearComando(sqlQuery, parameters, connection))
                {
                    return (int)(command.ExecuteScalar() ?? 0);
                }
            }
        }

        public int Escribir(string sqlQuery, List<SqlParameter> parameters = null, SqlTransaction transaction = null)
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var localTransaction = transaction ?? connection.BeginTransaction())
                using (var command = CrearComando(sqlQuery, parameters, connection, localTransaction))
                {
                    try
                    {
                        int respuesta = command.ExecuteNonQuery();
                        localTransaction.Commit();
                        return respuesta;
                    }
                    catch (SqlException)
                    {
                        localTransaction.Rollback();
                        return -1;
                    }
                }
            }
        }

        private SqlCommand CrearComando(string sqlQuery, List<SqlParameter> parameters, SqlConnection connection, SqlTransaction transaction = null)
        {
            var command = new SqlCommand(sqlQuery, connection, transaction)
            {
                CommandType = CommandType.Text
            };

            if (parameters != null)
            {
                foreach (SqlParameter parameter in parameters)
                {
                    command.Parameters.Add(parameter);
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
