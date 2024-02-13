using System;
using System.Xml.Linq;

namespace DAL
{
    public class ConexionXml
    {
        public XElement Leer(string archivo)
        {
            try
            {
                return XElement.Load(archivo);
            }
            catch (Exception ex)
            {
                string mensaje = $"Error: {ex.Message}";
                throw new Exception(mensaje, ex);
            }
        }

        public bool Escribir(string archivo, XElement datos)
        {
            try
            {
                datos.Save(archivo);
                return true;
            }
            catch (Exception ex)
            {
                string mensaje = $"Error: {ex.Message}";
                throw new Exception(mensaje, ex);
            }
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
