using BEL;

using System.Collections.Generic;

namespace MPP
{

    static public class Tool
    {
        public static Cliente ObtenerClientePorCodigo(int codigo)
        {
            List<Cliente> clientes = new ClienteMPP().MapearDesdeSql(true, "ClientesConsultar");
            return clientes.Find(cliente => cliente.Codigo == codigo);
        }

        public static Vehiculo ObtenerVehiculoPorCodigo(int codigo)
        {
            List<Vehiculo> vehiculos = new VehiculoMPP().MapearDesdeXml("Vehiculo.xml");
            return vehiculos.Find(vehiculo => vehiculo.Codigo == codigo);
        }

        public static List<Vehiculo> ObtenerVehiculosRentadosPorCliente(int codigo)
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();

            List<Renta> todos = new RentaMPP().MapearDesdeSql(true, "RentasConsultar");
            List<Renta> rentas = todos.FindAll(renta => renta.Cliente.Codigo == codigo);

            foreach (Renta renta in rentas)
            {
                vehiculos.Add(renta.Vehiculo);
            }
            return vehiculos;
        }
    }
}
