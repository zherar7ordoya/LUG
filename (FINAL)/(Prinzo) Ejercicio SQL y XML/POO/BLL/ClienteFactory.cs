using ABS;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClienteFactory
    {
        public static ICliente CrearCliente(string nombre, string apellido, int dni, DateTime fechaNacimiento, string correoElectronico)
        {
            // Creación de un cliente específico (por ejemplo, ClienteNormal o ClienteVIP) según criterios
            return null;
        }
    }

    // Ejemplo de clase ClienteNormal que implementa ICliente
    public class ClienteNormal : ICliente
    {
        // Implementación de la interfaz ICliente para ClienteNormal
        public string Nombre { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Apellido { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int DNI { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime FechaNacimiento { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CorreoElectronico { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IVehiculo VehiculoAlquilado { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

}
