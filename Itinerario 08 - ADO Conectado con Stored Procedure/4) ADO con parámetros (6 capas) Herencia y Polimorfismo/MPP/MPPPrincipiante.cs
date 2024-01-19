using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using DAL;
using Abstraccion;
using BE;

namespace MPP
{
    public class MPPPrincipiante : IGestor<BEPrincipiante>
    {
        readonly AccesoDatos oDatos;
        Dictionary<string, object> parametros;

        public MPPPrincipiante()
        {
            oDatos = new AccesoDatos();
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

        public bool Guardar(BEPrincipiante oBEPrin)
        {

            string consulta = "Alta_JPrincipiante";
            parametros = new Dictionary<string, object>
            {
                { "@TAmarilla", oBEPrin.CantidadAmarillas },
                { "@TRojas", oBEPrin.CantidadRojas },
                { "@GolesR", oBEPrin.GolesRealizados },
                { "@Rapado", oBEPrin.Rapado },
                { "@Nombre", oBEPrin.Nombre },
                { "@Apellido", oBEPrin.Apellido },
                { "@DNI", oBEPrin.DNI }
            };
            return oDatos.Escribir(consulta, parametros);
        }


        public BEPrincipiante ListarObjeto(BEPrincipiante oBEprin)
        {
            string consulta = "Buscar_Jugador_DNI";
            parametros = new Dictionary<string, object> { { "@DNI", oBEprin.DNI } };
            DataTable Tabla = oDatos.Leer(consulta, parametros);

            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in Tabla.Rows)
                {
                    BEPrincipiante oBEP = new BEPrincipiante
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


        public bool Guardar_JugadorXEquipo(BEEquipo oBEEq, BEPrincipiante oBEEPri)
        {
            /*
             * Para graabar en la tabla intermedia necesito el código de equipo y
             * el de jugador. Como el jugador fue dado de alta recien, necesito el
             * código, por eso listo el objeto por DNI. Si se grabó, lo recupero y
             * escribo luego en la tabla intermedia. Si no, devuelvo falso.
             */
            BEPrincipiante oBEPriBuscado = ListarObjeto(oBEEPri);

            if (oBEPriBuscado.Codigo != 0)
            {
                string consulta = "Alta_Jugador_Equipo";
                parametros = new Dictionary<string, object>
                {
                    { "@CodEquipo", oBEEq.Codigo },
                    { "@CodJugador", oBEPriBuscado.Codigo }
                };
                return oDatos.Escribir(consulta, parametros);
            }
            else { return false; }
        }


        public List<BEPrincipiante> ListarTodo()
        {
            throw new NotImplementedException();
        }


        public bool Eliminar(BEPrincipiante Objeto)
        {
            throw new NotImplementedException();
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

    }
}
