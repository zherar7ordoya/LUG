using System;
using System.Collections.Generic;
using BE;
using DAL;
using System.Data;
using Abstraccion;

namespace MPP
{
    public class MPPLocalidad : IGestor<BELocalidad>
    {
        DatosDictionary oDatos;

        public MPPLocalidad()
        {
            oDatos = new DatosDictionary();
        }

        public List<BELocalidad> ListarTodo()
        {
            List<BELocalidad> listlocalidades = new List<BELocalidad>();
            DataTable Dt = oDatos.Leer("s_Localidad_ListarT", null);

            if (Dt.Rows.Count > 0)
            {
                foreach (DataRow Item in Dt.Rows)
                {
                    BELocalidad oLoca = new BELocalidad();
                    oLoca.Id = Convert.ToInt32(Item[0]);
                    oLoca.Descripcion = Item[1].ToString();
                    listlocalidades.Add(oLoca);
                }
                return listlocalidades;
            }
            else
            {
                return null;
            }
        }


        // Defino el Dictionary
        Dictionary<string, object> parametros;

        public bool Baja(BELocalidad oBELoc)
        {
            if (Existe_Localidad_Asociada(oBELoc) == false)
            {
                //como esta definido fuera de un bloque el AL uso el mismo que defini en Existe_Localidad_Asociada
                return oDatos.Escribir("s_Localidad_Borrar", parametros);
            }
            else
            {
                return false;
            }
        }


        //busco si existe alguna localidad asociada a un cliente
        public bool Existe_Localidad_Asociada(BELocalidad oBELoc)
        {
            // Instancio el Dictionary para pasar los parametros
            parametros = new Dictionary<string, object>
            {
                { "@IdLoc", oBELoc.Id }
            };
            return oDatos.LeerScalar("s_Localidad_Asociada", parametros);
        }

        public bool Guardar(BELocalidad Objeto)
        {
            throw new NotImplementedException();
        }

        public BELocalidad ListarObjeto(BELocalidad Objeto)
        {
            throw new NotImplementedException();
        }

    }
}


