using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABS
{
    public interface ICliente
    {
        string Nombre { get; set; }
        string Apellido { get; set; }
        int DNI { get; set; }
        DateTime FechaNacimiento { get; set; }
        string CorreoElectronico { get; set; }
        IVehiculo VehiculoAlquilado { get; set; }
    }
}
