using BEL;

namespace BLL
{
    public class SuvBLL : VehiculoBLL<Suv>
    {
        public override decimal CalcularRenta(Suv suv, int cantidadDias)
        {
            decimal costoPorTipo = 200;  // Costo base
            decimal costoPorModelo = 0;

            switch (suv.Modelo)
            {
                case "Rav4":
                    costoPorModelo = 100;
                    break;
                case "CR-V":
                    costoPorModelo = 50;
                    break;
            }

            return (costoPorTipo + costoPorModelo) * cantidadDias;
        }
    }
}
