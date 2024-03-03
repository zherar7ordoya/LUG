using BEL;

namespace BLL
{
    // Ver nota en la clase VehiculoBLL.cs
    public class AutomovilBLL : VehiculoBLL<Automovil>
    {
        public override decimal CalcularRenta(Automovil automovil, int cantidadDias)
        {
            decimal costoPorTipo = 100;  // Costo base
            decimal costoPorModelo;

            switch (automovil.Modelo)
            {
                case "Fiesta":
                    costoPorModelo = 50;
                    break;
                case "Cruze":
                    costoPorModelo = 25;
                    break;
                default:
                    costoPorModelo = 12.5m; // Notación literal de decimal
                    break;
            }

            return (costoPorTipo + costoPorModelo) * cantidadDias;
        }
    }
}
