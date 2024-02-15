using ABS;

using ASL;

using BEL;

using System.Collections.Generic;

namespace BLL
{
    public abstract partial class VehiculoBLL : IABMC<Vehiculo>
    {
        public bool Agregar(Vehiculo objeto)
        {
            return new VehiculoASL().Agregar(objeto);
        }

        public bool Borrar(Vehiculo objeto)
        {
            return new VehiculoASL().Borrar(objeto);
        }

        public bool Modificar(Vehiculo objeto)
        {
            return new VehiculoASL().Modificar(objeto);
        }

        public List<Vehiculo> Consultar()
        {
            return new VehiculoASL().Consultar();
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
