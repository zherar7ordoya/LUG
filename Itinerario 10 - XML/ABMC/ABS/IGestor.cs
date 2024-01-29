using System.Collections.Generic;

namespace ABMC
{
    public interface IGestor<T> where T : IEntidad
    {
        bool Actualizar(T objeto);
        bool Eliminar(T objeto);
        bool Guardar(T objeto);
        T ListarObjeto(T objeto);
        List<T> ListarTodo();
    }
}
