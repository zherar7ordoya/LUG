using System;

namespace ABS
{
    public interface IImporteControl
    {
        string Importe { get; set; }
        bool Enabled { get; set; } // Añade la propiedad Enabled
        event EventHandler TextChanged;
        bool Validar();
        void Update(); // Agrega el método Update
    }
}
