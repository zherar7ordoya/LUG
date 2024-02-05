using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABS
{
    public interface IABMC<T> where T : IEntidad
    {
        bool Actualizar(T entidad);
        bool Eliminar(T entidad);
        bool Guardar(T entidad);
        List<T> Listar();
    }
}
