using LUG.BE;
using LUG.MPP;
using System.Collections.Generic;
using System;
using LUG.Parametros;
using System.Linq;
using System.Data;

namespace LUG.BLL
{
    public class BLLStreamingLive : BLLStreaming
    {
        private MPPStreamingLive _mPPStreamingLive;
        public BLLStreamingLive()
        {
            _mPPStreamingLive = new MPPStreamingLive();
        }
        public override decimal CalcularPrecio(BEStreaming streaming)
        {
            try {                
                if (streaming.Categoria == ECategoria.SD) {
                    return (decimal)(Math.Ceiling(streaming.Duracion/30) * (int)EPrecios.SD * 0.8);
                } else if (streaming.Categoria == ECategoria.HD) {
                    return (decimal)(Math.Ceiling(streaming.Duracion / 30) * (int)EPrecios.HD * 0.8);
                } else {
                    return (decimal)(Math.Ceiling(streaming.Duracion / 30) * (int)EPrecios.FHD * 0.8);
                }
            } catch (Exception ex) {
                throw ex;
            }            
        }

        public bool Guardar(BEStreamingLive beStreamingLive)
        {
            try {
                if (beStreamingLive.Codigo == 0) {                                        
                    beStreamingLive.Codigo = _mPPStreamingLive.ObtenerUltimoCodigo();
                    return _mPPStreamingLive.Insertar(beStreamingLive);
                }
                return _mPPStreamingLive.Modificar(beStreamingLive);
            } catch (Exception ex) {
                throw ex;
            }
        }

        public bool Eliminar(BEStreamingLive bEStreamingLive)
        {
            try {
                return _mPPStreamingLive.Eliminar(bEStreamingLive);
            } catch (Exception ex) {
                throw ex;
            }
        }

        public BEStreamingLive Obtener(BEStreamingLive bEStreamingLive)
        {
            try {
                return _mPPStreamingLive.Obtener(bEStreamingLive);
            } catch (Exception ex) {
                throw ex;
            }
        }

        public List<BEStreamingLive> Obtener()
        {
            try {
                return _mPPStreamingLive.ObtenerTodos();
            } catch (Exception ex) {
                throw ex;
            }
        }

        public BEStreaming BuscarPorCodigo(long codigoStreaming)
        {
            try {
                return _mPPStreamingLive.BuscarPor(a => a.Codigo == codigoStreaming);
            } catch (Exception ex) {
                throw ex;
            }
        }

        public List<BEClienteAsociadoStreaming> ObtenerContrataciones()
        {
            try {
                return _mPPStreamingLive.ObtenerContrataciones();
            } catch (Exception ex) {
                throw ex;
            }
        }
    }
}
