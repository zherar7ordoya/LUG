using System.Collections.Generic;

/* ************************************************************************** *\
La capa de Abstracciones actúa como un conjunto estandarizado de contratos o
interfaces que definen operaciones comunes para el manejo de entidades en el
contexto de la aplicación.
\* ************************************************************************** */

namespace ABS
{
    public interface IMapeadoSql<T> where T : IEntidad
    {
        List<T> MapearDesdeSql(string consulta, bool EsProcedimientoAlmacenado);
        bool MapearHaciaSql(string consulta, bool EsProcedimientoAlmacenado, T objeto);
    }
}
