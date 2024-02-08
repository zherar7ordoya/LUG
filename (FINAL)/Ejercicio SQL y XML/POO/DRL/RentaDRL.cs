using ABS;

using BEL;

using MPP;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRL
{
    public class RentaDRL : IABMC<Renta>
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
    }
}
