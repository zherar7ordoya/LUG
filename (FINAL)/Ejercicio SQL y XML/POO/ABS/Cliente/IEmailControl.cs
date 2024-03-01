using System;

namespace ABS
{
    public interface IEmailControl
    {
        string Email { get; set; }
        bool Validar();
        event EventHandler TextChanged;
    }
}
