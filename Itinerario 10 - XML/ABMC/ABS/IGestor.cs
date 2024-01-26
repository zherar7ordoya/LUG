using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
