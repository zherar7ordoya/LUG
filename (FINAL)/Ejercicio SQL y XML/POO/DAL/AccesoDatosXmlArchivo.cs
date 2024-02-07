using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL
{
    public class AccesoDatosXmlArchivo
    {
        private readonly string archivo;

        public AccesoDatosXmlArchivo(string archivo)
        {
            this.archivo = archivo;
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||| MÉTODOS DE CLASE

        public XElement Leer()
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

        public bool Escribir(XElement datos)
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
