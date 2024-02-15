namespace BEL
{
    public class Suv: Vehiculo
    {
        public override decimal CalcularRenta(int cantidadDias)
        {
            decimal costoPorTipo = 50;  // Costo base

            decimal costoPorModelo = 0;

            switch (Modelo)
            {
                case "Rav4":
                    costoPorModelo = 10;
                    break;
                case "CR-V":
                    costoPorModelo = 20;
                    break;
            }
            return (costoPorTipo + costoPorModelo) * cantidadDias;
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
