using System.Collections.Generic;

namespace ABS
{
    public interface IMapeadoXml<T> where T : IEntidad
    {
        List<T> MapearDesdeXml(string archivo);
        bool MapearHaciaXml(string archivo, List<T> objetos);
    }
}
