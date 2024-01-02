using LUG.BE;
using LUG.MPP;
using LUG.Parametros;
using System.Collections.Generic;
using System;
using System.Linq;

namespace LUG.BLL
{
    public class BLLStreamingVod: BLLStreaming
    {
        private MPPStreamingVod _mPPStreamingVod;
        public BLLStreamingVod()
        {
            _mPPStreamingVod = new MPPStreamingVod();
        }
        public override decimal CalcularPrecio(BEStreaming streaming)
        {
            try {
                if (streaming.Categoria == ECategoria.SD) {
                    return (decimal)(Math.Ceiling(streaming.Duracion / 30) * (int)EPrecios.SD * 0.9);
                } else if (streaming.Categoria == ECategoria.HD) {
                    return (decimal)(Math.Ceiling(streaming.Duracion / 30) * (int)EPrecios.HD * 0.9);
                } else {
                    return (decimal)(Math.Ceiling(streaming.Duracion / 30) * (int)EPrecios.FHD * 0.9);
                }
            } catch (Exception ex) {
                throw ex;
            }
        }

        public bool Guardar(BEStreamingVod beStreamingVod)
        {
            try {
                if (beStreamingVod.Codigo == 0) {                    
                    beStreamingVod.Codigo = _mPPStreamingVod.ObtenerUltimoCodigo();
                    return _mPPStreamingVod.Insertar(beStreamingVod);                    
                }
                return _mPPStreamingVod.Modificar(beStreamingVod);
            } catch (Exception ex) {
                throw ex;
            }
        }

        public bool Eliminar(BEStreamingVod bEStreamingVod)
        {
            try {
                return _mPPStreamingVod.Eliminar(bEStreamingVod);
            } catch (Exception ex) {
                throw ex;
            }
        }

        public BEStreamingVod Obtener(BEStreamingVod bEStreamingVod)
        {
            try {
                return _mPPStreamingVod.Obtener(bEStreamingVod);
            } catch (Exception ex) {
                throw ex;
            }
        }

        public List<BEStreamingVod> Obtener()
        {
            try {
                return _mPPStreamingVod.ObtenerTodos();
            } catch (Exception ex) {
                throw ex;
            }
        }

        public BEStreaming BuscarPorCodigo(long codigoStreaming)
        {
            try {
                return _mPPStreamingVod.BuscarPor(x => x.Codigo == codigoStreaming);
            } catch (Exception ex) {
                throw ex;
            }
        }

        public List<BEClienteAsociadoStreaming> ObtenerContrataciones()
        {
            try {
                return _mPPStreamingVod.ObtenerContrataciones();
            } catch (Exception ex) {
                throw ex;
            }
        }
    }
}
