using LUG.BE;
using LUG.MPP;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LUG.BLL
{
    public class BLLCliente
    {
        private MPPCliente _mPPCliente;
        public BLLCliente()
        {
            _mPPCliente = new MPPCliente();
        }

        public bool Guardar(BECliente cliente)
        {
            try {
                var clienteCargado = _mPPCliente.BuscarPor(a => a.DNI == cliente.DNI && cliente.Codigo != a.Codigo);
                if (clienteCargado != null) {
                    throw new Exception($"El DNI se encuentra cargado para el cliente ${clienteCargado.DNI}");
                }                
                return _mPPCliente.Guardar(cliente);                
            } catch (Exception ex) {
                throw ex;
            }
        }

        public bool Eliminar(BECliente bECliente)
        {
            try {                
                return _mPPCliente.Eliminar(bECliente);                
            } catch (Exception ex) {
                throw ex;
            }
        }

        public BECliente Obtener(BECliente bECliente)
        {
            try {
                return _mPPCliente.Obtener(bECliente);
            } catch (Exception ex) {
                throw ex;
            }
        }

        public List<BECliente> Obtener()
        {
            try {
                return _mPPCliente.ObtenerTodos();
            } catch (Exception ex) {
                throw ex;
            }
        }

        public bool Contratar(BECliente bECliente, BEStreaming bEStreaming)
        {
            try {
                var contratacion = new BEClienteAsociadoStreaming
                {
                    Cliente = bECliente,
                    Streaming = bEStreaming,
                };
                if (bEStreaming is BEStreamingLive)
                    contratacion.Total = new BLLStreamingLive().CalcularPrecio(bEStreaming);
                else
                    contratacion.Total = new BLLStreamingVod().CalcularPrecio(bEStreaming);
                _mPPCliente.Contratar(contratacion);
                return true;
            } catch (Exception ex) {
                throw ex;
            }
        }

        public void CancelarContratacion(BECliente bECliente, BEStreaming bEStreaming)
        {
            try {
                var contratacion = new BEClienteAsociadoStreaming
                {
                    Cliente = bECliente,
                    Streaming = bEStreaming,
                };                
                _mPPCliente.CancelarContrato(contratacion);
            } catch (Exception ex) {
                throw ex;
            }
        }

        public List<BEClienteAsociadoStreaming> ObtenerContrataciones(BECliente cliente)
        {
            try {
                return _mPPCliente.ObtenerContrataciones(cliente);
            } catch (Exception ex) {
                throw ex;
            }
        }
    }
}
