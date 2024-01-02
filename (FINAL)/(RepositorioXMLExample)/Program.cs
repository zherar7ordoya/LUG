using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace ConsoleApp
{
    public interface IID
    {
        int Id { get; set; }
    }

    public interface IABMC<T> where T : IID
    {
        T ObtenerPorId(int id);
        List<T> ObtenerTodos();
        void Agregar(T entidad);
        void Actualizar(T entidad);
        void Eliminar(int id);
    }

    public class Libro : IID
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
    }

    public class RepositorioLibrosXML : IABMC<Libro>
    {
        private string xmlFilePath = "libros.xml";

        public Libro ObtenerPorId(int id)
        {
            XDocument xDocument = XDocument.Load(xmlFilePath);

            var libroElement = xDocument.Descendants("Libro")
                .FirstOrDefault(libro => libro.Element("Id").Value == id.ToString());

            if (libroElement == null)
                return null;

            return new Libro
            {
                Id = Convert.ToInt32(libroElement.Element("Id").Value),
                Titulo = libroElement.Element("Titulo").Value,
                Autor = libroElement.Element("Autor").Value
            };
        }

        public List<Libro> ObtenerTodos()
        {
            XDocument xDocument = XDocument.Load(xmlFilePath);

            return xDocument.Descendants("Libro").Select(libroElement => new Libro
            {
                Id = Convert.ToInt32(libroElement.Element("Id").Value),
                Titulo = libroElement.Element("Titulo").Value,
                Autor = libroElement.Element("Autor").Value
            }).ToList();
        }

        public void Agregar(Libro libro)
        {
            XDocument xDocument;
            if (File.Exists(xmlFilePath))
                xDocument = XDocument.Load(xmlFilePath);
            else
            {
                xDocument = new XDocument(new XElement("Biblioteca"));
            }

            XElement bibliotecaNode = xDocument.Element("Biblioteca");

            XElement libroElement = new XElement("Libro",
                new XElement("Id", libro.Id),
                new XElement("Titulo", libro.Titulo),
                new XElement("Autor", libro.Autor));

            bibliotecaNode.Add(libroElement);

            xDocument.Save(xmlFilePath);
        }

        public void Actualizar(Libro libro)
        {
            XDocument xDocument = XDocument.Load(xmlFilePath);

            var libroElement = xDocument.Descendants("Libro")
                .FirstOrDefault(libroElem => libroElem.Element("Id").Value == libro.Id.ToString());

            if (libroElement != null)
            {
                libroElement.Element("Titulo").Value = libro.Titulo;
                libroElement.Element("Autor").Value = libro.Autor;
                xDocument.Save(xmlFilePath);
            }
        }

        public void Eliminar(int id)
        {
            XDocument xDocument = XDocument.Load(xmlFilePath);

            var libroElement = xDocument.Descendants("Libro")
                .FirstOrDefault(libro => libro.Element("Id").Value == id.ToString());

            if (libroElement != null)
            {
                libroElement.Remove();
                xDocument.Save(xmlFilePath);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IABMC<Libro> repositorio = new RepositorioLibrosXML();

            // Agregar un libro
            Libro nuevoLibro = new Libro { Id = 3, Titulo = "El Principito", Autor = "Antoine de Saint-Exupéry" };
            repositorio.Agregar(nuevoLibro);

            // Obtener todos los libros
            List<Libro> libros = repositorio.ObtenerTodos();
            Console.WriteLine("Libros existentes:");
            foreach (var libro in libros)
            {
                Console.WriteLine($"ID: {libro.Id}, Título: {libro.Titulo}, Autor: {libro.Autor}");
            }

            // Modificar un libro
            Libro libroModificado = new Libro { Id = 1, Titulo = "El Principito (Edición Nueva)", Autor = "Antoine de Saint-Exupéry" };
            repositorio.Actualizar(libroModificado);

            // Consultar un libro por ID
            Libro libroConsultado = repositorio.ObtenerPorId(1);
            if (libroConsultado != null)
            {
                Console.WriteLine($"Libro consultado: ID: {libroConsultado.Id}, Título: {libroConsultado.Titulo}, Autor: {libroConsultado.Autor}");
            }
            else
            {
                Console.WriteLine("Libro no encontrado.");
            }

            // Eliminar un libro
            repositorio.Eliminar(1);

            Console.ReadLine();
        }
    }
}
