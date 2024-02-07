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
        private readonly VehiculoMPP vehiculoMPP = new VehiculoMPP();

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||| HERRAMIENTAS

        private Vehiculo ObtenerVehiculoPorCodigo(int codigo)
        {
            List<Vehiculo> vehiculos = vehiculoMPP.MapearDesdeXmlArchivo();
            return vehiculos.Find(vehiculo => vehiculo.Codigo == codigo);
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||| METÓDOS DE CLASE
        public List<Cliente> MapearDesdeSqlServer()
        {
            DataTable clientesTabla = accesoDatosSqlServer.Leer("ClientesConsultar", null);
            List<Cliente> clientesLista = new List<Cliente>();

            foreach(DataRow registro in clientesTabla.Rows)
            {
                Cliente cliente = new Cliente
                {
                    Codigo = int.Parse(registro["Codigo"].ToString()),
                    Nombre = registro["Nombre"].ToString(),
                    Apellido = registro["Apellido"].ToString(),
                    DNI = int.Parse(registro["DNI"].ToString()),
                    FechaNacimiento = DateTime.Parse(registro["FechaNacimiento"].ToString()),
                    Email = registro["Email"].ToString(),
                    VehiculoRentado = ObtenerVehiculoPorCodigo(int.Parse(registro["Codigo_VehiculoRentado"].ToString()))
                };
                clientesLista.Add(cliente);
            }
            return clientesLista;
        }

        

        public bool MapearHaciaSqlServer(List<Cliente> entidades)
        {
            throw new NotImplementedException();
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
        public List<Cliente> MapearDesdeXmlArchivo() => throw new NotImplementedException("Cliente usa SQL Server");
        public bool MapearHaciaXmlArchivo(List<Cliente> entidades) => throw new NotImplementedException("Cliente usa SQL Server");
    }
}
