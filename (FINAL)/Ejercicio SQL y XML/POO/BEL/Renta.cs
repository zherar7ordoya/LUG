using ABS;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            // Lógica para calcular el importe basado en la cantidad de días, tipo de vehículo, etc.
            // Puedes ajustar esta lógica según tus requerimientos específicos.
            // Aquí se asume que existe un método en la clase Vehiculo para obtener el costo diario.
            Importe = 
                DiasRentados * 
                TarifarTipo(Vehiculo.Tipo) * 
                TarifarModelo(Vehiculo.Modelo);
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||| HERRAMIENTAS


        private decimal TarifarTipo(string tipo)
        {
            return Math.Abs(tipo.GetHashCode()) % 10000;
        }

        private decimal TarifarModelo(string modelo)
        {
            return Math.Abs(modelo.GetHashCode()) % 10000;
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

        public override string ToString()
        {
            return $"Cliente: {Cliente} - Vehículo: {Vehiculo} - Días rentados: {DiasRentados} - Importe: {Importe}";
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
