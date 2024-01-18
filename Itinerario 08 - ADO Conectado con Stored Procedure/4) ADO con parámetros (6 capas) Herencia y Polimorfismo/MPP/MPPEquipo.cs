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

        public List<BEEquipo> ListarTodo()
        {
            List<BEEquipo> equipos = new List<BEEquipo>();
            string consulta = "Listar_Equipos";
            DataTable tabla = oDatos.Leer(consulta, null);

            //rcorro la tabla dentro del Dataset y la paso a lista
            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    BEEquipo oBEEquipo = new BEEquipo();
                    oBEEquipo.Codigo = Convert.ToInt32(fila["Codigo"]);
                    oBEEquipo.Nombre = fila["Equipo"].ToString();
                    oBEEquipo.Color = fila["Color"].ToString();
                    //busco al tecnico
                    //lo cargo usando el constrcutor sobrecargado
                    BETecnico oBETec = new BETecnico(fila["Nombre"].ToString(), fila["Apellido"].ToString(), Convert.ToInt32(fila["DNI"]));
                    //oBETec.Nombre = fila["Nombre"].ToString();
                    //oBETec.Apellido = fila["Apellido"].ToString();
                    //oBETec.DNI = Convert.ToInt32(fila["DNI"]);
                    oBEEquipo.Tecnico = oBETec;
                    //busco la lista de jugadores
                    AccesoDatos oDatos2 = new AccesoDatos();
                    parametros = new Dictionary<string, object>();
                    parametros.Add("@CodEqui", oBEEquipo.Codigo);
                    DataTable Tabla2 = oDatos2.Leer("Listar_Jugadores_Equipo", parametros);
                    List<BEJugador> LJugador = new List<BEJugador>();
                    if (Tabla2.Rows.Count > 0)
                    {
                        foreach (DataRow fila2 in Tabla2.Rows)
                        {
                            //si el campo rapado es NULL entonces es un jugador Profesional
                            if (fila2["Rapado"] is DBNull)

                            {
                                BEProfesional oBEPro = new BEProfesional();
                                oBEPro.Codigo = Convert.ToInt32(fila2["Codigo"]);
                                oBEPro.Nombre = fila2["Nombre"].ToString();
                                oBEPro.Apellido = fila2["Apellido"].ToString();
                                oBEPro.DNI = Convert.ToInt32(fila2["DNI"]);
                                oBEPro.CantidadRojas = Convert.ToInt32(fila2["TRoja"]);
                                oBEPro.CantidadAmarillas = Convert.ToInt32(fila2["TAmarilla"]);
                                oBEPro.GolesRealizados = Convert.ToInt32(fila2["Goles"]);
                                LJugador.Add(oBEPro);
                            }

                            else
                            {//si el campo rapado es distinto de null entonces es true y es principiant
                                BEPrincipiante oBEPrin = new BEPrincipiante();
                                oBEPrin.Rapado = true;
                                oBEPrin.Codigo = Convert.ToInt32(fila2["Codigo"]);
                                oBEPrin.Nombre = fila2["Nombre"].ToString();
                                oBEPrin.Apellido = fila2["Apellido"].ToString();
                                oBEPrin.DNI = Convert.ToInt32(fila2["DNI"]);
                                oBEPrin.CantidadRojas = Convert.ToInt32(fila2["TRoja"]);
                                oBEPrin.CantidadAmarillas = Convert.ToInt32(fila2["TAmarilla"]);
                                oBEPrin.GolesRealizados = Convert.ToInt32(fila2["Goles"]);
                                LJugador.Add(oBEPrin);
                            }
                        }
                        oBEEquipo.ListaJugadores = LJugador;
                    }
                    equipos.Add(oBEEquipo);
                }
            }
            return equipos;
        }




        public bool Guardar(BEEquipo oBEEq)
        {
            string Consulta_SQL = "Alta_Equipo";
            parametros = new Dictionary<string, object>();
            parametros.Add("@Nom", oBEEq.Nombre);
            parametros.Add("@Color", oBEEq.Color);
            parametros.Add("@CodTecnico", oBEEq.Tecnico.Codigo);

            return oDatos.Escribir(Consulta_SQL, parametros);
        }
        public bool Eliminar(BEEquipo Objeto)
        {
            throw new NotImplementedException();
        }

        public BEEquipo ListarObjeto(BEEquipo Objeto)
        {
            throw new NotImplementedException();
        }


    }
}
