namespace BEL
{
    public class Renta : Entidad
    {
        public Cliente Cliente { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public int DiasRentados { get; set; }
        public decimal Importe { get; set; }

        public override string ToString()
        {
            return $"Cliente: {Cliente} - Vehículo: {Vehiculo} - Días rentados: {DiasRentados} - Importe: {Importe}";
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
