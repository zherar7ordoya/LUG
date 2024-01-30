using System;
using System.Text.RegularExpressions;

namespace Regex_C
{
    public static class Validaciones
    {
        // Validar números
        public static bool EsNumero(string texto)
        {
            return Regex.IsMatch(texto, @"^[0-9]+$");
        }

        // Validar texto
        public static bool EsTexto(string texto)
        {
            return Regex.IsMatch(texto, @"^[A-Za-z]+$");
        }

        // Validar alfanumérico
        public static bool EsAlfanumerico(string texto)
        {
            return Regex.IsMatch(texto, @"^[A-Za-z0-9]+$");
        }

        // Validar e-mail
        public static bool EsEmail(string texto)
        {
            return Regex.IsMatch(texto, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
        }

        // Validar fecha en formato dd/mm/yyyy
        public static bool EsFecha(string texto)
        {
            return Regex.IsMatch(texto, @"^(0[1-9]|1[0-9]|2[0-9]|3[0-1])/(0[1-9]|1[0-2])/\d{4}$");
        }


        // Validar nombre y apellido
        public static bool EsNombreApellido(string texto)
        {
            return Regex.IsMatch(texto, @"^[A-Z][a-z]+\s[A-Z][a-z]+$");
        }

        // Validar hexadecimal
        public static bool EsHexadecimal(string texto)
        {
            return Regex.IsMatch(texto, @"^[0-9A-Fa-f]+$");
        }

        // Validar URL básica con http o https
        public static bool EsUrl(string texto)
        {
            return Regex.IsMatch(texto, @"^(http|https)://[a-zA-Z0-9\-\.]+\.[a-zA-Z]{2,}(?:[^\s]*)?$");
        }

        // Reemplazar palabra en un texto
        public static string ReemplazarPalabra(string texto, string palabraOriginal, string palabraNueva)
        {
            // Escapar caracteres especiales de la palabra original
            string palabraEscapada = Regex.Escape(palabraOriginal);

            // Crear la expresión regular para buscar la palabra original
            string patron = $@"\b{palabraEscapada}\b";

            // Realizar el reemplazo
            return Regex.Replace(texto, patron, palabraNueva);
        }
    }
}
