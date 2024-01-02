using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class Datos
    {
        /**
         * ¿Por qué el constructor? => Por el error CS0236 (un inicializador de
         * campo no puede hacer referencia al campo, método o propiedad ‘name’
         * no estático.
         * ¿Eso qué significa? => Los campos de instancia no pueden usarse para
         * inicializar otros campos de instancia fuera de un método.
         * ¿Cómo se soluciona? => Si está intentando inicializar una variable
         * fuera de un método, considere la posibilidad de realizar la
         * inicialización dentro del constructor de clase.
         */

        readonly string _cadenaConexion;
        readonly SqlConnection _conexion;
        SqlCommand _comando;


        // Constructor
        public Datos()
        {
            _cadenaConexion = ConfigurationManager.ConnectionStrings["CadenaConexion"].ConnectionString;
            _conexion = new SqlConnection(_cadenaConexion);
        }


        public DataTable DevuelveTabla(string consulta)
        {
            DataTable tabla = new DataTable();
            try
            {
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, _conexion);
                adaptador.Fill(tabla);
            }
            catch (SqlException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
            finally { _conexion.Close(); }

            return tabla;
        }


        public bool LeeEscalar(string consulta)
        {
            _conexion.Open();

            _comando = new SqlCommand(consulta, _conexion)
            {
                CommandType = CommandType.Text
            };

            try
            {
                int respuesta = Convert.ToInt32(_comando.ExecuteScalar());
                _conexion.Close();
                if (respuesta > 0) return true;
                else { return false; }
            }
            catch (SqlException ex) { throw ex; }
            finally { _conexion.Close(); }
        }

        public bool Escribe(string sentencia)
        {
            _conexion.Open();
            _comando = new SqlCommand
            {
                CommandType = CommandType.Text,
                Connection = _conexion,
                CommandText = sentencia
            };

            try
            {
                int respuesta = _comando.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex) { throw ex; }
            finally { _conexion.Close(); }
        }
    }
}
