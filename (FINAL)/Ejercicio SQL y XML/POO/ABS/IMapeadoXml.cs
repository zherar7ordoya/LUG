using System.Collections.Generic;


namespace ABS
{
    // ¿Era necesaria esta interfaz? Ver nota en IMapeadoSql
    public interface IMapeadoXml<T> where T : IEntidad
    {
        List<T> MapearDesdeXml();
        bool MapearHaciaXml(List<T> objetos);
    }
}
