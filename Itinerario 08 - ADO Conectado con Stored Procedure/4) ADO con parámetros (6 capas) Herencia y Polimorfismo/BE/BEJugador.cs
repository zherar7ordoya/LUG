/** Esto es interesante: la clase Jugador (dividida en dos clases, una que agrupa
 * las propiedades y otra que agrupa los métodos) tiene una clase abstracta para
 * cada capa: JugadorBEL y JugadorBLL. Así que, la herencia, se hace en dos niveles.
 */

namespace BE
{
    /// <summary>
    /// Clase abstracta de la que heredan las clases BEPrincipiante y BEProfesional.
    /// </summary>
    public abstract class BEJugador : Entidad
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public int CantidadAmarillas { get; set; }
        public int CantidadRojas { get; set; }
        public int GolesRealizados { get; set; }
    }
}
