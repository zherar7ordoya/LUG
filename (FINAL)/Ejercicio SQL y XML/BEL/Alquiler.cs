using ABS;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class Alquiler : IAlquiler
    {
        public IVehiculo Vehiculo { get; set; }
        public ICliente Cliente { get; set; }
        public int CantidadDias { get; set; }

        public decimal Importe => Vehiculo.CalcularImporteAlquiler(CantidadDias);
    }
}
