namespace BEL
{
    public class Renta : Entidad
    {
        // Atributos
        public Cliente Cliente { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public int DiasRentados { get; set; }
        public decimal Importe { get; set; }

        // Constructores
        public Renta() { }
        public Renta(Cliente cliente, Vehiculo vehiculo, int diasRentados)
        {
            Cliente = cliente;
            Vehiculo = vehiculo;
            DiasRentados = diasRentados;
            CalcularImporte();
        }

        // Método para calcular el importe de la renta
        private void CalcularImporte()
        {
        }



        // 
        public override string ToString()
        {
            return $"Cliente: {Cliente} - Vehículo: {Vehiculo} - Días rentados: {DiasRentados} - Importe: {Importe}";
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
