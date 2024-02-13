using System.Collections.Generic;

namespace ABS
{
    public interface IMapeadoSql<T> where T : IEntidad
    {
        List<T> MapearDesdeSql(string consulta);
        bool MapearHaciaSql(string consulta, T objeto);
    }
}
