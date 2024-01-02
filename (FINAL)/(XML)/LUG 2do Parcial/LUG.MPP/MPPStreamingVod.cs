using LUG.BE;
using LUG.Parametros;
using System.Collections.Generic;
using System.Xml.Linq;
using System;
using System.IO;
using System.Linq;

namespace LUG.MPP
{
    public class MPPStreamingVod
    {        
        public MPPStreamingVod() {}

        public bool Modificar(BEStreamingVod streamingVod)
        {
            try {
                XDocument doc = XDocument.Load(CNombreXML.XMLStreaming);
                var streamingBuscado = ObtenerElementsXml(streamingVod, doc);
                foreach (var element in streamingBuscado) {
                    element.SetAttributeValue("codigo", streamingVod.Codigo);
                    element.SetElementValue("duracion", streamingVod.Duracion);
                    element.SetElementValue("nombre", streamingVod.Nombre);
                    element.SetElementValue("categoria", ((int)streamingVod.Categoria).ToString());
                    element.SetElementValue("tipoReproduccion", ((int)streamingVod.TipoReproduccion).ToString());
                }
                doc.Save(CNombreXML.XMLStreaming);
                return true;
            } catch (Exception ex) {
                throw ex;
            }
        }

        public bool Insertar(BEStreamingVod StreamingVod)
        {
            try {            
                if (!File.Exists(CNombreXML.XMLStreaming)) {
                    var streaming = new XElement("streamings",
                        new XElement("streaming",
                        new XAttribute("codigo", StreamingVod.Codigo.ToString().Trim()),
                        new XElement("duracion", StreamingVod.Duracion.ToString().Trim()),
                        new XElement("nombre", StreamingVod.Nombre.ToString().Trim()),
                        new XElement("categoria", ((int)StreamingVod.Categoria).ToString().Trim()),
                        new XElement("tipoReproduccion", ((int)StreamingVod.TipoReproduccion).ToString())));
                    streaming.Save(CNombreXML.XMLStreaming);
                } else {
                    var xml = XDocument.Load(CNombreXML.XMLStreaming);
                    xml.Element("streamings").Add(new XElement("streaming",
                                        new XAttribute("codigo", StreamingVod.Codigo.ToString().Trim()),
                                        new XElement("duracion", StreamingVod.Duracion.ToString().Trim()),
                                        new XElement("nombre", StreamingVod.Nombre.ToString().Trim()),
                                        new XElement("categoria", ((int)StreamingVod.Categoria).ToString().Trim()),
                                        new XElement("tipoReproduccion", ((int)StreamingVod.TipoReproduccion).ToString())));
                    xml.Save(CNombreXML.XMLStreaming);
                }                                                                   
                return true;
            } catch (Exception ex) {
                throw ex;
            }
        }

        public BEStreamingVod BuscarPor(Func<BEStreamingVod, bool> func)
        {
            try {
                var streamings = ObtenerTodos();
                return streamings.Where(func).FirstOrDefault();
            } catch (Exception ex) {
                throw ex;
            }
        }

        public List<XElement> ObtenerElementsXml(BEStreamingVod beStreamingVod, XDocument doc)
        {
            try {
                return (from streamingVod in doc.Descendants("streaming")                
                        where long.Parse(streamingVod.Attribute("codigo").Value) == beStreamingVod.Codigo
                        select streamingVod).ToList();
            } catch (Exception ex) {
                throw ex;
            }
        }

        public BEStreamingVod Obtener(BEStreamingVod strLive)
        {
            try {
                return (from streaming in XDocument.Load(CNombreXML.XMLStreaming).Descendants("streaming")
                        where long.Parse(streaming.Attribute("codigo").Value) == strLive.Codigo
                        select new BEStreamingVod
                        {
                            Categoria = (ECategoria)Enum.Parse(typeof(ECategoria), streaming.Element("categoria").Value),
                            Duracion = Convert.ToInt64(streaming.Element("duracion").Value.ToString()),
                            Nombre = streaming.Element("nombre").Value.ToString(),
                            Codigo = Convert.ToInt64(streaming.Attribute("codigo").Value.ToString()),
                            TipoReproduccion = (ETipoReproduccion)Enum.Parse(typeof(ETipoReproduccion), streaming.Element("tipoReproduccion").Value),
                        }).FirstOrDefault();
            } catch (Exception ex) {
                throw ex;
            }
        }

        public List<BEStreamingVod> ObtenerTodos()
        {
            try {
                var streamings = new List<BEStreamingVod>();
                if (File.Exists(CNombreXML.XMLStreaming)) {
                    streamings = (from streaming in XDocument.Load(CNombreXML.XMLStreaming).Descendants("streaming")
                            where streaming.Element("tipoReproduccion") != null
                            select new BEStreamingVod
                            {
                                Categoria = (ECategoria)Enum.Parse(typeof(ECategoria), streaming.Element("categoria").Value),
                                Duracion = Convert.ToInt64(streaming.Element("duracion").Value.ToString()),
                                Nombre = streaming.Element("nombre").Value.ToString(),
                                Codigo = Convert.ToInt64(streaming.Attribute("codigo").Value.ToString()),
                                TipoReproduccion = (ETipoReproduccion)Enum.Parse(typeof(ETipoReproduccion), streaming.Element("tipoReproduccion").Value),
                            }).ToList();
                }
                return streamings;
            } catch (Exception ex) {
                throw ex;
            }
        }

        public bool Eliminar(BEStreamingVod StreamingVod)
        {
            try {
                XDocument doc = XDocument.Load(CNombreXML.XMLStreaming);
                var elements = ObtenerElementsXml(StreamingVod, doc);
                elements.Remove();
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

        public List<BEClienteAsociadoStreaming> ObtenerContrataciones()
        {
            try {
                var contrataciones = new List<BEClienteAsociadoStreaming>();
                if (File.Exists(CNombreXML.XMLContrataciones)) {
                    var elementsContrataciones = (from contratacion in XDocument.Load(CNombreXML.XMLContrataciones).Descendants("contratacion")                                                  
                                                  select contratacion).ToList();
                    foreach (var item in elementsContrataciones) {
                        if (!Convert.ToBoolean(item.Attribute("streamingLive").Value)) {
                            var contratacion = new BEClienteAsociadoStreaming
                            {
                                Cliente = new MPPCliente().Obtener(new BECliente { Codigo = Convert.ToInt64(item.Element("codigoCliente").Value) }),
                                Total = Convert.ToDecimal(item.Element("total").Value)
                            };

                            contratacion.Streaming = Obtener(new BEStreamingVod { Codigo = Convert.ToInt64(item.Element("codigoStreaming").Value) });
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
