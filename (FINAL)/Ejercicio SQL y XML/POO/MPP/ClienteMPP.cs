using ABS;

using BEL;

using DAL;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPP
{
    public class ClienteMPP : IMapeado<Cliente>
    {
        private readonly AccesoDatosSqlServer accesoDatosSqlServer = new AccesoDatosSqlServer();

        //||||||||||||||||||||||||||||||||||||||||||||||||||||| METÓDOS DE CLASE

        public List<Cliente> MapearDesdeSqlServer()
        {
            List<Cliente> listaClientes = new List<Cliente>();
            DataTable tablaClientes = accesoDatosSqlServer.Leer("ClientesConsultar", null);

            foreach(DataRow registro in tablaClientes.Rows)
            {
                Cliente cliente = new Cliente
                {
                    Codigo = int.Parse(registro["Codigo"].ToString()),
                    Nombre = registro["Nombre"].ToString(),
                    Apellido = registro["Apellido"].ToString(),
                    DNI = int.Parse(registro["DNI"].ToString()),
                    FechaNacimiento = DateTime.Parse(registro["FechaNacimiento"].ToString()),
                    Email = registro["Email"].ToString(),
                    VehiculoRentado = Tool.ObtenerVehiculoPorCodigo(int.Parse(registro["Codigo_VehiculoRentado"].ToString()))
                };
                listaClientes.Add(cliente);
            }
            return listaClientes;
        }


        public bool MapearHaciaSqlServer(string consulta, Cliente objeto)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@Codigo", objeto.Codigo },
                { "@Nombre", objeto.Nombre },
                { "@Apellido", objeto.Apellido },
                { "@DNI", objeto.DNI },
                { "@FechaNacimiento", objeto.FechaNacimiento },
                { "@Email", objeto.Email },
                { "@Codigo_VehiculoRentado", objeto.VehiculoRentado.Codigo }
            };
            return accesoDatosSqlServer.Escribir(consulta, parametros);
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
        public List<Cliente> MapearDesdeXmlArchivo() => throw new NotImplementedException("Cliente usa SQL Server");
        public bool MapearHaciaXmlArchivo(List<Cliente> entidades) => throw new NotImplementedException("Cliente usa SQL Server");
    }
}
