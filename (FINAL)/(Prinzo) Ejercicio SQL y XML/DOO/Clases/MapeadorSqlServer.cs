using System;
using System.Collections.Generic;
using System.Collections;
using BE;
using Abstraccion;
using DAL;
using System.Data;

namespace MPP
{
    public class MPPTecnico : IGestor<BETecnico>
    {
        readonly AccesoDatos oDatos;
        readonly Dictionary<string, object> parametros;

        public MPPTecnico()
        {
            oDatos = new AccesoDatos();
            parametros = new Dictionary<string, object>();
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

        public List<BETecnico> ListarTodo()
        {
            List<BETecnico> listaTecnicos = new List<BETecnico>();
            string consulta = "Listar_Tecnicos";
            DataTable Tabla = oDatos.Leer(consulta, null);

            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in Tabla.Rows)
                {
                    BETecnico oBETec = new BETecnico
                    {
                        Codigo = Convert.ToInt32(fila[0]),
                        Nombre = fila[1].ToString(),
                        Apellido = fila["Apellido"].ToString(),
                        DNI = Convert.ToInt32(fila["DNI"])
                    };
                    listaTecnicos.Add(oBETec);
                }
            }
            return listaTecnicos;
        }


        public bool Guardar(BETecnico oBETec)
        {
            string consulta = "Modificar_Tecnico";
            parametros.Add("@Cod", oBETec.Codigo);

            // Actualizo el campo "Estado" cuando se asigna un técnico a un equipo
            // para que ya no esté disponible para otro equipo.
            parametros.Add("@Estado", true);

            return oDatos.Escribir(consulta, parametros);
        }


        public bool Eliminar(BETecnico Objeto)
        {
            throw new NotImplementedException();
        }


        public BETecnico ListarObjeto(BETecnico Objeto)
        {
            throw new NotImplementedException();
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

    }
}
