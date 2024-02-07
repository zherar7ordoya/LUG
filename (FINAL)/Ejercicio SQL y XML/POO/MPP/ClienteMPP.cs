using ABS;

using BEL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPP
{
    public class ClienteMPP : IMapeador<Cliente>
    {
        public List<Cliente> MapearDesdeSqlServer()
        {
            throw new NotImplementedException();
        }

        public List<Cliente> MapearDesdeXmlArchivo()
        {
            throw new NotImplementedException("Cliente usa SQL Server");
        }

        public bool MapearHaciaSqlServer(Cliente entidad)
        {
            throw new NotImplementedException();
        }

        public bool MapearHaciaXmlArchivo(Cliente entidad)
        {
            throw new NotImplementedException("Cliente usa SQL Server");
        }
    }
}
