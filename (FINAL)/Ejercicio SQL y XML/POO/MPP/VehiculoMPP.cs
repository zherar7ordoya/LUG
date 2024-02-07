using ABS;
using BEL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPP
{
    public class VehiculoMPP : IMapeador<Vehiculo>
    {
        public List<Vehiculo> MapearDesdeSqlServer()
        {
            throw new NotImplementedException("Vehiculo usa XML Archivo");
        }

        public List<Vehiculo> MapearDesdeXmlArchivo()
        {
            throw new NotImplementedException();
        }

        public bool MapearHaciaSqlServer(Vehiculo entidad)
        {
            throw new NotImplementedException("Vehiculo usa XML Archivo");
        }

        public bool MapearHaciaXmlArchivo(Vehiculo entidad)
        {
            throw new NotImplementedException();
        }
    }
}
