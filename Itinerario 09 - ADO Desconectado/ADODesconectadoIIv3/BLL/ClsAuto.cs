using DAL;
using System.Data;

namespace BLL
{
    public class ClsAuto
    {
        int Id { get; set; }
        string Marca { get; set; }
        string Modelo { get; set; }
        string Patente { get; set; }
        string Color { get; set; }

        public DataSet Listar()
        {
            Datos ODatos = new Datos();
            string consulta = "SELECT * FROM Auto";
            return ODatos.Leer(consulta);
        }

    }
}
