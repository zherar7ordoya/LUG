using System;

namespace ABS
{
    // Ver notas en IApellidoControl
    public interface IEmailControl
    {
        string Email { get; set; }
        bool Validar();
        event EventHandler TextChanged;
    }
}
