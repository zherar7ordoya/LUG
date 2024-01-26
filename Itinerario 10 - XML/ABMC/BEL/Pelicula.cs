using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMC
{
    public class Pelicula : Entidad
    {
        public string Titulo { get; set; }
        public Produccion Produccion { get; set; }
        public List<Actor> Actores { get; set; }
    }
}
