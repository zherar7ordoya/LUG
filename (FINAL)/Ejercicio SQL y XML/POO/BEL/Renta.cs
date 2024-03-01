namespace BEL
{
    public class Renta : Entidad
    {
        public Renta()
        {
            // 🅱🆁🅴🅰🅺🅸🅽🅶 🅱🅰🅳
        }
        public Renta
            (
            int codigo,
            Cliente cliente,
            Vehiculo vehiculo,
            int diasRentados,
            decimal importe
            )
        {
            Codigo = codigo;
            Cliente = cliente;
            Vehiculo = vehiculo;
            DiasRentados = diasRentados;
            Importe = importe;
        }

        public Cliente Cliente { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public int DiasRentados { get; set; }
        public decimal Importe { get; set; }
    }
}
