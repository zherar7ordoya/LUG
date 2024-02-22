using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class Alumno
    {
        public Alumno() { }
        public Alumno(object[] pO) { Id = int.Parse(pO[0].ToString());Nombre = pO[1].ToString(); Apellido = pO[2].ToString();Fecha_Alta = DateTime.Parse(pO[3].ToString());Activo = bool.Parse(pO[4].ToString()); }
        public Alumno(int pId, string pNombre,string pApellido, DateTime pFechaAlta, bool pActivo) { Id = pId;Nombre = pNombre;Apellido = pApellido; Fecha_Alta = pFechaAlta;Activo = pActivo; }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime Fecha_Alta { get; set; }
        public bool Activo { get; set; }

       
    }
}
