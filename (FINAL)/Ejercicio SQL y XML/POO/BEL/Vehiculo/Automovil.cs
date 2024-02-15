namespace BEL
{
    public class Automovil : Vehiculo
    {
        public override decimal CalcularRenta(int cantidadDias)
        {
            decimal costoPorTipo = 50;  // Costo base

            decimal costoPorModelo = 0;

            switch (Modelo)
            {
                case "Fiesta":
                    costoPorModelo = 10;
                    break;
                case "Cruze":
                    costoPorModelo = 20;
                    break;
            }
            return (costoPorTipo + costoPorModelo) * cantidadDias;
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
