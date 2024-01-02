using LUG.BE;
using LUG.Parametros;
using System.Collections.Generic;
using System.Xml.Linq;
using System;
using System.IO;
using System.Linq;
using System.CodeDom;
using System.Xml;

namespace LUG.MPP
{
    public class MPPStreamingLive
    {
        public MPPStreamingLive() { }
        public bool Modificar(BEStreamingLive streamingLive)
        {
            try {
                XDocument doc = XDocument.Load(CNombreXML.XMLStreaming);
                var streamingBuscado = ObtenerElementsXml(streamingLive, doc);
                foreach (var element in streamingBuscado) {
                    element.SetAttributeValue("codigo", streamingLive.Codigo);
                    element.SetElementValue("duracion", streamingLive.Duracion);
                    element.SetElementValue("nombre", streamingLive.Nombre);
                    element.SetElementValue("categoria", ((int)streamingLive.Categoria).ToString());
                    element.SetElementValue("fechaTransmicion", streamingLive.FechaTransmicion.ToString("dd/MM/yyyy"));
                }
                doc.Save(CNombreXML.XMLStreaming);
                return true;
            } catch (Exception ex) {
                throw ex;
            }
        }

        public bool Insertar(BEStreamingLive streamingLive)
        {
            try {
                if (!File.Exists(CNombreXML.XMLStreaming)) {
                    var streaming = new XElement("streamings",
                        new XElement("streaming",
                        new XAttribute("codigo", streamingLive.Codigo.ToString().Trim()),
                        new XElement("duracion", streamingLive.Duracion.ToString().Trim()),
                        new XElement("nombre", streamingLive.Nombre.ToString().Trim()),
                        new XElement("categoria", ((int)streamingLive.Categoria).ToString().Trim()),
                        new XElement("fechaTransmicion", streamingLive.FechaTransmicion.ToString("dd/MM/yyyy").ToString())));
                    streaming.Save(CNombreXML.XMLStreaming);
                } else {
                    var xml = XDocument.Load(CNombreXML.XMLStreaming);
                    xml.Element("streamings").Add(new XElement("streaming",
                                    new XAttribute("codigo", streamingLive.Codigo.ToString().Trim()),
                                    new XElement("duracion", streamingLive.Duracion.ToString().Trim()),
                                    new XElement("nombre", streamingLive.Nombre.ToString().Trim()),
                                    new XElement("categoria", ((int)streamingLive.Categoria).ToString().Trim()),
                                    new XElement("fechaTransmicion", streamingLive.FechaTransmicion.ToString("dd/MM/yyyy").ToString())));
                    xml.Save(CNombreXML.XMLStreaming);
                }
                return true;
            } catch (Exception ex) {
                throw ex;
            }
        }


        public List<XElement> ObtenerElementsXml(BEStreamingLive beStreamingLive, XDocument doc)
        {
            try {
                return (from streamingLive in doc.Descendants("streaming")
                        where long.Parse(streamingLive.Attribute("codigo").Value) == beStreamingLive.Codigo
                        select streamingLive).ToList();
            } catch (Exception ex) {
                throw ex;
            }
        }

        public BEStreamingLive Obtener(BEStreamingLive strLive)
        {
            try {
                return (from streaming in XDocument.Load(CNombreXML.XMLStreaming).Descendants("streaming")
                        where long.Parse(streaming.Attribute("codigo").Value) == strLive.Codigo
                        select new BEStreamingLive
                        {
                            Categoria = (ECategoria)Enum.Parse(typeof(ECategoria), streaming.Element("categoria").Value),
                            Duracion = Convert.ToInt64(streaming.Element("duracion").Value.ToString()),
                            Codigo = Convert.ToInt64(streaming.Attribute("codigo").Value.ToString()),
                            Nombre = streaming.Element("nombre").Value.ToString(),
                            FechaTransmicion = Convert.ToDateTime(streaming.Element("fechaTransmicion").Value)
                        }).FirstOrDefault();
            } catch (Exception ex) {
                throw ex;
            }
        }

        public BEStreamingLive BuscarPor(Func<BEStreamingLive, bool> func)
        {
            try {
                var streamings = ObtenerTodos();
                return streamings.Where(func).FirstOrDefault();
            } catch (Exception ex) {
                throw ex;
            }
        }

        public List<BEStreamingLive> ObtenerTodos()
        {
            try {
                var streamings = new List<BEStreamingLive>();
                if (File.Exists(CNombreXML.XMLStreaming)) {
                    streamings = (from streamingLive in XDocument.Load(CNombreXML.XMLStreaming).Descendants("streaming")
                                  where streamingLive.Element("fechaTransmicion") != null
                                  select new BEStreamingLive
                                  {
                                      Categoria = (ECategoria)Enum.Parse(typeof(ECategoria), streamingLive.Element("categoria").Value),
                                      Duracion = Convert.ToInt64(streamingLive.Element("duracion").Value.ToString()),
                                      Codigo = Convert.ToInt64(streamingLive.Attribute("codigo").Value.ToString()),
                                      Nombre = streamingLive.Element("nombre").Value.ToString(),
                                      FechaTransmicion = Convert.ToDateTime(streamingLive.Element("fechaTransmicion").Value)
                                  }).ToList();
                }
                return streamings;
            } catch (Exception ex) {
                throw ex;
            }
        }

        public bool Eliminar(BEStreamingLive streamingLive)
        {
            try {
                XDocument doc = XDocument.Load(CNombreXML.XMLStreaming);
                var streamings = ObtenerElementsXml(streamingLive, doc);
                streamings.Remove();
                doc.Save(CNombreXML.XMLStreaming);
                return true;
            } catch (Exception ex) {
                throw ex;
            }
        }

        public long ObtenerUltimoCodigo()
        {
            try {
                var codigos = new List<long>();
                if (File.Exists(CNombreXML.XMLStreaming)) {
                    codigos = (from streamingLive in XDocument.Load(CNombreXML.XMLStreaming).Descendants("streaming")
                               select Convert.ToInt64(streamingLive.Attribute("codigo").Value.ToString())).ToList();
                }
                return codigos.Count > 0 ? codigos.Max() + 1 : 1;
            } catch (Exception ex) {
                throw ex;
            }
        }


        public List<XElement> ObtenerElementsXmlContrataciones(BEClienteAsociadoStreaming contratacion, XDocument doc)
        {
            try {
                return (from contrat in doc.Descendants("contratacion")
                        where long.Parse(contrat.Element("codigoCliente").Value) == contratacion.Cliente.Codigo
                            && (long.Parse(contrat.Element("codigoStreaming").Value) == contratacion.Streaming.Codigo)
                        select contrat).ToList();
            } catch (Exception ex) {
                throw ex;
            }
        }

        public List<BEClienteAsociadoStreaming> ObtenerContrataciones()
        {
            try {
                var contrataciones = new List<BEClienteAsociadoStreaming>();
                if (File.Exists(CNombreXML.XMLContrataciones)) {
                    var elementsContrataciones = (from contratacion in XDocument.Load(CNombreXML.XMLContrataciones).Descendants("contratacion")                                                  
                                                  select contratacion).ToList();
                    foreach (var item in elementsContrataciones) {
                        if (Convert.ToBoolean(item.Attribute("streamingLive").Value)) {
                            var contratacion = new BEClienteAsociadoStreaming
                            {
                                Cliente = new MPPCliente().Obtener(new BECliente { Codigo = Convert.ToInt64(item.Element("codigoCliente").Value) }),
                                Total = Convert.ToDecimal(item.Element("total").Value)
                            };
                            contratacion.Streaming = Obtener(new BEStreamingLive { Codigo = Convert.ToInt64(item.Element("codigoStreaming").Value) });
                            contrataciones.Add(contratacion);
                        }
                    }
                }
                return contrataciones;
            } catch (Exception ex) {
                throw ex;
            }
        }
    }
}
