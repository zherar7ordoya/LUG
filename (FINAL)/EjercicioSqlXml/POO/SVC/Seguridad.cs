using System;
using System.Text;

namespace SVC
{
    /// <summary>
    /// Codificación básica en Base64.
    /// No es considerada como una encriptación segura.
    /// </summary>
    public static class Seguridad
    {
        public static string Encriptar(string texto)
        {
            byte[] array = Encoding.Unicode.GetBytes(texto);
            string encriptado = Convert.ToBase64String(array);
            return encriptado;
        }

        // Nótese que el método no es referenciado en el código.
        public static string Desencriptar(this string texto)
        {
            byte[] array = Convert.FromBase64String(texto);
            string desencriptado = Encoding.Unicode.GetString(array);
            return desencriptado;
        }
    }
}
