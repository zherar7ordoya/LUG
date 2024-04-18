using System;

namespace ABS
{
    public interface IPatenteControl
    {
        // Ver notas en IApellidoControl
        string Patente { get; set; }
        event EventHandler TextChanged;
        bool Validar();
    }
}
