namespace BEL
{
    public class Vehiculo : Entidad
    {
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Patente { get; set; }

        public override string ToString()
        {
            return string.Format($"Tipo: {Tipo} - Marca: {Marca} - Modelo: {Modelo} - Patente: {Patente}");
        }
    }
}
