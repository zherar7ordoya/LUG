using System;
using System.Collections.Generic;
using System.Collections;
using BE;
using Abstraccion;
using DAL;
using System.Data;

namespace MPP
{
    public class MPPEquipo : IGestor<BEEquipo>
    {
        readonly AccesoDatos oDatos;
        Dictionary<string, object> parametros;

        public MPPEquipo()
        {
            oDatos = new AccesoDatos();

        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

        #region NOTAS SOBRE POLIMORFISMO
        /*
         * El polimorfismo se aplica tanto a los métodos como a la asignación de
         * objetos a variables, y se manifiesta en dos formas principales:
         * polimorfismo de tiempo de compilación (o estático) y polimorfismo de 
         * tiempo de ejecución (o dinámico).
         * 
         * 1) Polimorfismo de tiempo de compilación (Estático): Se refiere al uso
         * de la herencia y de interfaces para permitir que una clase base pueda
         * ser utilizada de manera polimórfica. En este caso, la decisión sobre
         * qué método o propiedad se debe llamar se toma en tiempo de compilación.
         * Ejemplo:
         *      BEJugador oBEJugador;
         *      oBEJugador = new BEProfesional();
         *      oBEJugador.MetodoComun(); // Llama al método común de BEJugador
         * 
         * 2) Polimorfismo de tiempo de ejecución (Dinámico): Se refiere a la
         * capacidad de una variable de clase base para referenciar objetos de las
         * clases derivadas, y la decisión sobre qué método o propiedad se debe
         * llamar se toma en tiempo de ejecución.
         * Ejemplo:
         *      // Método que devuelve un BEJugador (BEProfesional o 
         *      // BEPrincipiante) en tiempo de ejecución.
         *      BEJugador oBEJugador = ObtenerJugador();
         *      // Llama al método específico de BEJugador (BEProfesional o 
         *      // BEPrincipiante) según el tipo real del objeto en tiempo de
         *      // ejecución.
         *      oBEJugador.MetodoComun();
         * 
         * En nuestro método ListarTodo(), se podrá leer este código:
         *      BEJugador oBEJugador;
         *      if (filaJugador["Rapado"] is DBNull)
         *      {
         *          oBEJugador = new BEProfesional();
         *      }
         *      else
         *      {
         *          oBEJugador = new BEPrincipiante { Rapado = true };
         *      }
         * Aquí, estamos viendo el polimorfismo de tiempo de ejecución.
         * oBEJugador es de tipo BEJugador (clase base), pero en tiempo de
         * ejecución, puede referenciar tanto a una instancia de BEProfesional
         * como a una instancia de BEPrincipiante. Si se llama a métodos
         * específicos de BEJugador a través de oBEJugador, el comportamiento real
         * se determinará por el tipo real del objeto al que apunta en ese momento
         * (sea BEProfesional o BEPrincipiante).
         * 
         * EN RESUMEN: el polimorfismo en C# abarca tanto métodos como asignación
         * de objetos, y ambas formas son útiles en diferentes contextos.
         */
        #endregion
        public List<BEEquipo> ListarTodo()
        {
            // LECTURA DE EQUIPOS (CON TECNICO 1:1 Y JUGADORES 1:M)
            List<BEEquipo> listaEquipos = new List<BEEquipo>();
            DataTable tablaEquipos = oDatos.Leer("Listar_Equipos", null);

            if (tablaEquipos.Rows.Count > 0)
            {
                foreach (DataRow filaEquipo in tablaEquipos.Rows)
                {
                    BEEquipo oBEEquipo = new BEEquipo
                    {
                        Codigo = Convert.ToInt32(filaEquipo["Codigo"]),
                        Nombre = filaEquipo["Equipo"].ToString(),
                        Color = filaEquipo["Color"].ToString()
                    };

                    // Cargar al técnico
                    BETecnico oBETec = new BETecnico
                    {
                        Nombre = filaEquipo["Nombre"].ToString(),
                        Apellido = filaEquipo["Apellido"].ToString(),
                        DNI = Convert.ToInt32(filaEquipo["DNI"])
                    };
                    oBEEquipo.Tecnico = oBETec;

                    // LECTURA DE JUGADORES (CON PRINCIPIANTES Y PROFESIONALES)
                    DataTable tablaJugadores = oDatos.Leer("Listar_Jugadores_Equipo",
                        new Dictionary<string, object> { { "@CodEqui", oBEEquipo.Codigo } });
                    List<BEJugador> listaJugadores = new List<BEJugador>();

                    if (tablaJugadores.Rows.Count > 0)
                    {
                        foreach (DataRow filaJugador in tablaJugadores.Rows)
                        {
                            BEJugador oBEJugador;

                            if (filaJugador["Rapado"] is DBNull)
                            {
                                oBEJugador = new BEProfesional();
                            }
                            else
                            {
                                oBEJugador = new BEPrincipiante { Rapado = true };
                            }

                            oBEJugador.Codigo = Convert.ToInt32(filaJugador["Codigo"]);
                            oBEJugador.Nombre = filaJugador["Nombre"].ToString();
                            oBEJugador.Apellido = filaJugador["Apellido"].ToString();
                            oBEJugador.DNI = Convert.ToInt32(filaJugador["DNI"]);
                            oBEJugador.CantidadRojas = Convert.ToInt32(filaJugador["TRoja"]);
                            oBEJugador.CantidadAmarillas = Convert.ToInt32(filaJugador["TAmarilla"]);
                            oBEJugador.GolesRealizados = Convert.ToInt32(filaJugador["Goles"]);

                            listaJugadores.Add(oBEJugador);
                        }
                        oBEEquipo.ListaJugadores = listaJugadores;
                    }
                    listaEquipos.Add(oBEEquipo);
                }
            }
            return listaEquipos;
        }


        public bool Guardar(BEEquipo oBEEq)
        {
            string consulta = "Alta_Equipo";
            parametros = new Dictionary<string, object>
            {
                { "@Nom", oBEEq.Nombre },
                { "@Color", oBEEq.Color },
                { "@CodTecnico", oBEEq.Tecnico.Codigo }
            };
            return oDatos.Escribir(consulta, parametros);
        }


        public bool Eliminar(BEEquipo Objeto)
        {
            throw new NotImplementedException();
        }


        public BEEquipo ListarObjeto(BEEquipo Objeto)
        {
            throw new NotImplementedException();
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

    }
}
