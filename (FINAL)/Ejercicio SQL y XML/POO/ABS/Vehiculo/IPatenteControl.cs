using System;

namespace ABS
{
    public interface IPatenteControl
    {
        string Patente { get; set; }
        event EventHandler TextChanged;
        bool Validar();
    }
}
