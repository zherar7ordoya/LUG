using BEL;
using System.Collections.Generic;


namespace MPP
{
    // Estos métodos son unos de los pocos lugares donde hubiera sido más
    // eficiente tener consultas de un solo objeto en lugar de listas.
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
