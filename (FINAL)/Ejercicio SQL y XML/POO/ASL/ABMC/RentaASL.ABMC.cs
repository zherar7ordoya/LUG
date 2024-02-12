using ABS;

using BEL;

using MPP;

using System.Collections.Generic;

namespace ASL
{
    public partial class RentaASL : IABMC<Renta>
    {
        public bool Agregar(Renta objeto)
        {
            string consulta = "RentaAgregar";
            return new RentaMPP().MapearHaciaSqlServer(consulta, objeto);
        }

        public bool Borrar(Renta objeto)
        {
            string consulta = "RentaBorrar";
            return new RentaMPP().MapearHaciaSqlServer(consulta, objeto);
        }

        public bool Modificar(Renta objeto)
        {
            string consulta = "RentaModificar";
            return new RentaMPP().MapearHaciaSqlServer(consulta, objeto);
        }

        public List<Renta> Consultar()
        {
            string consulta = "RentasConsultar";
            return new RentaMPP().MapearDesdeSqlServer(consulta);
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
