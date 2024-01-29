////////10////////20////////30////////40////////50////////60////////70////////80////////90///////100///////110///////120

using System;
using System.Collections.Generic;
using System.Linq;
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
            try
            {
                // Leer el contenido del archivo XML
                XElement peliculas = peliculaDAL.Leer();

                // Buscar el elemento de la película que se va a actualizar
                XElement pelicula = peliculas.Elements("Pelicula")
                    .FirstOrDefault(x => (int)x.Attribute("Id") == objeto.Codigo);

                // Si encontramos la película, la actualizamos en lugar de agregar una nueva
                if (pelicula != null)
                {
                    // Actualizar los elementos relevantes con los nuevos valores
                    pelicula.Element("Titulo").Value = objeto.Titulo;
                    pelicula.Element("Produccion").Element("Estreno").Value = objeto.Produccion.AñoEstreno.ToString();
                    pelicula.Element("Produccion").Element("Distribuidora").Value = objeto.Produccion.Distribuidora;

                    // *MANERA SIMPLE Y EFICIENTE DE ACTUALIZAR LISTAS ANIDADAS*
                    // Eliminar actores existentes para actualizarlos
                    pelicula.Element("Actores").RemoveAll();

                    // Agregar los nuevos actores
                    pelicula.Element("Actores").Add(
                        objeto.Actores.Select(actor =>
                            new XElement("Actor",
                                new XElement("Nombre", actor.Nombre),
                                new XElement("Personaje", actor.Personaje)
                            )
                        )
                    );

                    // Guardar el contenido actualizado en el archivo XML
                    peliculaDAL.Escribir(peliculas);

                    return true;
                }
                else { return false; }
            }
            catch (Exception ex) { throw new Exception($"Error al actualizar la película: {ex.Message}"); }
        }


        public bool Eliminar(Pelicula objeto)
        {
            try
            {
                XElement peliculas = peliculaDAL.Leer();

                // Buscar el elemento de la película que se va a eliminar
                XElement pelicula =
                    peliculas
                    .Elements("Pelicula")
                    .FirstOrDefault(x => (int)x.Attribute("Id") == objeto.Codigo);

                if (pelicula != null)
                {
                    pelicula.Remove();
                    return peliculaDAL.Escribir(peliculas);
                }
                else { return false; }
            }
            catch (Exception ex) { throw new Exception($"Error al eliminar la película: {ex.Message}"); }
        }

        private int NuevoId(XElement peliculas)
        {
            // Obtener el valor máximo actual de los IDs
            int max = peliculas.Elements("Pelicula").Attributes("Id")
                .Select(x => (int)x)
                .DefaultIfEmpty(0) // En caso de que no haya elementos
                .Max();

            // Incrementar el valor máximo en 1 para obtener el nuevo ID
            return max + 1;
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

                // Asignar el nuevo ID al objeto Pelicula
                objeto.Codigo = NuevoId(peliculas);

                // Crear el elemento Pelicula con el nuevo ID
                XElement pelicula = new XElement("Pelicula",
                    new XAttribute("Id", objeto.Codigo),
                    new XElement("Titulo", objeto.Titulo),

                    // Mapear la Produccion
                    new XElement("Produccion",
                        new XElement("Estreno", objeto.Produccion.AñoEstreno),
                        new XElement("Distribuidora", objeto.Produccion.Distribuidora)
                    ),

                    // Mapear la lista de Actores
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
            catch (Exception ex)
            {
                throw new Exception($"Error al agregar la película: {ex.Message}");
            }
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
