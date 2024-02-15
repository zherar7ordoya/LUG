using BEL;

namespace BLL
{
    public class SuvBLL : VehiculoBLL
    {
        public override decimal CalcularRenta(Vehiculo vehiculo, int cantidadDias)
        {
            decimal costoPorTipo = 200;  // Costo base
            decimal costoPorModelo = 0;

            switch (vehiculo.Modelo)
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
