using BE;
using System;
using System.Collections.Generic;
using Abstraccion;
using MPP;

namespace Negocio_BLL
{
    public class BLLProfesional : BLLJugador, IGestor<BEProfesional>
    {
        readonly MPPProfesional oMPPJProf;

        public BLLProfesional()
        {
            oMPPJProf = new MPPProfesional();
        }

        //|||||||||||||||||||||||||||||||||||||||| IMPLEMENTACION DE LA INTERFAZ

        public bool Guardar(BEProfesional oBEProf) => oMPPJProf.Guardar(oBEProf);
        public BEProfesional ListarObjeto(BEProfesional oBEProf) => oMPPJProf.ListarObjeto(oBEProf);
        public bool Eliminar(BEProfesional Objeto) => throw new NotImplementedException();
        public List<BEProfesional> ListarTodo() => throw new NotImplementedException();

        //|||||||||||||||||||||||||||||||||||||||||| MÉTODOS PROPIOS DE LA CLASE

        public override int ObtenerPuntaje(BEJugador oBEJug)
        {
            int puntaje = 20 * oBEJug.GolesRealizados - 4 * oBEJug.CantidadRojas - 2 * oBEJug.CantidadAmarillas;
            return puntaje;
        }

        public bool Guardar_JugadorXEquipo(BEProfesional oBEProf, BEEquipo oBEEqui)
        {
            return oMPPJProf.Guardar_JugadorXEquipo(oBEEqui, oBEProf);
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

    }
}
