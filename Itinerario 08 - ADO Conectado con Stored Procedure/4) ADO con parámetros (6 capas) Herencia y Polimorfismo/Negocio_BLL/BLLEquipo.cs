using System;
using System.Collections.Generic;
using BE;
using Abstraccion;
using MPP;

namespace Negocio_BLL
{
    public class BLLEquipo : IGestor<BEEquipo>
    {
        readonly MPPEquipo oMPPEquipo;

        public BLLEquipo()
        {
            oMPPEquipo = new MPPEquipo();
        }

        //|||||||||||||||||||||||||||||||||||||||| IMPLEMENTACION DE LA INTERFAZ

        public List<BEEquipo> ListarTodo() => oMPPEquipo.ListarTodo();
        public bool Guardar(BEEquipo oBEEquipo) => oMPPEquipo.Guardar(oBEEquipo);
        public bool Eliminar(BEEquipo objeto) => throw new NotImplementedException();
        public BEEquipo ListarObjeto(BEEquipo objeto) => throw new NotImplementedException();

        //|||||||||||||||||||||||||||||||||||||||||||||||||||||| METODOS PROPIOS

        public int ObtenerPuntajeEquipo(BEEquipo oBEEquipo)
        {
            int puntos = 0;

            foreach (BEJugador jugador in oBEEquipo.ListaJugadores)
            {
                // De esta manera se maneja el polimorfismo.
                if (jugador is BEPrincipiante)
                {
                    BLLPrincipiante oBLLprincipiante = new BLLPrincipiante();
                    puntos = oBLLprincipiante.ObtenerPuntaje(jugador) + puntos;
                }
                else
                {
                    BLLProfesional oBLLprofesional = new BLLProfesional();
                    puntos = oBLLprofesional.ObtenerPuntaje(jugador) + puntos;
                }
            }
            return puntos;
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

    }
}
