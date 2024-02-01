public class Renta
{
    // Atributos
    public Cliente Cliente { get; set; }
    public Vehiculo Vehiculo { get; set; }
    public int DiasRentados { get; set; }
    public decimal Importe { get; set; }

    // Constructor
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
        // Lógica para calcular el importe basado en la cantidad de días, tipo de vehículo, etc.
        // Puedes ajustar esta lógica según tus requerimientos específicos.
        // Aquí se asume que existe un método en la clase Vehiculo para obtener el costo diario.
        Importe = DiasRentados * Vehiculo.ObtenerCostoDiario();
    }

    // Otros métodos, si es necesario
    static int TarifarModelo(string modelo)
    {
        return Math.Abs(modelo.GetHashCode()) % 10000;
    }
}
