using BEL;

namespace BLL
{
    public class CamionBLL : VehiculoBLL
    {
        public override decimal CalcularRenta(Vehiculo vehiculo, int cantidadDias)
        {
            decimal costoPorTipo = 400;  // Costo base
            decimal costoPorModelo = 0;

            switch (vehiculo.Modelo)
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
