using System;

namespace ABS
{
    public interface IModeloControl
    {
        string Modelo { get; set; }
        event EventHandler TextChanged;
        bool Validar();
    }
}
