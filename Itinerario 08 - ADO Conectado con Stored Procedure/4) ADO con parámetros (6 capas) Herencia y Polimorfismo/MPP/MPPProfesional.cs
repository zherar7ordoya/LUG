﻿using System;
using System.Collections.Generic;
using System.Collections;
using DAL;
using Abstraccion;
using BE;
using System.Data;

namespace MPP
{
    public class MPPProfesional:IGestor<BEProfesional>
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
            
            string Consulta = "Alta_JProfesional";
            parametros = new Dictionary<string, object>();
            parametros.Add("@TAmarilla", oBEProf.CantidadAmarillas);
            parametros.Add("@TRojas", oBEProf.CantidadRojas);
            parametros.Add("@GolesR", oBEProf.GolesRealizados);
            parametros.Add("@Nombre", oBEProf.Nombre);
            parametros.Add("@Apellido", oBEProf.Apellido);
            parametros.Add("@DNI", oBEProf.DNI);

            return oDatos.Escribir(Consulta, parametros); 
        }

        public BEProfesional ListarObjeto(BEProfesional oBEProf)
        {
            string Consulta = "Buscar_Jugador_DNI";
            parametros = new Dictionary<string, object>();
            parametros.Add("@DNI",oBEProf.DNI);
            DataTable Tabla = oDatos.Leer(Consulta,parametros);

            if (Tabla.Rows.Count > 0)

            {
                foreach (DataRow fila in Tabla.Rows)
                {
                    BEProfesional oBEP = new BEProfesional();
                    oBEP.Codigo = Convert.ToInt32(fila["Codigo"]);
                    oBEP.Nombre = fila["Nombre"].ToString();
                    oBEP.Apellido = fila["Apellido"].ToString();
                    oBEP.DNI = Convert.ToInt32(fila["DNI"]);
                    return oBEP;
                }

            }
            return null;
        }

        public bool Guardar_JugadorXEquipo(BEEquipo oBEEq, BEProfesional oBEEProf)
        { //para graabar en la tabla intermedia necesito el codigo de equipo y el codigo de jugador
          //como al jugador lo di de alta recien, necesito el codigo, por eso listo el obejto por DNI
          //si se grabo lo recupero y escribo en la tabla intermedia
          //sino devuelvo falso
            string Consulta;
            BEProfesional oBEProfBuscado = new BEProfesional();
            oBEProfBuscado = ListarObjeto(oBEEProf);
            if (oBEProfBuscado.Codigo != 0)
            {
                Consulta = "Alta_Jugador_Equipo";
                parametros = new Dictionary<string, object>();
                parametros.Add("@CodEquipo", oBEEq.Codigo);
                parametros.Add("@CodJugador", oBEProfBuscado.Codigo);
                return oDatos.Escribir(Consulta,parametros);
            }
            else
            {
                return false;
            }

        }

        public bool Eliminar(BEProfesional Objeto)
        {
            throw new NotImplementedException();
        }

        public List<BEProfesional> ListarTodo()
        {
            throw new NotImplementedException();
        }

 
    }
}
