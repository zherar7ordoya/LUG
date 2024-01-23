using DAL;

using System.Data;

namespace BLL
{
    public class ClsPersona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public int Saldo { get; set; }

        public DataSet ListarConSaldo()
        {
            Datos ODatos = new Datos();
            string consulta = "SELECT * FROM Persona";
            return ODatos.Leer(consulta);
        }

        public DataSet ListarSinSaldo()
        {
            Datos ODatos = new Datos();

            string query =
               "SELECT Persona_id, Persona_nombre, Persona_apellido, Persona_direccion FROM Persona; " +
               "SELECT MAX(persona_id) FROM Persona";
            return ODatos.Leer(query);
        }
    }
}
