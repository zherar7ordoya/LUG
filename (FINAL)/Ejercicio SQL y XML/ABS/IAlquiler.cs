using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABS
{
    public interface IAlquiler
    {
        IVehiculo Vehiculo { get; set; }
        ICliente Cliente { get; set; }
        int CantidadDias { get; set; }
        decimal Importe { get; }
    }
}
