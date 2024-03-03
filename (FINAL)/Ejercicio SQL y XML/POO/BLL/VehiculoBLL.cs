using BEL;


namespace BLL
{
    // NOTA:
    // En este caso particular, la restricción <T> where T : Vehiculo podría
    // considerarse opcional ya que las clases derivadas siempre son de tipo
    // Vehiculo y, por lo tanto, el polimorfismo se mantiene sin ella.
    // Sin embargo, la restricción se agrega para proporcionar una capa
    // adicional de seguridad y documentación (aunque no esto seguro de esto).
    public abstract partial class VehiculoBLL<T> where T : Vehiculo
    {
        public abstract decimal CalcularRenta(T vehiculo, int cantidadDias);
    }
}
