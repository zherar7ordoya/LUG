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
    // Ver nota en archivo XML.
    public class VehiculoMPP : IMapeadoXml<Vehiculo>
    {
        private readonly ConexionXml conexion;
        public VehiculoMPP(string archivo) => conexion = new ConexionXml(archivo);

        //*--------------------------------------------------------------------*

        public List<Vehiculo> MapearDesdeXml()
        {
            try
            {
                List<Vehiculo> vehiculosLista = new List<Vehiculo>();
                XElement vehiculosXelement = conexion.Leer();

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


        public bool MapearHaciaXml(List<Vehiculo> objetos)
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
                return conexion.Escribir(datos);
            }
            catch (XmlException ex) { throw new Exception(ex.Message); }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
