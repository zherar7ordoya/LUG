using BEL;

namespace BLL
{
    // Ver nota en la clase VehiculoBLL.cs
    public class SuvBLL : VehiculoBLL<Suv>
    {
        public override decimal CalcularRenta(Suv suv, int cantidadDias)
        {
            decimal costoPorTipo = 200;  // Costo base
            decimal costoPorModelo;

            switch (suv.Modelo)
            {
                case "Rav4":
                    costoPorModelo = 100;
                    break;
                case "CR-V":
                    costoPorModelo = 50;
                    break;
                default:
                    costoPorModelo = 25;
                    break;
            }

            return (costoPorTipo + costoPorModelo) * cantidadDias;
        }
    }
}
