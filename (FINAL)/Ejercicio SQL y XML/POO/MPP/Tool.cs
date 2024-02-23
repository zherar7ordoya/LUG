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
            List<Vehiculo> vehiculos = new VehiculoMPP("Vehiculo.xml").MapearDesdeXml();
            return vehiculos.Find(vehiculo => vehiculo.Codigo == codigo);
        }
    }
}
