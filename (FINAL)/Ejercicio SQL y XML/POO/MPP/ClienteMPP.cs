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

        public List<Cliente> MapearDesdeSqlServer(string consulta)
        {
            List<Cliente> listaClientes = new List<Cliente>();
            DataTable tablaClientes = accesoDatosSqlServer.Leer(consulta, null);

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
                    VehiculosRentados = Tool.ObtenerVehiculoPorCodigo(int.Parse(registro["Codigo_VehiculoRentado"].ToString()))
                };
                listaClientes.Add(cliente);
            }
            return listaClientes;
        }

        public List<Cliente> MapearDesdeXmlArchivo(string archivo)
        {
            throw new NotImplementedException();
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
                { "@Codigo_VehiculoRentado", objeto.VehiculosRentados.Codigo }
            };
            return accesoDatosSqlServer.Escribir(consulta, parametros);
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
        public bool MapearHaciaXmlArchivo(string archivo, List<Cliente> objetos) => throw new NotImplementedException("Cliente usa SQL Server");
    }
}
