using ABS;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    class Camion : IVehiculo
    {
        public string Marca { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Modelo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Patente { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public decimal CalcularImporteAlquiler(int cantidadDias)
        {
            throw new NotImplementedException();
        }
    }
}
