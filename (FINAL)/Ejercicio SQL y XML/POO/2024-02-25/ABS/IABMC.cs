using System.Collections.Generic;


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
