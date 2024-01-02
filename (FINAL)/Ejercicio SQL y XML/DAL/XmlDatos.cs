

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class XmlDatos
    {
        // Ejemplo de consulta LINQ para obtener todos los clientes que alquilaron un vehículo en un rango de fechas
        
        
        /*
        public List<ICliente> ObtenerClientesPorRangoDeFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            List<ICliente> clientes = ObtenerTodosLosClientes(); // Método para obtener todos los clientes

            List<ICliente> clientesFiltrados = clientes.Where(cliente =>
                cliente.VehiculoAlquilado != null &&
                cliente.VehiculoAlquilado.FechaAlquiler >= fechaInicio &&
                cliente.VehiculoAlquilado.FechaAlquiler <= fechaFin
            ).ToList();

            return clientesFiltrados;
        }

        private List<ICliente> ObtenerTodosLosClientes()
        {
            throw new NotImplementedException();
        }
        */

    }
}
