using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Windows.Forms;

namespace Crud_WindowsForms_AdoNet
{
    public class People
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class PeopleDB
    {
        private readonly string connectionString
            = @"Data Source=(LocalDB)\MSSQLLocalDB;
                Initial Catalog=HdeLeon;
                Integrated Security=true";

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| LECTURA

        // Lectura trabaja con sobrecarga:
        //  *) El 1er metodo es "Leer uno"
        //  *) El 2do metodo es "Leer todos"
        // Asombroso...
        public People Get(int pId)
        {

            string query = "SELECT Id, Name, Age FROM People WHERE Id=@Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", pId);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();

                    People oPeople = new People
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Age = reader.GetInt32(2)
                    };

                    reader.Close();
                    connection.Close();
                    return oPeople;
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la bd " + ex.Message);
                }
            }
        }

        public List<People> Get()
        {
            List<People> people = new List<People>();

            string query = "SELECT Id, Name, Age FROM People";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    
                    while (reader.Read())
                    {
                        People oPeople = new People
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Age = reader.GetInt32(2)
                        };
                        people.Add(oPeople);
                    }

                    reader.Close();
                    connection.Close();
                }
                catch(Exception ex)
                {
                    throw new Exception("Hay un error en la bd " + ex.Message);
                }
            }

            return people;
        }

        //|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

        
        // Alta
        public void Add(string pName, int pAge)
        {
            string query = "INSERT INTO People(Name, Age) VALUES(@Name, @Age)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", pName);
                command.Parameters.AddWithValue("@Age", pAge);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la bd " + ex.Message);
                }
            }
        }

        // Baja
        public void Delete(int pId)
        {
            string query = "DELETE FROM People WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", pId);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la bd " + ex.Message);
                }
            }

        }

        // Modificacion
        public void Update(string pName, int pAge, int pId)
        {
            string query = "UPDATE People SET Name = @Name, Age = @Age WHERE Id = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", pName);
                command.Parameters.AddWithValue("@Age", pAge);
                command.Parameters.AddWithValue("@Id", pId);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la bd " + ex.Message);
                }
            }
        }
        
    }
}
