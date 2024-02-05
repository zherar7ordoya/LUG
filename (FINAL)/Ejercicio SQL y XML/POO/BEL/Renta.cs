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
            Importe = 
                DiasRentados * 
                TarifarTipo(Vehiculo.Tipo) * 
                TarifarModelo(Vehiculo.Modelo);
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

        public List<Renta> ObtenerTodosVehiculosRentados()
        {
            // Lógica para obtener los vehículos rentados
            // Puedes ajustar esta lógica según tus requerimientos específicos.
            return new List<Renta>();
        }

        public List<Renta> ObtenerVehiculosMasRentados()
        {
            // Lógica para obtener los vehículos más rentados
            // Puedes ajustar esta lógica según tus requerimientos específicos.
            return new List<Renta>();
        }

        public List<Renta> ObtenerVehiculosMenosRentados()
        {
            // Lógica para obtener los vehículos menos rentados
            // Puedes ajustar esta lógica según tus requerimientos específicos.
            return new List<Renta>();
        }

        public decimal ObtenerRecaudacionPorTipo(string tipo)
        {
            // Lógica para obtener el monto total recaudado por tipo de transporte
            // Puedes ajustar esta lógica según tus requerimientos específicos.
            return 0;
        }



        public override string ToString()
        {
            return $"Cliente: {Cliente} - Vehículo: {Vehiculo} - Días rentados: {DiasRentados} - Importe: {Importe}";
        }
    }
}
