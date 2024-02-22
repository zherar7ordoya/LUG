using ABS;

using BEL;

using DAL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

/* ************************************************************************** *\
La capa de mapeo tiene la responsabilidad exclusiva de facilitar la conversión
entre las estructuras de datos específicas de la DAL y los tipos de datos
nativos de C#. Su función principal es realizar el mapeado de datos, permitiendo
una comunicación efectiva entre la capa de acceso a datos (DAL) y las capas
superiores del sistema. Esta capa se encarga de convertir la información entre
las representaciones de datos utilizadas por la DAL y las estructuras de datos
de C#, asegurando así una transición fluida entre ambas sin agregar
responsabilidades adicionales. Al mantener un enfoque claro en el mapeo de
datos, esta capa sigue los principios SOLID, evitando la sobrecarga de
responsabilidades y contribuyendo a la claridad y mantenibilidad del sistema de
persistencia mixto (SQL y XML).
\* ************************************************************************** */

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
                    Vehiculo vehiculo;
                    string stringTipo = vehiculoXElement.Attribute("Tipo").Value;

                    if (Enum.TryParse<VehiculoTipo>(stringTipo, out VehiculoTipo tipo))
                    {
                        switch (tipo)
                        {
                            // Si es necesario, añade más casos para otros tipos
                            case VehiculoTipo.Automovil:
                                vehiculo = new Automovil();
                                break;
                            case VehiculoTipo.Camion:
                                vehiculo = new Camion();
                                break;
                            case VehiculoTipo.Camioneta:
                                vehiculo = new Camioneta();
                                break;
                            case VehiculoTipo.Suv:
                                vehiculo = new Suv();
                                break;
                            default:
                                throw new InvalidOperationException($"Tipo de vehículo desconocido: {tipo}");
                        }

                        vehiculo.Codigo = int.Parse(vehiculoXElement.Attribute("Codigo").Value);
                        vehiculo.Tipo = tipo;
                        vehiculo.Marca = vehiculoXElement.Element("Marca").Value;
                        vehiculo.Modelo = vehiculoXElement.Element("Modelo").Value;
                        vehiculo.Patente = vehiculoXElement.Element("Patente").Value;

                        vehiculosLista.Add(vehiculo);
                    }
                    else throw new InvalidOperationException($"Valor no válido para el atributo 'Tipo': {stringTipo}");
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
