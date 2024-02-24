using System.Collections.Generic;


namespace ABS
{
    public interface IMapeadoXml<T> where T : IEntidad
    {
        List<T> MapearDesdeXml();
        bool MapearHaciaXml(List<T> objetos);
    }
}
