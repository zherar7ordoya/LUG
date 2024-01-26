using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMC
{
    public interface IGestor<T> where T : IEntidad
    {
        bool Guardar(T objeto);
        bool Eliminar(T objeto);
        bool Actualizar(T objeto);
        List<T> ListarTodo();
        T ListarObjeto(T objeto);
    }
}
