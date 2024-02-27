using System;

namespace ABS
{
    public interface IEmailControl
    {
        string Email { get; set; }
        event EventHandler TextChanged;
        bool Validar();
    }
}
