using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVC
{
    /// <summary>
    /// Codificación básica en Base64.
    /// No es considerada como una encriptación segura.
    /// </summary>
    public static class Seguridad
    {
        public static string Encriptar(string pCadena)
        {
            byte[] encriptado = Encoding.Unicode.GetBytes(pCadena);
            string resultado = Convert.ToBase64String(encriptado);
            return resultado;
        }

        public static string Desencriptar(this string pCadena)
        {
            byte[] desencriptado = Convert.FromBase64String(pCadena);
            string resultado = Encoding.Unicode.GetString(desencriptado);
            return resultado;
        }
    }
}
