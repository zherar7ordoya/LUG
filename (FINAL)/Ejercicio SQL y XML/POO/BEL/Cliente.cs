using ABS;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class Cliente : Entidad
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Email { get; set; }
        public List<Vehiculo> VehiculosRentados { get; set; }

        public override string ToString()
        {
            return $"Código: {Codigo} - Cliente: {Nombre} {Apellido}";
        }
    }
}
