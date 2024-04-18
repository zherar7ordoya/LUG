using ABS;

namespace BEL
{
    public class Automovil : Vehiculo
    {
        // ¿Justifican estos constructores el uso de la herencia?
        public Automovil()
        {
            Tipo = VehiculoTipo.Automovil;
        }
    }
}
