using ABS;

using BEL;

using MPP;

using System.Collections.Generic;

namespace ASL
{
    public class ClienteASL : IABMC<Cliente>
    {
        readonly ClienteMPP clienteMPP = new ClienteMPP();

        public bool Modificar(Cliente objeto)
        {
            string consulta = "ClienteActualizar";
            return clienteMPP.MapearHaciaSqlServer(consulta, objeto);
        }

        public bool Borrar(Cliente objeto)
        {
            string consulta = "ClienteEliminar";
            return clienteMPP.MapearHaciaSqlServer(consulta, objeto);
        }

        public bool Agregar(Cliente objeto)
        {
            string consulta = "ClienteGuardar";
            return clienteMPP.MapearHaciaSqlServer(consulta, objeto);
        }

        public List<Cliente> Consultar()
        {
            List<Cliente> clientes = new ClienteMPP().MapearDesdeSqlServer("ClientesConsultar");
            List<Renta> rentas = new RentaMPP().MapearDesdeSqlServer("RentasConsultar");

            foreach (Renta renta in rentas)
            {
                Cliente cliente = clientes.Find(c => c.Codigo == renta.Cliente.Codigo);
                cliente?.VehiculosRentados.Add(renta.Vehiculo);
            }
            return clientes;
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
