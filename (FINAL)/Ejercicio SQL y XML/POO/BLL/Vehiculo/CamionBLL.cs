using BEL;

namespace BLL
{
    // Ver nota en la clase VehiculoBLL.cs
    public class CamionBLL : VehiculoBLL<Camion>
    {
        public override decimal CalcularRenta(Camion camion, int cantidadDias)
        {
            decimal costoPorTipo = 400;  // Costo base
            decimal costoPorModelo;

            switch (camion.Modelo)
            {
                case "VNL":
                    costoPorModelo = 200;
                    break;
                case "T680":
                    costoPorModelo = 100;
                    break;
                default:
                    costoPorModelo = 50;
                    break;
            }

            return (costoPorTipo + costoPorModelo) * cantidadDias;
        }
    }
}
