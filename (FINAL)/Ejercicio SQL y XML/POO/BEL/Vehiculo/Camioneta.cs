namespace BEL
{
    public class Camioneta : Vehiculo
    {
        public override decimal CalcularRenta(int cantidadDias)
        {
            decimal costoPorTipo = 50;  // Costo base

            decimal costoPorModelo = 0;

            switch (Modelo)
            {
                case "Silverado":
                    costoPorModelo = 10;
                    break;
                case "F-150":
                    costoPorModelo = 20;
                    break;
            }
            return (costoPorTipo + costoPorModelo) * cantidadDias;
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
