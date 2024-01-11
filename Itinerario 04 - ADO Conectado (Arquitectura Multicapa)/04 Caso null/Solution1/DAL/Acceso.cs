using System;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    public class Acceso
    {
        private readonly SqlConnection connection = new SqlConnection(
            @"Data Source=(LocalDB)\MSSQLLocalDB;
            Initial Catalog=MiBasev2;
            Integrated Security=True");

        public DataSet Leer(string pSQL)
        {
            DataSet dataset = new DataSet();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(pSQL, connection);
                adapter.Fill(dataset);
            }
            catch (SqlException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
            finally { connection.Close(); }

            return dataset;
        }

        public bool Escribir(string pSQL)
        {
            connection.Open();
            SqlCommand command = new SqlCommand
            {
                CommandType = CommandType.Text,
                Connection = connection,
                CommandText = pSQL
            };
            try
            {
                int respuesta = command.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex) { throw ex; }
            finally { connection.Close(); }
        }

    }
}
