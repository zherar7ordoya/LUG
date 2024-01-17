using System.Collections.Generic;

namespace Abstraccion
{
    /// <summary>
    /// El santo grial de la abstracción, el gestor de objetos.
    /// </summary>
    /// <typeparam name="T">El objeto con el que estás trabajando.</typeparam>
    public interface IGestor<T> where T : IEntidad
    {
        bool Guardar(T objeto);
        bool Eliminar(T objeto);
        List<T> ListarTodo();
        T ListarObjeto(T objeto);
    }
}
