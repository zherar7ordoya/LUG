using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;

/* ************************************************************************** *\
La capa de acceso a datos (DAL) tiene como responsabilidad principal gestionar
la ubicación y persistencia de los datos, determinando "dónde" se almacenan los
datos del sistema. Esto implica proporcionar mecanismos para interactuar con el
repositorio de datos correspondiente, ya sea un servidor SQL o archivos XML. La
DAL recibe la información estructurada desde la capa mapeadora y utiliza esta
información para realizar las operaciones de almacenamiento y recuperación en el
repositorio de datos específico, manteniendo así la separación de preocupaciones
en cuanto a la persistencia.
\* ************************************************************************** */

namespace DAL
{
    public class ConexionXml
    {
        public XElement Leer(string archivo)
        {
            try
            {
                return XElement.Load($"Data/{archivo}"); // Yo sé dónde está el archivo.
            }
            catch (FileNotFoundException ex) { throw new Exception(ex.Message); }
            catch (XmlException ex) { throw new Exception(ex.Message); }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public bool Escribir(string archivo, XElement datos)
        {
            try
            {
                datos.Save($"Data/{archivo}"); // Yo sé dónde está el archivo.
                return true;
            }
            catch (FileNotFoundException ex) { throw new Exception(ex.Message); }
            catch (XmlException ex) { throw new Exception(ex.Message); }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
