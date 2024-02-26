using System;

namespace ABS
{
    public interface IMarcaControl
    {
        string Marca { get; set; }
        event EventHandler TextChanged;
        bool Validar();
    }
}
