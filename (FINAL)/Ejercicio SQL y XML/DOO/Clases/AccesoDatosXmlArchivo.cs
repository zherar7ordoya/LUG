using System;
using System.Xml.Linq;

namespace ABMC
{
    public class DAL
    {
        private readonly string archivo;
        public DAL(string archivo)
        {
            this.archivo = archivo;
        }

        public XElement Leer()
        {
            try { return XElement.Load(archivo); }
            catch (Exception ex) { throw new Exception($"Error al leer el archivo: {ex.Message}"); }
        }

        public bool Escribir(XElement pXElement)
        {
            try
            {
                pXElement.Save(archivo);
                return true;
            }
            catch (Exception ex) { throw new Exception($"Error al escribir el archivo: {ex.Message}"); }
        }
    }
}
