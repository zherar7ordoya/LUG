using ABS;

using ASL;

using BEL;

using System.Collections.Generic;

namespace BLL
{
    public partial class RentaBLL : IABMC<Renta>
    {
        public bool Agregar(Renta objeto)
        {
            return new RentaASL().Agregar(objeto);
        }

        public bool Borrar(Renta objeto)
        {
            return new RentaASL().Borrar(objeto);
        }

        public bool Modificar(Renta objeto)
        {
            return new RentaASL().Modificar(objeto);
        }

        public List<Renta> Consultar()
        {
            return new RentaASL().Consultar();
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
