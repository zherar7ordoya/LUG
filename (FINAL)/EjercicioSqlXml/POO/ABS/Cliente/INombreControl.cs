using System;

namespace ABS
{
    // Ver notas en IApellidoControl
    public interface INombreControl
    {
        string Nombre { get; set; }
        event EventHandler TextChanged;
        bool Validar();
    }
}
