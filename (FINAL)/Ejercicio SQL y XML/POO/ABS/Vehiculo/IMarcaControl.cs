using System;

namespace ABS
{
    public interface IMarcaControl
    {
        // Ver notas en IApellidoControl
        string Marca { get; set; }
        event EventHandler TextChanged;
        bool Validar();
    }
}
