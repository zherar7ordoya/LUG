////////10////////20////////30////////40////////50////////60////////70////////80////////90///////100///////110///////120

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ABMC
{
    public class ORM : IGestor<Pelicula>
    {
        private readonly string archivo = "Peliculas.xml";
        private readonly Pelicula peliculaBEL = new Pelicula();
        private readonly DAL peliculaDAL;
        public ORM()
        {
            peliculaDAL = new DAL(archivo);
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

        public bool Actualizar(Pelicula objeto)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(Pelicula objeto)
        {
            throw new NotImplementedException();
        }


        /* El código proporcionado tiene en cuenta que la lista de actores puede
         * contener muchos, uno o ningún actor. La función Select de LINQ en la
         * línea correspondiente al mapeado de actores se encarga de manejar todos
         * estos casos. La expresión objeto.Actores.Select(...) se encarga de
         * proyectar cada elemento de la lista de actores a un nuevo XElement que
         * representa a un actor. Si la lista está vacía, no se generará ningún
         * XElement correspondiente a los actores. Si hay uno o más actores en la
         * lista, se generará un XElement por cada actor.
        */
        public bool Guardar(Pelicula objeto)
        {
            try
            {
                // Cargar el contenido existente del archivo XML
                XElement peliculas = peliculaDAL.Leer();

                // Crear el elemento Pelicula con atributo Id
                XElement pelicula = new XElement("Pelicula",
                    new XAttribute("Id", objeto.Codigo),
                    new XElement("Titulo", objeto.Titulo),

                    // Mapear la Produccion
                    new XElement("Produccion",
                        new XElement("Estreno", objeto.Produccion.AñoEstreno),
                        new XElement("Distribuidora", objeto.Produccion.Distribuidora)
                    ),

                    // Mapear la lista de Actores (ver comentario principal).
                    new XElement("Actores",
                        objeto.Actores.Select(actor =>
                            new XElement("Actor",
                                new XElement("Nombre", actor.Nombre),
                                new XElement("Personaje", actor.Personaje)
                            )
                        )
                    )
                );

                // Agregar el nuevo elemento Pelicula al contenido existente
                peliculas.Add(pelicula);

                // Guardar el contenido actualizado en el archivo XML
                peliculaDAL.Escribir(peliculas);

                return true;
            }
            catch (Exception ex) { throw new Exception($"Error al agregar la película: {ex.Message}"); }
        }


        public Pelicula ListarObjeto(Pelicula objeto)
        {
            throw new NotImplementedException();
        }


        /* OPERADOR "?" (OPERADOR DE NULABILIDAD)
         * Se utiliza para realizar una verificación de nulabilidad antes de acceder
         * a una propiedad o llamar a un método para evitar excepciones
         * NullReferenceException.
         * Ejemplo:
         *      string nombre = actorElement?.Element("Nombre")?.Value;
         * En este ejemplo, si actorElement o Element("Nombre") son nulos, la
         * expresión devolverá null en lugar de lanzar una excepción.
         * 
         * OPERADOR "??" (OPERADOR DE FUSIÓN DE NULOS)
         * Es una forma concisa de manejar casos en los que una variable puede ser
         * nula, proporcionando un valor predeterminado si es así.
         * Ejemplo:
         *      List<Actor> actores = 
         *          peliculaElement
         *          .Element("Actores")?
         *          .Elements("Actor")
         *          .Select(actorElement => new Actor
         *              {
         *                  Nombre = (string)actorElement.Element("Nombre"),
         *                  Personaje = (string)actorElement.Element("Personaje")
         *              })
         *          .ToList() ?? new List<Actor>();
         * En este ejemplo, si peliculaElement.Element("Actores") es nulo, se
         * asignará una nueva lista vacía en lugar de null.
         */
        public List<Pelicula> ListarTodo()
        {
            try
            {
                // Leer el contenido del archivo XML
                XElement peliculas = peliculaDAL.Leer();

                // Utilizar LINQ to XML para mapear los elementos Pelicula a objetos Pelicula
                List<Pelicula> lista =
                    peliculas
                    .Elements("Pelicula")
                    .Select(pelicula => new Pelicula
                    {
                        Codigo = (int)pelicula.Attribute("Id"),
                        Titulo = (string)pelicula.Element("Titulo"),

                        // 1 a 1
                        Produccion = new Produccion
                        {
                            AñoEstreno = (int)pelicula.Element("Produccion").Element("Estreno"),
                            Distribuidora = (string)pelicula.Element("Produccion").Element("Distribuidora")
                        },

                        // 1 a M
                        Actores = pelicula.Element("Actores")?.Elements("Actor")
                            .Select(actor => new Actor
                            {
                                Nombre = (string)actor.Element("Nombre"),
                                Personaje = (string)actor.Element("Personaje")
                            }).ToList() ?? new List<Actor>() // Lista anidada (actores)

                    }).ToList(); // Lista anidante (películas)

                return lista;
            }
            catch (Exception ex) { throw new Exception($"Error al listar las películas: {ex.Message}"); }
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
