using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMC
{
    public class Pelicula : Entidad
    {
        string Titulo { get; set; }
        Lanzamiento Lanzamiento { get; set; }
        List<Actor> Actores { get; set; }
    }
}
