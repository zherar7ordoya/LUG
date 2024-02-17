using ABS;

using ASL;

using BEL;

using System.Collections.Generic;

namespace BLL
{
    public partial class VehiculoBLL : IABMC<Vehiculo>
    {
        public bool Agregar(Vehiculo objeto)
        {
            return new VehiculoASL().Agregar(objeto);
        }

        public bool Borrar(Vehiculo objeto)
        {
            if (Tool.SinAsignar(objeto))
            {
                return new VehiculoASL().Borrar(objeto);
            }
            return false;
        }

        public bool Modificar(Vehiculo objeto)
        {
            return new VehiculoASL().Modificar(objeto);
        }

        public List<Vehiculo> Consultar()
        {
            return new VehiculoASL().Consultar();
        }
    }
}
