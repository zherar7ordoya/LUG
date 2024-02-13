using ABS;

using BEL;

using DAL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace MPP
{
    public class VehiculoMPP : IMapeadoXml<Vehiculo>
    {
        public List<Vehiculo> MapearDesdeXml(string archivo)
        {
            try
            {
                List<Vehiculo> vehiculosLista = new List<Vehiculo>();
                XElement vehiculosXelement = new ConexionXml().Leer(archivo);
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
            catch (XmlException ex) { throw new Exception(ex.Message); }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }


        public bool MapearHaciaXml(string archivo, List<Vehiculo> objetos)
        {
            try
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
                return new ConexionXml().Escribir(archivo, datos);
            }
            catch (XmlException ex) { throw new Exception(ex.Message); }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
