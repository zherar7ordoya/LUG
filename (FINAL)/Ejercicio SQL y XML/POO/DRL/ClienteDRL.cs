using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ABS;

using BEL;

using MPP;

namespace DRL
{
    public class ClienteDRL : IABMC<Cliente>
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
            string consulta = "ClientesConsultar";
            return clienteMPP.MapearDesdeSqlServer(consulta);
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
