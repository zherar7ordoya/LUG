using System;

namespace ABS
{
    public interface IImporteControl
    {
        string Importe { get; set; }
        bool Enabled { get; set; }
        event EventHandler TextChanged;
        bool Validar();
        void Update();
    }
}
