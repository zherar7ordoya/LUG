using System.Collections.Generic;

namespace BE
{
    public class BEEquipo : Entidad
    {
        public string Nombre { get; set; }
        public string Color { get; set; }

        // Relación 1 a 1
        public BETecnico Tecnico { get; set; }

        // Relación 1 a M
        public List<BEJugador> ListaJugadores { get; set; }
    }
}
