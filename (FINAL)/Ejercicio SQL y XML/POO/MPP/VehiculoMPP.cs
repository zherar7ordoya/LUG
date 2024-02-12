using ABS;

using BEL;

using DAL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace MPP
{
    public class VehiculoMPP : IMapeado<Vehiculo>
    {
        readonly AccesoDatosXmlArchivo accesoDatosXmlArchivo= new AccesoDatosXmlArchivo();


        public List<Vehiculo> MapearDesdeXmlArchivo(string archivo)
        {
            List<Vehiculo> vehiculosLista = new List<Vehiculo>();
            XElement vehiculosXelement = accesoDatosXmlArchivo.Leer(archivo);
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

        
        public bool MapearHaciaXmlArchivo(string archivo, List<Vehiculo> objetos)
        {
            XElement datos = new XElement("Vehiculos",
                from vehiculo in objetos
                select new XElement("Vehiculo",
                    new XAttribute("Codigo", vehiculo.Codigo),
                    new XAttribute("Tipo", vehiculo.Tipo),
                    new XElement("Marca", vehiculo.Marca),
                    new XElement("Modelo", vehiculo.Modelo),
                    new XElement("Patente", vehiculo.Patente)
                )
            );
            return accesoDatosXmlArchivo.Escribir(archivo, datos);
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
        public List<Vehiculo> MapearDesdeSqlServer(string consulta) => throw new NotImplementedException("Vehiculo usa XML Archivo");
        public bool MapearHaciaSqlServer(string consulta, Vehiculo objeto) => throw new NotImplementedException("Vehiculo usa XML Archivo");
    }
}
