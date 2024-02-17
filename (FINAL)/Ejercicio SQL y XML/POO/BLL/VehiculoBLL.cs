using BEL;

namespace BLL
{
    // El método SinAsignar (que es parte de la lógica de negocio) fue movido a
    // la clase estática Tool puesto que esta clase, por ser abstracta, no puede
    // tener métodos no abstractos.
    public abstract partial class VehiculoBLL<T> where T : Vehiculo
    {
        public abstract decimal CalcularRenta(T vehiculo, int cantidadDias);
    }
}
