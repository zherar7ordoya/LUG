using ABS;

using BEL;

using MPP;

using System.Collections.Generic;
using System.Linq;

namespace ASL
{
    public partial class RentaASL : IABMC<Renta>
    {
        public bool Agregar(Renta objeto)
        {
            string consulta = "RentaAgregar";
            List<Renta> rentas = new RentaMPP().MapearDesdeSql("RentasConsultar");
            int codigo = rentas.Max(c => c.Codigo) + 1;
            objeto.Codigo = codigo;
            return new RentaMPP().MapearHaciaSql(consulta, objeto);
        }

        public bool Borrar(Renta objeto)
        {
            // Si mando el objeto completo, al stored procedure no le gusta: demasiados parámetros
            Renta renta = new Renta
            {
                Codigo = objeto.Codigo
            };
            string consulta = "RentaBorrar";
            return new RentaMPP().MapearHaciaSql(consulta, renta);
        }

        public bool Modificar(Renta objeto)
        {
            string consulta = "RentaModificar";
            return new RentaMPP().MapearHaciaSql(consulta, objeto);
        }

        public List<Renta> Consultar()
        {
            string consulta = "RentasConsultar";
            return new RentaMPP().MapearDesdeSql(consulta);
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
