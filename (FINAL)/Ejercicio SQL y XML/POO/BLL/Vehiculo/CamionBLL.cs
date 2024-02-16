using BEL;

namespace BLL
{
    public class CamionBLL : VehiculoBLL<Camion>
    {
        public override decimal CalcularRenta(Camion camion, int cantidadDias)
        {
            decimal costoPorTipo = 400;  // Costo base
            decimal costoPorModelo = 0;

            switch (camion.Modelo)
            {
                case "VNL":
                    costoPorModelo = 200;
                    break;
                case "T680":
                    costoPorModelo = 100;
                    break;
            }

            return (costoPorTipo + costoPorModelo) * cantidadDias;
        }
    }
}
