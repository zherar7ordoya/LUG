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
           
            string Consulta = "Alta_JPrincipiante";
            parametros = new Dictionary<string, object>();
            parametros.Add("@TAmarilla", oBEPrin.CantidadAmarillas);
            parametros.Add("@TRojas", oBEPrin.CantidadRojas);
            parametros.Add("@GolesR", oBEPrin.GolesRealizados);
            parametros.Add("@Rapado", oBEPrin.Rapado);
            parametros.Add("@Nombre", oBEPrin.Nombre);
            parametros.Add("@Apellido", oBEPrin.Apellido);
            parametros.Add("@DNI", oBEPrin.DNI);

            return oDatos.Escribir(Consulta, parametros);
        }

        public BEPrincipiante ListarObjeto(BEPrincipiante oBEprin)
        {
            string Consulta = "Buscar_Jugador_DNI";
            parametros = new Dictionary<string, object>();
            parametros.Add("@DNI", oBEprin.DNI);
            DataTable Tabla = oDatos.Leer(Consulta, parametros);

            if (Tabla.Rows.Count > 0)

            {
                foreach (DataRow fila in Tabla.Rows)
                {
                    BEPrincipiante oBEP = new BEPrincipiante();
                    oBEP.Codigo = Convert.ToInt32(fila["Codigo"]);
                    oBEP.Nombre = fila["Nombre"].ToString();
                    oBEP.Apellido = fila["Apellido"].ToString();
                    oBEP.DNI = Convert.ToInt32(fila["DNI"]);
                    return oBEP;
                }
               
            }
            return null;
        }

        public bool Guardar_JugadorXEquipo(BEEquipo oBEEq, BEPrincipiante oBEEPri)
        { //para graabar en la tabla intermedia necesito el codigo de equipo y el codigo de jugador
           //como al jugador lo di de alta recien, necesito el codigo, por eso listo el obejto por DNI
           //si se grabo lo recupero y escribo en la tabla intermedia
           //sino devuelvo falso
            string Consulta;
            BEPrincipiante oBEPriBuscado = new BEPrincipiante();
            oBEPriBuscado = ListarObjeto(oBEEPri);
            if (oBEPriBuscado.Codigo != 0)
            {  
                Consulta = "Alta_Jugador_Equipo";
                parametros = new Dictionary<string, object>();
                parametros.Add("@CodEquipo", oBEEq.Codigo);
                parametros.Add("@CodJugador", oBEPriBuscado.Codigo);
                return oDatos.Escribir(Consulta, parametros);
            }
            else
            {
                return false;
            }
            
        }
  
        public List<BEPrincipiante> ListarTodo()
        {
            throw new NotImplementedException();
        }

      
        public bool Eliminar(BEPrincipiante Objeto)
        {
            throw new NotImplementedException();
        }

    }
}
