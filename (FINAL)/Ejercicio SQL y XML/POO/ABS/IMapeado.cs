using System.Collections.Generic;

namespace ABS
{
    public interface IMapeado<T> where T : IEntidad
    {
        List<T> MapearDesdeSqlServer(string consulta);
        List<T> MapearDesdeXmlArchivo(string archivo);
        bool MapearHaciaSqlServer(string consulta, T objeto);
        bool MapearHaciaXmlArchivo(string archivo, List<T> objetos);
    }
}
