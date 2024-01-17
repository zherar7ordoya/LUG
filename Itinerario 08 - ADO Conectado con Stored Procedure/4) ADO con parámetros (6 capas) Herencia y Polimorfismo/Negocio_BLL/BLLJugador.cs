using BE;

namespace Negocio_BLL
{
    /// <summary>
    /// Clase abstracta que heredan las clases BLLPrincipiante y BLLProfesional.
    /// Por ese motivo, no implementa la interfaz IGestor.
    /// </summary>
    public abstract class BLLJugador
    {
            public abstract int ObtenerPuntaje(BEJugador oBEJug);
    }
}
