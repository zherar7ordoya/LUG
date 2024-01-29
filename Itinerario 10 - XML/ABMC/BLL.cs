using System.Collections.Generic;

namespace ABMC
{
    public class BLL : IGestor<Pelicula>
    {
        private readonly Pelicula peliculaBEL = new Pelicula();
        private readonly ORM peliculaORM = new ORM();

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

        public bool Actualizar(Pelicula objeto)
        {
            return peliculaORM.Actualizar(objeto);
        }

        public bool Eliminar(Pelicula objeto)
        {
            return peliculaORM.Eliminar(objeto);
        }

        public bool Guardar(Pelicula objeto)
        {
            return peliculaORM.Guardar(objeto);
        }

        public Pelicula ListarObjeto(Pelicula objeto)
        {
            return peliculaORM.ListarObjeto(objeto);
        }

        public List<Pelicula> ListarTodo()
        {
            return peliculaORM.ListarTodo();
        }
    }
}
