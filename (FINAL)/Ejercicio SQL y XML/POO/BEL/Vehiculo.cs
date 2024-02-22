/* ************************************************************************** *\
La capa de Entidades proporciona una representación orientada a objetos del
modelo de datos del negocio, facilitando la coherencia entre las clases que
representan entidades en el código de la aplicación y las estructuras de datos
utilizadas para persistir esas entidades
\* ************************************************************************** */

namespace BEL
{
    public abstract class Vehiculo : Entidad
    {
        public VehiculoTipo Tipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Patente { get; set; }

        public override string ToString()
        {
            return $"{Marca} {Modelo}";
        }
    }
}
