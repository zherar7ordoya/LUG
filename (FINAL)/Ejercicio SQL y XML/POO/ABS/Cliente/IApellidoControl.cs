using System;

namespace ABS
{
    // ¿Por qué esta interfaz fue necesaria? Cuando hice la capa controladora,
    // la misma no podía acceder a los controles de usuario de la capa de
    // presentación. Tampoco podía referenciarla (referencia circular). Por
    // tanto, la manera que la capa controladora conozca los controles "sui
    // generis" de la capa de presentación fue a través de interfaces.
    public interface IApellidoControl
    {
        string Apellido { get; set; }

        // ¿Y ésto, por qué? Los controles de usuario que hice tienen todos un
        // TextBox. El TextBox tiene un evento TextChanged. El TextBox, no el
        // control de usuario. Por tanto, para que el control de usuario tenga
        // un evento TextChanged, tuve que trasladarlo al control de usuario.
        event EventHandler TextChanged;
        bool Validar();
    }
}
