using System.Xml.Linq;
using System;
using LUG.Parametros;
using LUG.BE;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace LUG.MPP
{
    public class MPPCliente
    {                
        public MPPCliente() { }        

        public bool Guardar(BECliente bECliente)
        {
            try {                
                if (bECliente.Codigo == 0) {                    
                    if (!File.Exists(CNombreXML.XMLCliente)) {
                        var xCliente = new XElement("clientes",
                            new XElement("cliente",
                            new XAttribute("codigo", DevolverCodigo().ToString().Trim()),
                            new XElement("nombre", bECliente.Nombre.Trim()),
                            new XElement("apellido", bECliente.Apellido.Trim()),
                            new XElement("dni", bECliente.DNI.ToString().Trim()),
                            new XElement("mail", bECliente.Mail.Trim())));
                        xCliente.Save(CNombreXML.XMLCliente);
                    } else {
                        var xml = XDocument.Load(CNombreXML.XMLCliente);
                        xml.Element("clientes").Add(new XElement("cliente",
                                                new XAttribute("codigo", DevolverCodigo().ToString().Trim()),
                                                new XElement("nombre", bECliente.Nombre.Trim()),
                                                new XElement("apellido", bECliente.Apellido.Trim()),
                                                new XElement("dni", bECliente.DNI.ToString().Trim()),
                                                new XElement("mail", bECliente.Mail.Trim())));
                        xml.Save(CNombreXML.XMLCliente);
                    }                                 
                } else {
                    XDocument doc = XDocument.Load(CNombreXML.XMLCliente);
                    var clienteBuscado = ObtenerElementsXml(bECliente, doc);
                    foreach (var element in clienteBuscado) {
                        element.SetElementValue("nombre", bECliente.Nombre);
                        element.SetElementValue("apellido", bECliente.Apellido);
                        element.SetElementValue("dni", bECliente.DNI);
                        element.SetElementValue("mail", bECliente.Mail);
                    }
                    doc.Save(CNombreXML.XMLCliente);                    
                }                
                return true;
            } catch (Exception ex) {
                throw ex;
            }
        }

        public List<XElement> ObtenerElementsXml(BECliente beCliente, XDocument doc)
        {
            try {
                return (from cliente in doc.Descendants("cliente")
                        where long.Parse(cliente.Attribute("codigo").Value) == beCliente.Codigo
                 select cliente).ToList();
            } catch (Exception ex) {
                throw ex;
            }
        }

        public long DevolverCodigo()
        {
            try {
                return ObtenerTodos().Count > 0 ? ObtenerTodos().Sum(a => a.Codigo) + 1 : 1;
            } catch (Exception ex) {
                throw ex;
            }
        }

        public BECliente BuscarPor(Func<BECliente, bool> func)
        {
            try {
                var clientes = ObtenerTodos();
                return clientes.Where(func).FirstOrDefault();
            } catch (Exception ex) {
                throw ex;
            }
        }

        public BECliente Obtener(BECliente clnt)
        {
            try {
                return (from cliente in XDocument.Load(CNombreXML.XMLCliente).Descendants("cliente")
                        where long.Parse(cliente.Attribute("codigo").Value) == clnt.Codigo
                 select new BECliente {
                     Apellido = Convert.ToString(cliente.Element("apellido").Value).Trim(),
                     Codigo = Convert.ToInt64(cliente.Attribute("codigo").Value.ToString()),
                     DNI =  Convert.ToInt64(cliente.Element("dni").Value.ToString()),
                     Mail = Convert.ToString(cliente.Element("mail").Value).Trim(),
                     Nombre = Convert.ToString(cliente.Element("nombre").Value).Trim(),
                 }).FirstOrDefault();
            } catch (Exception ex) {
                throw ex;
            }
        }

        public List<BECliente> ObtenerTodos()
        {
            try {
                var clientes = new List<BECliente>();
                if (File.Exists(CNombreXML.XMLCliente)) {                    
                    var consulta = (from cliente in XDocument.Load(CNombreXML.XMLCliente).Descendants("cliente")
                            select new BECliente
                            {
                                Apellido = Convert.ToString(cliente.Element("apellido").Value).Trim(),
                                Codigo = Convert.ToInt64(cliente.Attribute("codigo").Value.ToString()),
                                DNI = Convert.ToInt64(cliente.Element("dni").Value.ToString()),
                                Mail = Convert.ToString(cliente.Element("mail").Value).Trim(),
                                Nombre = Convert.ToString(cliente.Element("nombre").Value).Trim(),
                            }).ToList();
                    clientes = consulta.ToList<BECliente>();
                } 
                return clientes;
            } catch (Exception ex) {
                throw ex;
            }
        }

        public bool Eliminar(BECliente bECliente)
        {
            try {
                XDocument doc = XDocument.Load(CNombreXML.XMLCliente);
                var elements = ObtenerElementsXml(bECliente, doc);
                elements.Remove();
                doc.Save(CNombreXML.XMLCliente);
                var streamings = ObtenerTodos();
                if (streamings.Count == 0) {
                    File.Delete(CNombreXML.XMLCliente);
                }
                return true;
            } catch (Exception ex) {
                throw ex;
            }
        }


        public bool Contratar(BEClienteAsociadoStreaming bEClienteAsociadoStreaming)
        {
            try {
                if (!File.Exists(CNombreXML.XMLContrataciones)) {
                    var contratacionXml = new XElement("contrataciones",                        
                        new XElement("contratacion",
                        new XAttribute("streamingLive", bEClienteAsociadoStreaming.Streaming is BEStreamingLive),
                        new XElement("codigoCliente", bEClienteAsociadoStreaming.Cliente.Codigo.ToString().Trim()),                        
                        new XElement("codigoStreaming", bEClienteAsociadoStreaming.Streaming.Codigo.ToString().Trim()),
                        new XElement("total", bEClienteAsociadoStreaming.Total.ToString().Trim())));
                    contratacionXml.Save(CNombreXML.XMLContrataciones);
                } else {
                    var xml = XDocument.Load(CNombreXML.XMLContrataciones);
                    xml.Element("contrataciones").Add(new XElement("contratacion",
                        new XAttribute("streamingLive", bEClienteAsociadoStreaming.Streaming is BEStreamingLive),
                        new XElement("codigoCliente", bEClienteAsociadoStreaming.Cliente.Codigo.ToString().Trim()),
                        new XElement("codigoStreaming", bEClienteAsociadoStreaming.Streaming.Codigo.ToString().Trim()),
                        new XElement("total", bEClienteAsociadoStreaming.Total.ToString().Trim())));
                    xml.Save(CNombreXML.XMLContrataciones);
                }
                return true;
            } catch (Exception ex) {
                throw ex;
            }           
        }

        public bool CancelarContrato(BEClienteAsociadoStreaming contratacion)
        {
            try {
                XDocument doc = XDocument.Load(CNombreXML.XMLContrataciones);
                var contratacionesElements = ObtenerElementsXmlContrataciones(contratacion, doc);
                contratacionesElements.Remove();
                doc.Save(CNombreXML.XMLContrataciones);                
                return true;
            } catch (Exception ex) {
                throw ex;
            }
        }

        public List<XElement> ObtenerElementsXmlContrataciones(BEClienteAsociadoStreaming contratacion, XDocument doc)
        {
            try {
                return (from contrat in doc.Descendants("contratacion")
                 where long.Parse(contrat.Element("codigoCliente").Value) == contratacion.Cliente.Codigo
                     && ( long.Parse(contrat.Element("codigoStreaming").Value) == contratacion.Streaming.Codigo)                         
                 select contrat).ToList();
            } catch (Exception ex) {
                throw ex;
            }
        }
        
        public List<BEClienteAsociadoStreaming> ObtenerContrataciones(BECliente cliente)
        {
            try {                
                var contrataciones = new List<BEClienteAsociadoStreaming>();                                
                if (File.Exists(CNombreXML.XMLContrataciones)) {
                    var elementsContrataciones = (from contratacion in XDocument.Load(CNombreXML.XMLContrataciones).Descendants("contratacion")
                                    where Convert.ToInt64(contratacion.Element("codigoCliente").Value) == cliente.Codigo
                                    select contratacion).ToList();
                    foreach (var item in elementsContrataciones) {
                        var contratacion = new BEClienteAsociadoStreaming
                        {
                            Cliente = cliente,
                            Total = Convert.ToDecimal(item.Element("total").Value)
                        };
                        long codigoStreaming = Convert.ToInt64(item.Element("codigoStreaming").Value);
                        if (Convert.ToBoolean(item.Attribute("streamingLive").Value)) {
                            MPPStreamingLive mPPStreamingLive = new MPPStreamingLive();
                            contratacion.Streaming = mPPStreamingLive.Obtener(new BEStreamingLive { Codigo = codigoStreaming });
                        } else {
                            MPPStreamingVod mPPStreamingVod = new MPPStreamingVod();
                            contratacion.Streaming = mPPStreamingVod.Obtener(new BEStreamingVod { Codigo = codigoStreaming });
                        }
                        contrataciones.Add(contratacion);
                    }                    
                }
                return contrataciones;
            } catch (Exception ex) {
                throw ex;
            }
        }
        
    }
}
