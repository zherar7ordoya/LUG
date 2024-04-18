using BEL;

namespace BLL
{
    // Ver nota en la clase VehiculoBLL.cs
    public class CamionetaBLL : VehiculoBLL<Camioneta>
    {
        public override decimal CalcularRenta(Camioneta camioneta, int cantidadDias)
        {
            decimal costoPorTipo = 300;  // Costo base
            decimal costoPorModelo;

            switch (camioneta.Modelo)
            {
                case "Silverado":
                    costoPorModelo = 150;
                    break;
                case "F-150":
                    costoPorModelo = 75;
                    break;
                default:
                    costoPorModelo = 37.5m; // Notación literal de decimal
                    break;
            }

            return (costoPorTipo + costoPorModelo) * cantidadDias;
        }
    }
}
