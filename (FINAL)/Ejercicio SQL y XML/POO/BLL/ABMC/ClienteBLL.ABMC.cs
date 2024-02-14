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
            if (ValidarEdad(objeto.FechaNacimiento))
            {
                return new ClienteASL().Agregar(objeto);
            }
            return false;
        }

        public bool Borrar(Cliente objeto)
        {
            return new ClienteASL().Borrar(objeto);
        }

        public bool Modificar(Cliente objeto)
        {
            if (ValidarEdad(objeto.FechaNacimiento))
            {
                return new ClienteASL().Modificar(objeto);
            }
            return false;
        }

        public List<Cliente> Consultar()
        {
            return new ClienteASL().Consultar();
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
