using System;

namespace ABS
{
    public interface IApellidoControl
    {
        string Apellido { get; set; }
        event EventHandler TextChanged;
        bool Validar();
    }
}
