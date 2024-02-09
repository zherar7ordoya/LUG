using ABS;

using BEL;

using MPP;

using System.Collections.Generic;

namespace ASL
{
    public class RentaASL : IABMC<Renta>
    {
        readonly RentaMPP rentaMPP = new RentaMPP();

        public bool Modificar(Renta objeto)
        {
            string consulta = "RentaModificar";
            return rentaMPP.MapearHaciaSqlServer(consulta, objeto);
        }

        public bool Borrar(Renta objeto)
        {
            string consulta = "RentaBorrar";
            return rentaMPP.MapearHaciaSqlServer(consulta, objeto);
        }

        public bool Agregar(Renta objeto)
        {
            string consulta = "RentaAgregar";
            return rentaMPP.MapearHaciaSqlServer(consulta, objeto);
        }

        public List<Renta> Consultar()
        {
            string consulta = "RentasConsultar";
            return rentaMPP.MapearDesdeSqlServer(consulta);
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
