using BEL;

namespace BLL
{
    public class CamionetaBLL : VehiculoBLL
    {
        public override decimal CalcularRenta(Vehiculo vehiculo, int cantidadDias)
        {
            decimal costoPorTipo = 300;  // Costo base
            decimal costoPorModelo = 0;

            switch (vehiculo.Modelo)
            {
                case "Silverado":
                    costoPorModelo = 150;
                    break;
                case "F-150":
                    costoPorModelo = 75;
                    break;
            }
            return (costoPorTipo + costoPorModelo) * cantidadDias;
        }
    }
}
