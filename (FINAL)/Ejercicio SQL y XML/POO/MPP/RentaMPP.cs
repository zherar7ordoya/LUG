using ABS;
using BEL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPP
{
    public class RentaMPP : IMapeado<Renta>
    {
        public List<Renta> MapearDesdeSqlServer()
        {
            throw new NotImplementedException();
        }

        public bool MapearHaciaSqlServer(List<Renta> entidades)
        {
            throw new NotImplementedException();
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
        public List<Renta> MapearDesdeXmlArchivo() => throw new NotImplementedException("Renta usa SQL Server");
        public bool MapearHaciaXmlArchivo(List<Renta> entidades) => throw new NotImplementedException("Renta usa SQL Server");
    }
}
