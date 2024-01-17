using System;
using System.Collections.Generic;
using BE;
using Abstraccion;
using MPP;

namespace Negocio_BLL
{
    public class BLLPrincipiante : BLLJugador, IGestor<BEPrincipiante>
    {
        readonly MPPPrincipiante oMPPJPrin;

        public BLLPrincipiante()
        {
            oMPPJPrin = new MPPPrincipiante();
        }

        //|||||||||||||||||||||||||||||||||||||||| IMPLEMENTACIÓN DE LA INTERFAZ

        public bool Guardar(BEPrincipiante oBEPrin) => oMPPJPrin.Guardar(oBEPrin);
        public BEPrincipiante ListarObjeto(BEPrincipiante oBEPrin) => oMPPJPrin.ListarObjeto(oBEPrin);
        public bool Eliminar(BEPrincipiante Objeto) => throw new NotImplementedException();
        public List<BEPrincipiante> ListarTodo() => throw new NotImplementedException();


        //|||||||||||||||||||||||||||||||||||||||||||||||||||||| MÉTODOS PROPIOS

        public override int ObtenerPuntaje(BEJugador oBEJug)
        {
            int puntaje = 10 * oBEJug.GolesRealizados - 2 * oBEJug.CantidadRojas - 2 * oBEJug.CantidadAmarillas;
            return puntaje;
        }

        public bool Guardar_JugadorXEquipo(BEPrincipiante oBEPrin, BEEquipo oBEEqui)
        {
            return oMPPJPrin.Guardar_JugadorXEquipo(oBEEqui, oBEPrin);
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

    }
}
