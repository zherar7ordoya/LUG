using System.Collections.Generic;

/* ************************************************************************** *\
La capa de Abstracciones actúa como un conjunto estandarizado de contratos o
interfaces que definen operaciones comunes para el manejo de entidades en el
contexto de la aplicación.
\* ************************************************************************** */

namespace ABS
{
    public interface IMapeadoXml<T> where T : IEntidad
    {
        List<T> MapearDesdeXml();
        bool MapearHaciaXml(List<T> objetos);
    }
}
