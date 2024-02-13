using ABS;

using ASL;

using BEL;

using System.Collections.Generic;

namespace BLL
{
    public partial class ClienteBLL : IABMC<Cliente>
    {
        public bool Agregar(Cliente objeto)
        {
            return new ClienteASL().Agregar(objeto);
        }

        public bool Borrar(Cliente objeto)
        {
            return new ClienteASL().Borrar(objeto);
        }

        public bool Modificar(Cliente objeto)
        {
            return new ClienteASL().Modificar(objeto);
        }

        public List<Cliente> Consultar()
        {
            return new ClienteASL().Consultar();
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
