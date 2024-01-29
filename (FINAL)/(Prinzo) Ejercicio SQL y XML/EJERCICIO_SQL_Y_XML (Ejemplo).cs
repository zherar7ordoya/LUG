using System.Data.SqlClient;

// ...
/*
    In this example, we first define the connection string to our SQL Server
    database. Then, we define the agenciaId and action variables to specify
    which record we want to retrieve from the Agencia table. Next, we create a
    new SqlConnection object and open the connection to the database. Then, we
    create a new SqlCommand object and set its CommandType property to
    StoredProcedure. We also add the necessary parameters to the command using
    the AddWithValue method. Finally, we execute the command using the
    ExecuteReader method and loop through the results using a SqlDataReader
    object. You can use a similar approach to call the other stored procedures
    for the other tables.
*/
// ...

string connectionString = "Data Source=myServerAddress;Initial Catalog=myDataBase;User Id=myUsername;Password=myPassword;";
int agenciaId = 1;
string action = "SELECT";

using (SqlConnection connection = new SqlConnection(connectionString))
{
    connection.Open();

    using (SqlCommand command = new SqlCommand("sp_Agencia_CRUD", connection))
    {
        command.CommandType = System.Data.CommandType.StoredProcedure;

        command.Parameters.AddWithValue("@agencia_id", agenciaId);
        command.Parameters.AddWithValue("@action", action);

        using (SqlDataReader reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
                // Do something with the data
            }
        }
    }
}
