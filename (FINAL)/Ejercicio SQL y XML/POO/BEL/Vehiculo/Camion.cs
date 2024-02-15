namespace BEL
{
    public class Camion : Vehiculo
    {
        public override decimal CalcularRenta(int cantidadDias)
        {
            decimal costoPorTipo = 50;  // Costo base

            decimal costoPorModelo = 0;

            switch (Modelo)
            {
                case "VNL":
                    costoPorModelo = 10;
                    break;
                case "T680":
                    costoPorModelo = 20;
                    break;
            }
            return (costoPorTipo + costoPorModelo) * cantidadDias;
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
