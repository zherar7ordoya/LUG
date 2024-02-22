using ABS;

using BEL;

using MPP;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ************************************************************************** *\
La "Persistence Management Layer" (Capa de Gestión de Persistencia) cumple una
única responsabilidad al preparar consultas específicas y gestionar la
información necesaria para realizar las operaciones de persistencia. Actúa como
un puente entre la lógica de aplicación y la capa de acceso a datos (DAL),
siguiendo los principios SOLID al enfocarse en una tarea específica y facilitar
la extensibilidad y mantenibilidad del sistema.
\* ************************************************************************** */

namespace PML
{
    public class ClientePML : IABMC<Cliente>
    {
        public bool Agregar(Cliente objeto)
        {
            try
            {
                string consulta = "ClienteAgregar";
                List<Cliente> clientes = new ClienteMPP().MapearDesdeSql("ClientesConsultar");
                int codigo = clientes.Max(c => c.Codigo) + 1;
                objeto.Codigo = codigo;
                return new ClienteMPP().MapearHaciaSql(consulta, objeto);
            }
            catch (InvalidOperationException ex) { throw new Exception(ex.Message); }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public bool Borrar(Cliente objeto)
        {
            try
            {
                // Si mando el objeto completo, al stored procedure no le gusta: demasiados parámetros
                Cliente cliente = new Cliente
                {
                    Codigo = objeto.Codigo
                };
                string consulta = "ClienteBorrar";
                return new ClienteMPP().MapearHaciaSql(consulta, cliente);
            }
            catch (InvalidOperationException ex) { throw new Exception(ex.Message); }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public bool Modificar(Cliente objeto)
        {
            try
            {
                string consulta = "ClienteModificar";
                return new ClienteMPP().MapearHaciaSql(consulta, objeto);
            }
            catch (InvalidOperationException ex) { throw new Exception(ex.Message); }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public List<Cliente> Consultar()
        {
            try
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
            catch (InvalidOperationException ex) { throw new Exception(ex.Message); }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
