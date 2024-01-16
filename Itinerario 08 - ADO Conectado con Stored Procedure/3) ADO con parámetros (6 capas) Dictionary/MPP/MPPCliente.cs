using System;
using System.Collections.Generic;
using BE;
using DAL;
using System.Data;
using Abstraccion;

namespace MPP
{
    public class MPPCliente : IGestor<BECliente>
    {
        //defino el objeto datos
        DatosDictionary oDatos;
        //Hashtable Hdatos;
        Dictionary<string, object> parametros;

        //instancio los objeto en el constructor dado q datos lo voy a usar siempre 
        public MPPCliente()
        {
            oDatos = new DatosDictionary();
        }

        public List<BECliente> ListarTodo()
        {
            List<BECliente> LClientes = new List<BECliente>();

            DataTable tabla = oDatos.Leer("s_Cliente_ListarT", null);

            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow Item in tabla.Rows)
                {
                    BECliente oCli = new BECliente
                    {
                        Id = Convert.ToInt32(Item["IdCliente"]),
                        Nombre = Item["Nombre"].ToString(),
                        Apellido = Item["Apellido"].ToString(),
                        DNI = Convert.ToInt32(Item["DNI"])
                    };
                    BELocalidad oLoc = new BELocalidad
                    {
                        Id = Convert.ToInt32(Item["IdLocalidad"]),
                        Descripcion = Item["Localidad"].ToString()
                    };
                    oCli.Localidad = oLoc;
                    oCli.Activo = Convert.ToBoolean(Item["Activo"]);
                    LClientes.Add(oCli);
                }
                return LClientes;
            }
            else
            {
                return null;
            }
        }

        public bool Guardar(BECliente oBECliente)
        {
            //Hdatos = new Hashtable();
            parametros = new Dictionary<string, object>();
            string consulta = "s_Cliente_Crear";

            if (oBECliente.Id != 0)
            {
                //Hdatos.Add("@IdCliente", oBECliente.Id);
                parametros.Add("@IdCliente", oBECliente.Id);
                consulta = "s_Cliente_Modificar";
            }

            //Hdatos.Add("@Nombre", oBECliente.Nombre);
            //Hdatos.Add("@Apellido", oBECliente.Apellido);
            //Hdatos.Add("@DNI", oBECliente.DNI);
            //Hdatos.Add("@IdLocalidad", oBECliente.Localidad.Id);
            //Hdatos.Add("@Activo", true);
            parametros.Add("@Nombre", oBECliente.Nombre);
            parametros.Add("@Apellido", oBECliente.Apellido);
            parametros.Add("@DNI", oBECliente.DNI);
            parametros.Add("@IdLocalidad", oBECliente.Localidad.Id);
            parametros.Add("@Activo", true);

            if (VerificarExisteCLientexDNI(oBECliente) == false)
            {
                //return oDatos.Escribir(Consulta, Hdatos);
                return oDatos.Escribir(consulta, parametros);
            }
            else
            {
                return false;
            }
        }

        bool VerificarExisteCLientexDNI(BECliente oBECli)
        {
            //Hashtable Hdatos2 = new Hashtable();
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            //SqlParameter Param3 = new SqlParameter();

            // Verifico para los cliente nuevos
            if (oBECli.Id == 0)
            {
                parametros.Add("@DNI", oBECli.DNI);
                return oDatos.LeerScalar("s_Cliente_Existe_DNI", parametros);
            }
            else
            {
                return false;
            }
        }


        public bool Baja(BECliente oBECliente)
        {
            //Hdatos = new Hashtable();
            parametros = new Dictionary<string, object>();
            string consulta = "s_Cliente_Baja";
            parametros.Add("@IdCliente", oBECliente.Id);
            return oDatos.Escribir(consulta, parametros);
        }

        public BECliente ListarObjeto(BECliente Objeto)
        {
            throw new NotImplementedException();
        }

        public List<BECliente> BuscarClienteXApellido(BECliente oBECliente)
        {
            List<BECliente> LClientes = new List<BECliente>();
            
            parametros = new Dictionary<string, object>
            {
                { "@Apellido", oBECliente.Apellido }
            };

            DataTable tabla = oDatos.Leer("s_Cliente_BusquedaXApellido", parametros);

            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow Item in tabla.Rows)
                {
                    BECliente oCli = new BECliente
                    {
                        Id = Convert.ToInt32(Item["IdCliente"]),
                        Nombre = Item["Nombre"].ToString(),
                        Apellido = Item["Apellido"].ToString(),
                        DNI = Convert.ToInt32(Item["DNI"])
                    };
                    BELocalidad oLoc = new BELocalidad
                    {
                        Id = Convert.ToInt32(Item["IdLocalidad"]),
                        Descripcion = Item["Localidad"].ToString()
                    };
                    oCli.Localidad = oLoc;
                    oCli.Activo = Convert.ToBoolean(Item["Activo"]);
                    LClientes.Add(oCli);
                }
                return LClientes;
            }
            else
            {
                return null;
            }
        }
    }
}
