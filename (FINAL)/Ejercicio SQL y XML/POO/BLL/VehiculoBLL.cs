using BEL;

namespace BLL
{
    public abstract partial class VehiculoBLL<T> where T : Vehiculo
    {
        public abstract decimal CalcularRenta(T vehiculo, int cantidadDias);
    }
}
