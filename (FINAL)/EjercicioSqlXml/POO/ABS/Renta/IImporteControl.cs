using System;

namespace ABS
{
    // Ver notas en IApellidoControl (el traslado aplica a Enabled y Update)
    public interface IImporteControl
    {
        string Importe { get; set; }
        bool Enabled { get; set; }
        event EventHandler TextChanged;
        bool Validar();
        void Update();
    }
}
