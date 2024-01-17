using System;
using System.Collections.Generic;
using BE;
using Abstraccion;
using MPP;

namespace Negocio_BLL
{
    public class BLLTecnico : IGestor<BETecnico>
    {
        readonly MPPTecnico oMPPTec;

        public BLLTecnico()
        {
            oMPPTec = new MPPTecnico();
        }

        //|||||||||||||||||||||||||||||||||||||||| IMPLEMENTACIÓN DE LA INTERFAZ

        public bool Guardar(BETecnico oBETec) => oMPPTec.Guardar(oBETec);
        public List<BETecnico> ListarTodo() => oMPPTec.ListarTodo();
        public bool Eliminar(BETecnico Objeto) => throw new NotImplementedException();
        public BETecnico ListarObjeto(BETecnico Objeto) => throw new NotImplementedException();

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

    }
}
