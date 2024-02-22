using ABS;



using BEL;

using PML;

using System.Collections.Generic;

namespace BLL
{
    public partial class ClienteBLL : IABMC<Cliente>
    {
        public bool Agregar(Cliente objeto)
        {
            if (ValidarEdad(objeto.FechaNacimiento))
            {
                return new ClientePML().Agregar(objeto);
            }
            return false;
        }

        public bool Borrar(Cliente objeto)
        {
            return new ClientePML().Borrar(objeto);
        }

        public bool Modificar(Cliente objeto)
        {
            if (ValidarEdad(objeto.FechaNacimiento))
            {
                return new ClientePML().Modificar(objeto);
            }
            return false;
        }

        public List<Cliente> Consultar()
        {
            return new ClientePML().Consultar();
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
