using System;
using System.IO;
using System.Xml;
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
            catch (FileNotFoundException ex) { throw new Exception(ex.Message); }
            catch (XmlException ex) { throw new Exception(ex.Message); }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public bool Escribir(string archivo, XElement datos)
        {
            try
            {
                datos.Save(archivo);
                return true;
            }
            catch (FileNotFoundException ex) { throw new Exception(ex.Message); }
            catch (XmlException ex) { throw new Exception(ex.Message); }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
