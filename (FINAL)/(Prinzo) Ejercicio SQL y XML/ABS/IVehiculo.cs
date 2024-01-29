using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABS
{
    public interface IVehiculo
    {
        string Marca { get; set; }
        string Modelo { get; set; }
        string Patente { get; set; }
        decimal CalcularImporteAlquiler(int cantidadDias);
    }
}
