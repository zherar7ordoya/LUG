using BEL;

namespace BLL
{
    public class AutomovilBLL : VehiculoBLL<Automovil>
    {
        public override decimal CalcularRenta(Automovil automovil, int cantidadDias)
        {
            decimal costoPorTipo = 100;  // Costo base
            decimal costoPorModelo = 0;

            switch (automovil.Modelo)
            {
                case "Fiesta":
                    costoPorModelo = 50;
                    break;
                case "Cruze":
                    costoPorModelo = 25;
                    break;
            }

            return (costoPorTipo + costoPorModelo) * cantidadDias;
        }
    }
}
