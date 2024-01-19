/** Esto es interesante: la clase Jugador (dividida en dos clases, una que agrupa
 * las propiedades y otra que agrupa los métodos) tiene una clase abstracta para
 * cada capa: JugadorBEL y JugadorBLL. Así que, la herencia, se hace en dos niveles.
 */

using BE;

namespace Negocio_BLL
{
    /// <summary>
    /// Clase abstracta de la que heredan las clases BLLPrincipiante y BLLProfesional.
    /// Por ese motivo, no implementa la interfaz IGestor (sería engorroso).
    /// </summary>
    public abstract class BLLJugador
    {
        public abstract int ObtenerPuntaje(BEJugador oBEJug);
        public virtual bool Guardar_JugadorXEquipo(BEJugador oBEJugador, BEEquipo oBEEquipo)
        {
            return true;
        }
    }
}
