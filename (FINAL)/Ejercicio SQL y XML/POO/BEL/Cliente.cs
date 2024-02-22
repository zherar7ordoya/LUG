using System;
using System.Collections.Generic;

/* ************************************************************************** *\
La capa de Entidades proporciona una representación orientada a objetos del
modelo de datos del negocio, facilitando la coherencia entre las clases que
representan entidades en el código de la aplicación y las estructuras de datos
utilizadas para persistir esas entidades
\* ************************************************************************** */

namespace BEL
{
    public class Cliente : Entidad
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Email { get; set; }
        public List<Vehiculo> VehiculosRentados { get; set; }

        public override string ToString()
        {
            return $"{Nombre} {Apellido}";
        }
    }
}
