using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABS
{
    public interface IABMC<T> where T : IEntidad
    {
        bool Agregar(T objeto);
        bool Borrar(T objeto);
        bool Modificar(T objeto);
        List<T> Consultar();
    }
}
