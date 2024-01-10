////////10////////20////////30////////40////////50////////60////////70////////80////////90///////100///////110///////120
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/* TODO LO QUE SE NECESITA PARA ESTAS ACTIVIDADES SON TRES (3) CLASES:
 * 
 *      ✳️ SqlConnection
 *      ✳️ SqlCommand
 *      ✳️ SqlDataReader
 */

namespace CSharpYa
{
    public partial class Form1 : Form
    {

        private readonly SqlConnection connection = new SqlConnection(
            @"Data Source=(LocalDB)\MSSQLLocalDB; 
            Initial Catalog=HdeLeon; 
            Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        //|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| HELPERS

        private void LimpiarTextboxes()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox) { control.Text = string.Empty; }
            }
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

        /*
         * SqlCommand tiene, básicamente, los siguientes métodos:
         * 
         * ExecuteReader (devuelve un objeto SqlDataReader)
         * Envía la propiedad CommandText a Connection y crea un objeto SqlDataReader.
         * [SqlDataReader ofrece una manera de leer un flujo de filas de solo avance
         * desde una base de datos de SQL Server
         * => Read() desplaza SqlDataReader al siguiente registro.]
         * 
         * ExecuteNonQuery (devuelve int)
         * Ejecuta una instrucción Transact-SQL en la conexión y devuelve el número de filas afectadas.
         * 
         * ExecuteScalar (devuelve Objet)
         * Ejecuta la consulta y devuelve la primera columna de la primera fila
         * del conjunto de resultados devuelto por la consulta.
         * 
         * ExecuteXmlReader (devuelve objeto XmlReader)
         * Envía la propiedad CommandText a Connection y crea un objeto XmlReader.
         * [XmlReader pepresenta un lector que proporciona acceso rápido a datos XML,
         * sin almacenamiento en caché y con desplazamiento solo hacia delante.]
         * 
         */
        private void button1_Click(object sender, EventArgs e)
        {
            // 1ro: abrir y cerrar conexión
            connection.Open();

            // 2do: armar la consulta
            string sql = $"INSERT INTO empleados(documento, nombre, sueldo) " +
                $"VALUES ('{textBox1.Text}', '{textBox2.Text}', {textBox3.Text});";

            // 3ro: ejecutar la consulta
            SqlCommand command = new SqlCommand(sql, connection);
            int respuesta = command.ExecuteNonQuery();

            // 4to: 
            LimpiarTextboxes();
            MessageBox.Show($"{respuesta} empleado ingresado correctamente.");

            // (parte del 1ro)
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            string sql = $"SELECT nombre, sueldo FROM empleados WHERE documento = '{textBox1.Text}';";
            SqlCommand command = new SqlCommand(sql, connection);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                textBox2.Text = reader["nombre"].ToString();
                textBox3.Text = reader["sueldo"].ToString();
            }
            else
            {
                MessageBox.Show("Empleado no encontrado");
            }
            // Es conveniente siempre cerrar al Reader (si se mantiene "ocupado",
            // no obedece al llamado a otras operaciones.
            reader.Close();
            
            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connection.Open();

            string sql = $"DELETE FROM empleados WHERE documento = '{textBox1.Text}';";
            SqlCommand command = new SqlCommand(sql, connection);
            int respuesta = command.ExecuteNonQuery();

            if (respuesta == 1)
            {
                LimpiarTextboxes();
                MessageBox.Show($"{respuesta} empleado borrado correctamente.");
            }
            else
            {
                MessageBox.Show("No existe empleado");
            }

            connection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            connection.Open();
            string sql = $"UPDATE empleados SET nombre = '{textBox2.Text}', sueldo = {textBox3.Text} WHERE documento = '{textBox1.Text}';";

            SqlCommand command = new SqlCommand(sql, connection);
            int respuesta = command.ExecuteNonQuery();

            if (respuesta == 1)
            {
                LimpiarTextboxes();
                MessageBox.Show($"{respuesta} empleado modificado correctamente.");
            }
            else
            {
                MessageBox.Show("No existe empleado");
            }

            connection.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            connection.Open();
            string sql = $"SELECT * FROM empleados;";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            dataGridView1.Rows.Clear();

            while (reader.Read())
            {
                dataGridView1.Rows.Add(
                    reader["documento"].ToString(),
                    reader["nombre"].ToString(),
                    reader["sueldo"].ToString());
            }
            
            reader.Close();
            connection.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            connection.Open();
            string sql = $"SELECT * FROM empleados WHERE sueldo > {textBox4.Text};";
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader reader = command.ExecuteReader();

            dataGridView1.Rows.Clear();

            while (reader.Read())
            {
                dataGridView1.Rows.Add(
                    reader["documento"].ToString(),
                    reader["nombre"].ToString(),
                    reader["sueldo"].ToString());
            }

            reader.Close();
            connection.Close();
        }

        //||||||||||||||||||||||||||||||||||||||||| PARAMETRIZACIÓN DE CONSULTAS

        // La parametrización combate el SQL Injection (SQLI)

        private void button7_Click(object sender, EventArgs e)
        {
            connection.Open();

            string sql = $"DELETE FROM empleados WHERE documento = @documento;";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.Add("@documento", SqlDbType.Char).Value = textBox1.Text;

            int respuesta = command.ExecuteNonQuery();

            if (respuesta == 1)
            {
                LimpiarTextboxes();
                MessageBox.Show($"{respuesta} empleado borrado correctamente.");
            }
            else
            {
                MessageBox.Show("No existe empleado");
            }

            connection.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            connection.Open();

            string sql = $"INSERT INTO empleados(documento, nombre, sueldo) " +
                $"VALUES (@documento, @nombre, @sueldo);";

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.Add("@documento", SqlDbType.Char).Value = textBox1.Text;
            command.Parameters.Add("@nombre", SqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.Add("@sueldo", SqlDbType.Float).Value = textBox3.Text;

            int respuesta = command.ExecuteNonQuery();

            LimpiarTextboxes();
            MessageBox.Show($"{respuesta} empleado ingresado correctamente.");

            connection.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            connection.Open();

            string sql = $"SELECT nombre, sueldo FROM empleados WHERE documento = @documento;";

            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.Add("@documento", SqlDbType.Char).Value = textBox1.Text;

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                textBox2.Text = reader["nombre"].ToString();
                textBox3.Text = reader["sueldo"].ToString();
            }
            else
            {
                MessageBox.Show("Empleado no encontrado");
            }

            reader.Close();
            connection.Close();
        }
    }
}
