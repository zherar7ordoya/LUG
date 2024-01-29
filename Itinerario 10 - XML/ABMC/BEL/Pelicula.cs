using System.Collections.Generic;

namespace ABMC
{
    public class Pelicula : Entidad
    {
        public string Titulo { get; set; }
        public Produccion Produccion { get; set; }
        public List<Actor> Actores { get; set; }
    }
}
