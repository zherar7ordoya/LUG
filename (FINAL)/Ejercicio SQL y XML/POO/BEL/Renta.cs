/* ************************************************************************** *\
La capa de Entidades proporciona una representación orientada a objetos del
modelo de datos del negocio, facilitando la coherencia entre las clases que
representan entidades en el código de la aplicación y las estructuras de datos
utilizadas para persistir esas entidades
\* ************************************************************************** */

namespace BEL
{
    public class Renta : Entidad
    {
        public Cliente Cliente { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public int DiasRentados { get; set; }
        public decimal Importe { get; set; }

        public override string ToString()
        {
            return $"Cliente: {Cliente} - Vehículo: {Vehiculo} - Días rentados: {DiasRentados} - Importe: {Importe}";
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
