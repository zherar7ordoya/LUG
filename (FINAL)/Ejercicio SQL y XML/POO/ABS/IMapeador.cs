using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABS
{
    public interface IMapeador<T> where T : IEntidad
    {
        List<T> MapearDesdeSqlServer();
        bool MapearHaciaSqlServer(T entidad);
        List<T> MapearDesdeXmlArchivo();
        bool MapearHaciaXmlArchivo(T entidad);
    }
}
