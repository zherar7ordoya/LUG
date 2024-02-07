using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABS
{
    public interface IABMC<T> where T : IEntidad
    {
        bool Actualizar(T objeto);
        bool Eliminar(T objeto);
        bool Guardar(T objeto);
        List<T> Listar();
    }
}
