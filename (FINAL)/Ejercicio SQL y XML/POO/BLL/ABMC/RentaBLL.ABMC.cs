using ABS;



using BEL;

using PML;

using System.Collections.Generic;

namespace BLL
{
    public partial class RentaBLL : IABMC<Renta>
    {
        public bool Agregar(Renta objeto)
        {
            return new RentaPML().Agregar(objeto);
        }

        public bool Borrar(Renta objeto)
        {
            return new RentaPML().Borrar(objeto);
        }

        public bool Modificar(Renta objeto)
        {
            return new RentaPML().Modificar(objeto);
        }

        public List<Renta> Consultar()
        {
            return new RentaPML().Consultar();
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
