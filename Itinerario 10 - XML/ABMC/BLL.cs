using System.Collections.Generic;
using System.Linq;

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

        //|||||||||||||||||||||||||||||||||||||||||| MÉTODOS PROPIOS DE LA CLASE

        public List<Pelicula> ConsultarPorTitulo(string titulo)
        {
            List<Pelicula> peliculas = peliculaORM.ListarTodo();

            List<Pelicula> resultado = 
                peliculas
                .Where(pelicula => pelicula.Titulo.Contains(titulo))
                .ToList();

            return resultado;
        }


        public List<Pelicula> ConsultarPorAño(int año)
        {
            List<Pelicula> peliculas = peliculaORM.ListarTodo();

            List<Pelicula> resultado = 
                peliculas
                .Where(pelicula => pelicula.Produccion != null && pelicula.Produccion.AñoEstreno == año)
                .ToList();

            return resultado;
        }

        public List<Pelicula> ConsultarPorActor(string nombre)
        {
            List<Pelicula> peliculas = peliculaORM.ListarTodo();

            List<Pelicula> resultado = 
                peliculas
                .Where(pelicula => pelicula.Actores != null && pelicula.Actores.Any(actor => actor.Nombre.Contains(nombre)))
                .ToList();

            return resultado;
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
