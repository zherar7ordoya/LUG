using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ListaRepudioLib
{
    public class ListaRepudio
    {
        public List<string> Cadenas { get; set; } = new List<string>();

        /// <summary>
        /// Operaciones efectuadas:
        /// 1. Cargar la lista desde el archivo
        /// 2. Filtrar las cadenas para que sean alfanuméricas
        /// 3. Eliminar duplicados de la lista
        /// 4. Eliminar cadenas que no cumplan con la longitud requerida(8 o 14)
        /// 5. Ordenar la lista resultante alfabéticamente.
        /// </summary>
        /// <param name="nombreArchivo"></param>
        /// <returns></returns>
        /// <exception cref="ListaRepudioException.CargarListaException"></exception>
        public bool CargarLista(string nombreArchivo)
        {
            try
            {
                Cadenas = File.ReadAllLines(nombreArchivo)
                              // Filtrar solo cadenas alfanuméricas
                              .Where(EsAlfanumerica)
                              // Eliminar duplicados
                              .Distinct()
                              // Eliminar largos inválidos
                              .Where(s => s.Length == 8 || s.Length == 14)
                              // Ordenar alfabéticamente
                              .OrderBy(s => s)
                              .ToList();

                return true;
            }
            catch (Exception ex)
            {
                throw new ListaRepudioException.CargarListaException($"Error al cargar la lista: {ex.Message}");
            }
        }

        /// <summary>
        /// Realiza una búsqueda binaria en la lista de cadenas.
        /// </summary>
        /// <param name="busqueda"></param>
        /// <param name="posicion"></param>
        /// <returns></returns>
        /// <exception cref="ListaRepudioException.BuscarException"></exception>
        public bool Buscar(string busqueda, out int posicion)
        {
            try
            {
                posicion = Cadenas.BinarySearch(busqueda); // Búsqueda binaria
                return posicion >= 0;
            }
            catch (Exception ex)
            {
                throw new ListaRepudioException.BuscarException($"Error al buscar en la lista: {ex.Message}");
            }
        }

        // Método para validar si una cadena es alfanumérica
        private bool EsAlfanumerica(string cadena)
        {
            try
            {
                return cadena.All(c => char.IsLetterOrDigit(c));
            }
            catch (Exception ex)
            {
                throw new ListaRepudioException.EsAlfanumericaException($"Error al validar la cadena: {ex.Message}");
            }
        }
    }

}

