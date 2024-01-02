using LUG.BE;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LUG.BLL
{
    public class BLLStreamingReporte
    {
        private BLLStreamingLive _bLLStreamingLive;
        private BLLStreamingVod _bLLStreamingVod;
        public BLLStreamingReporte()
        {
            _bLLStreamingLive = new BLLStreamingLive();
            _bLLStreamingVod = new BLLStreamingVod();
        }

        public Dictionary<string, decimal> ObtenerDuracion(bool minimo = false)
        {
            try {
                var agrupadoPorCategoria = new Dictionary<string, decimal>();
                List<BEClienteAsociadoStreaming> streams = new List<BEClienteAsociadoStreaming>();
                streams.AddRange(_bLLStreamingVod.ObtenerContrataciones());
                streams.AddRange(_bLLStreamingLive.ObtenerContrataciones());
                if (streams.Count == 0)
                    return agrupadoPorCategoria;                
                var agrupar = streams.GroupBy(a => a.Streaming.Categoria);
                foreach (var group in agrupar) {
                    double condicionMaximoMinimo = 0;
                    if (minimo)
                        condicionMaximoMinimo = group.Min(a => a.Streaming.Duracion);
                    else
                        condicionMaximoMinimo = group.Max(a => a.Streaming.Duracion);                    
                    foreach (var item in group.Where(a => a.Streaming.Duracion == condicionMaximoMinimo)) {
                        if (!agrupadoPorCategoria.ContainsKey($"{group.Key.ToString()}-{item.Streaming.Nombre}")) {
                            agrupadoPorCategoria.Add($"{group.Key}-{item.Streaming.Nombre}", item.Total);
                        } else {
                            agrupadoPorCategoria[$"{group.Key}-{item.Streaming.Nombre}"] += item.Total;
                        }
                        
                    }                    
                }                
                return agrupadoPorCategoria;                
            } catch (Exception ex) {
                throw ex;
            }
        }

        public Dictionary<string, decimal> ObtenerTotalRecaudado()
        {
            try {
                var agrupadoPorCategoria = new Dictionary<string, decimal>();
                List<BEClienteAsociadoStreaming> streams = new List<BEClienteAsociadoStreaming>();
                streams.AddRange(_bLLStreamingVod.ObtenerContrataciones());
                streams.AddRange(_bLLStreamingLive.ObtenerContrataciones());
                if (streams.Count == 0)
                    return agrupadoPorCategoria;                
                var agrupar = streams.GroupBy(a => a.Streaming.Categoria);
                foreach (var group in agrupar) {
                    agrupadoPorCategoria.Add(group.Key.ToString(), 0);
                    foreach (var item in group) {                        
                        agrupadoPorCategoria[group.Key.ToString()] += item.Total;    
                    }
                }
                return agrupadoPorCategoria;
            } catch (Exception ex) {
                throw ex;
            }
        }
    }
}
