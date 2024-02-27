using System;

namespace ABS
{
    public interface INombreControl
    {
        string Nombre { get; set; }
        event EventHandler TextChanged;
        bool Validar();
    }
}
