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
    public class RentaMPP : IMapeado<Renta>
    {
        private readonly AccesoDatosSqlServer accesoDatosSqlServer = new AccesoDatosSqlServer();

        //||||||||||||||||||||||||||||||||||||||||||||||||||||| MÉTODOS DE CLASE

        public List<Renta> MapearDesdeSqlServer(string consulta)
        {
            List<Renta> listaRentas = new List<Renta>();
            DataTable tablaRentas = accesoDatosSqlServer.Leer(consulta, null);

            foreach (DataRow registro in tablaRentas.Rows)
            {
                Renta renta = new Renta
                {
                    Codigo = int.Parse(registro["Codigo"].ToString()),
                    Cliente = Tool.ObtenerClientePorCodigo(int.Parse(registro["Codigo_Cliente"].ToString())),
                    Vehiculo = Tool.ObtenerVehiculoPorCodigo(int.Parse(registro["Codigo_Vehiculo"].ToString())),
                    DiasRentados = int.Parse(registro["DiasRentados"].ToString()),
                    Importe = decimal.Parse(registro["Importe"].ToString())
                };
                listaRentas.Add(renta);
            }
            return listaRentas;
        }

        public List<Renta> MapearDesdeXmlArchivo(string archivo)
        {
            throw new NotImplementedException();
        }

        public bool MapearHaciaSqlServer(string consulta, Renta objeto)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@Codigo", objeto.Codigo },
                { "@Cliente", objeto.Cliente.Codigo },
                { "@Vehiculo", objeto.Vehiculo.Codigo },
                { "@Importe", objeto.Importe }
            };
            return accesoDatosSqlServer.Escribir(consulta, parametros);
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
        public bool MapearHaciaXmlArchivo(string archivo, List<Renta> objetos) => throw new NotImplementedException("Renta usa SQL Server");
    }
}
