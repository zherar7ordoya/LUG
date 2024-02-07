using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABS
{
    public interface IMapeado<T> where T : IEntidad
    {
        List<T> MapearDesdeSqlServer();
        bool MapearHaciaSqlServer(string consulta, T objeto);
        List<T> MapearDesdeXmlArchivo();
        bool MapearHaciaXmlArchivo(List<T> objetos);
    }
}
