using System;

namespace ABS
{
    // Ver notas en IApellidoControl
    public interface IDniControl
    {
        string Dni { get; set; }
        event EventHandler TextChanged;
        bool Validar();
    }
}
