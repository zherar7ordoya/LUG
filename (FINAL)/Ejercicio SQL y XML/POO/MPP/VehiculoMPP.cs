using ABS;
using BEL;
using DAL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MPP
{
    public class VehiculoMPP : IMapeado<Vehiculo>
    {
        AccesoDatosXmlArchivo accesoDatosXmlArchivo = new AccesoDatosXmlArchivo("Cliente.xml");


        public List<Vehiculo> MapearDesdeXmlArchivo()
        {
            List<Vehiculo> vehiculosLista = new List<Vehiculo>();
            XElement vehiculosXelement = accesoDatosXmlArchivo.Leer();
            foreach (XElement vehiculoXElement in vehiculosXelement.Elements("Vehiculo"))
            {
                Vehiculo vehiculo = new Vehiculo
                {
                    Codigo = int.Parse(vehiculoXElement.Attribute("Codigo").Value),
                    Tipo = vehiculoXElement.Attribute("Tipo").Value,
                    Marca = vehiculoXElement.Element("Marca").Value,
                    Modelo = vehiculoXElement.Element("Modelo").Value,
                    Patente = vehiculoXElement.Element("Patente").Value
                };
                vehiculosLista.Add(vehiculo);
            }
            return vehiculosLista;
        }

        
        public bool MapearHaciaXmlArchivo(List<Vehiculo> entidades)
        {
            XElement datos = new XElement("Vehiculos",
                from vehiculo in entidades
                select new XElement("Vehiculo",
                    new XAttribute("Codigo", vehiculo.Codigo),
                    new XAttribute("Tipo", vehiculo.Tipo),
                    new XElement("Marca", vehiculo.Marca),
                    new XElement("Modelo", vehiculo.Modelo),
                    new XElement("Patente", vehiculo.Patente)
                )
            );
            return accesoDatosXmlArchivo.Escribir(datos);
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
        public bool MapearHaciaSqlServer(List<Vehiculo> entidades) => throw new NotImplementedException("Vehiculo usa XML Archivo");
        public List<Vehiculo> MapearDesdeSqlServer() => throw new NotImplementedException("Vehiculo usa XML Archivo");
    }
}
