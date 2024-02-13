using BEL;

using System.Collections.Generic;

namespace MPP
{

    static public class Tool
    {
        private static readonly ClienteMPP clienteMPP = new ClienteMPP();
        private static readonly RentaMPP rentaMPP = new RentaMPP();
        private static readonly VehiculoMPP vehiculoMPP = new VehiculoMPP();

        public static Cliente ObtenerClientePorCodigo(int codigo)
        {
            List<Cliente> clientes = clienteMPP.MapearDesdeSql("ClientesConsultar");
            return clientes.Find(cliente => cliente.Codigo == codigo);
        }

        public static Vehiculo ObtenerVehiculoPorCodigo(int codigo)
        {
            List<Vehiculo> vehiculos = vehiculoMPP.MapearDesdeXml("Vehiculo.xml");
            return vehiculos.Find(vehiculo => vehiculo.Codigo == codigo);
        }

        public static List<Vehiculo> ObtenerVehiculosRentadosPorCliente(int codigo)
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();

            List<Renta> todos = rentaMPP.MapearDesdeSql("RentasConsultar");
            List<Renta> rentas = todos.FindAll(renta => renta.Cliente.Codigo == codigo);

            foreach (Renta renta in rentas)
            {
                vehiculos.Add(renta.Vehiculo);
            }
            return vehiculos;
        }
    }
}
