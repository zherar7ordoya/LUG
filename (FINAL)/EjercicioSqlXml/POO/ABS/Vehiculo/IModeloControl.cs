using System;

namespace ABS
{
    public interface IModeloControl
    {
        // Ver notas en IApellidoControl
        string Modelo { get; set; }
        event EventHandler TextChanged;
        bool Validar();
    }
}
