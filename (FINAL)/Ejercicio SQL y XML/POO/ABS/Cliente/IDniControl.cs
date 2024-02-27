using System;

namespace ABS
{
    public interface IDniControl
    {
        string Dni { get; set; }
        event EventHandler TextChanged;
        bool Validar();
    }
}
