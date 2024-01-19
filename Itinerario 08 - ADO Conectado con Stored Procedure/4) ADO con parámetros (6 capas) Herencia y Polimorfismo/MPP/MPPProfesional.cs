using System;
using System.Collections.Generic;
using System.Collections;
using DAL;
using Abstraccion;
using BE;
using System.Data;

namespace MPP
{
    public class MPPProfesional : IGestor<BEProfesional>
    {
        readonly AccesoDatos oDatos;
        Dictionary<string, object> parametros;

        public MPPProfesional()
        {
            oDatos = new AccesoDatos();
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

        public bool Guardar(BEProfesional oBEProf)
        {

            string consulta = "Alta_JProfesional";
            parametros = new Dictionary<string, object>
            {
                { "@TAmarilla", oBEProf.CantidadAmarillas },
                { "@TRojas", oBEProf.CantidadRojas },
                { "@GolesR", oBEProf.GolesRealizados },
                { "@Nombre", oBEProf.Nombre },
                { "@Apellido", oBEProf.Apellido },
                { "@DNI", oBEProf.DNI }
            };
            return oDatos.Escribir(consulta, parametros);
        }


        public BEProfesional ListarObjeto(BEProfesional oBEProf)
        {
            string consulta = "Buscar_Jugador_DNI";
            parametros = new Dictionary<string, object> { { "@DNI", oBEProf.DNI } };
            DataTable Tabla = oDatos.Leer(consulta, parametros);

            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in Tabla.Rows)
                {
                    BEProfesional oBEP = new BEProfesional
                    {
                        Codigo = Convert.ToInt32(fila["Codigo"]),
                        Nombre = fila["Nombre"].ToString(),
                        Apellido = fila["Apellido"].ToString(),
                        DNI = Convert.ToInt32(fila["DNI"])
                    };
                    return oBEP;
                }
            }
            return null;
        }


        public bool Guardar_JugadorXEquipo(BEEquipo oBEEq, BEProfesional oBEEProf)
        {
            BEProfesional oBEProfBuscado = ListarObjeto(oBEEProf);

            if (oBEProfBuscado.Codigo != 0)
            {
                string consulta = "Alta_Jugador_Equipo";
                parametros = new Dictionary<string, object>
                {
                    { "@CodEquipo", oBEEq.Codigo },
                    { "@CodJugador", oBEProfBuscado.Codigo }
                };
                return oDatos.Escribir(consulta, parametros);
            }
            else { return false; }
        }


        public bool Eliminar(BEProfesional Objeto)
        {
            throw new NotImplementedException();
        }


        public List<BEProfesional> ListarTodo()
        {
            throw new NotImplementedException();
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

    }
}
