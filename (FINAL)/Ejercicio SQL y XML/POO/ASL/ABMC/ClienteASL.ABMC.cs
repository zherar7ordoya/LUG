using ABS;

using BEL;

using MPP;

using System.Collections.Generic;
using System.Linq;

namespace ASL
{
    public partial class ClienteASL : IABMC<Cliente>
    {
        public bool Agregar(Cliente objeto)
        {
            string consulta = "ClienteAgregar";
            List<Cliente> clientes = new ClienteMPP().MapearDesdeSql("ClientesConsultar");
            int codigo = clientes.Max(c => c.Codigo) + 1;
            objeto.Codigo = codigo;
            return new ClienteMPP().MapearHaciaSql(consulta, objeto);
        }

        public bool Borrar(Cliente objeto)
        {
            // Si mando el objeto completo, al stored procedure no le gusta: demasiados parámetros
            Cliente cliente = new Cliente
            {
                Codigo = objeto.Codigo
            };

            string consulta = "ClienteBorrar";
            return new ClienteMPP().MapearHaciaSql(consulta, cliente);
        }

        public bool Modificar(Cliente objeto)
        {
            string consulta = "ClienteModificar";
            return new ClienteMPP().MapearHaciaSql(consulta, objeto);
        }

        public List<Cliente> Consultar()
        {
            List<Cliente> clientes = new ClienteMPP().MapearDesdeSql("ClientesConsultar");
            List<Renta> rentas = new RentaMPP().MapearDesdeSql("RentasConsultar");

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
