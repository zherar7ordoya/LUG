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
        Importe = DiasRentados * Vehiculo.Tipo * Vehiculo.Modelo;
    }

    // Otros métodos, si es necesario
    private decimal TarifarTipo(string tipo)
    {
        return Math.Abs(tipo.GetHashCode()) % 10000;
    }

    private decimal TarifarModelo(string modelo)
    {
        return Math.Abs(modelo.GetHashCode()) % 10000;
    }


    /*
    FALTA UN MÉTODO PUBLICO PARA EL REPORTE SOLICITADO:

    "La empresa desea saber que vehículo fue alquilado, el cliente que lo posee,
    la cantidad de días de la renta, y el importe de la misma."

    PARA ELLO, HAY QUE SOBEESCRIBIR EL MÉTODO ToString() DE LA CLASE Cliente.
    TODOS LOS DATOS ESTÁN AQUÍ (Vehiculo, Cliente, DiasRentados, Importe).

    PUNTO 7. TRES MÉTODOS MÁS:
        a. Los vehículos más rentados, por tipo y el monto. 
        b. Los vehículos menos rentados, por tipo y monto.
        c. El monto total recaudado por tipo de transporte.
    */


}
