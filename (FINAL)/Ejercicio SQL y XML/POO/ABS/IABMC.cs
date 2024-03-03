using System.Collections.Generic;


namespace ABS
{
    // Es cierto que hubiera sido más eficiente diferenciar entre "ConsultarUno"
    // y "ConsultarTodos", pero lo hice así para que sea más fácil de implementar
    // y para mantener eso de "ABMC".
    public interface IABMC<T> where T : IEntidad
    {
        bool Agregar(T objeto);
        bool Borrar(T objeto);
        bool Modificar(T objeto);
        List<T> Consultar();
    }
}
