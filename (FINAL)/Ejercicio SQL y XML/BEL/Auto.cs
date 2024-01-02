using ABS;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class Auto : IVehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Patente { get; set; }

        public decimal CalcularImporteAlquiler(int cantidadDias)
        {
            // Implementación específica para cálculo de importe de alquiler de Auto
            return 0;
        }
    }
}
