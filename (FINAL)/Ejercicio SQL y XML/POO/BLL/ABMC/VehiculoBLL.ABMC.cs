using ABS;



using BEL;

using PML;

using System.Collections.Generic;

namespace BLL
{
    public partial class VehiculoBLL : IABMC<Vehiculo>
    {
        public bool Agregar(Vehiculo objeto)
        {
            return new VehiculoPML().Agregar(objeto);
        }

        public bool Borrar(Vehiculo objeto)
        {
            if (Tool.SinAsignar(objeto))
            {
                return new VehiculoPML().Borrar(objeto);
            }
            return false;
        }

        public bool Modificar(Vehiculo objeto)
        {
            return new VehiculoPML().Modificar(objeto);
        }

        public List<Vehiculo> Consultar()
        {
            return new VehiculoPML().Consultar();
        }
    }
}
