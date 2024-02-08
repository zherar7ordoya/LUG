using System.Collections.Generic;

namespace ABS
{
    public interface IMapeado<T> where T : IEntidad
    {
        List<T> MapearDesdeOrigen();
        bool MapearHaciaSqlServer(string consulta, T objeto);
        bool MapearHaciaXmlArchivo(List<T> objetos);
    }
}
