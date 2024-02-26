using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;


namespace DAL
{
    /**
     * ¿Por qué XElement y no XmlDocument?
     * Es una situación similar a la elección entre DataTable y DataSet.
     * XElement representa un elemento XML individual. Es adecuado cuando estás
     * trabajando principalmente con un solo elemento dentro del documento XML.
     * XDocument representa un documento XML completo. Útil cuando se necesita
     * manipular la estructura completa del documento, incluyendo la declaración
     * XML, los elementos raíz y posiblemente varios niveles de anidamiento.
     */
    public class ConexionXml
    {
        private readonly string ruta;
        public ConexionXml(string archivo)
        {
            ruta = $"Data/{archivo}";
        }

        //*--------------------------------------------------------------------*

        public XElement Leer()
        {
            try
            {
                return XElement.Load(ruta); //*--=> Yo sé dónde está el archivo.
            }
            catch (FileNotFoundException ex) { throw new Exception(ex.Message); }
            catch (XmlException ex) { throw new Exception(ex.Message); }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public bool Escribir(XElement datos)
        {
            try
            {
                datos.Save(ruta);           //*--=> Yo sé dónde está el archivo.
                return true;
            }
            catch (FileNotFoundException ex) { throw new Exception(ex.Message); }
            catch (XmlException ex) { throw new Exception(ex.Message); }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
