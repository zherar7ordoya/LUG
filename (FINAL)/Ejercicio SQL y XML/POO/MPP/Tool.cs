using BEL;

using System.Collections.Generic;

namespace MPP
{

    static public class Tool
    {
        private static readonly ClienteMPP clienteMPP = new ClienteMPP();
        private static readonly VehiculoMPP vehiculoMPP = new VehiculoMPP();

        public static Cliente ObtenerClientePorCodigo(int codigo)
        {
            List<Cliente> clientes = clienteMPP.MapearDesdeSqlServer();
            return clientes.Find(cliente => cliente.Codigo == codigo);
        }

        public static Vehiculo ObtenerVehiculoPorCodigo(int codigo)
        {
            List<Vehiculo> vehiculos = vehiculoMPP.MapearDesdeXmlArchivo();
            return vehiculos.Find(vehiculo => vehiculo.Codigo == codigo);
        }
    }
}
