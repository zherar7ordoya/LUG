using ABS;

using BEL;

using DAL;

using System;
using System.Collections.Generic;
using System.Data;

namespace MPP
{
    public class RentaMPP : IMapeadoSql<Renta>
    {
        public List<Renta> MapearDesdeSql(string consulta)
        {
            List<Renta> listaRentas = new List<Renta>();
            DataTable tablaRentas = new ConexionSql().Leer(consulta, null);

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

        public bool MapearHaciaSql(string consulta, Renta objeto)
        {
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@Codigo", objeto.Codigo }
            };

            if (objeto.Cliente != null)
            {
                parametros.Add("@Cliente", objeto.Cliente.Codigo);
            }

            if (objeto.Vehiculo != null)
            {
                parametros.Add("@Vehiculo", objeto.Vehiculo.Codigo);
            }

            if (objeto.Importe > 0)
            {
                parametros.Add("@Importe", objeto.Importe);
            }

            return new ConexionSql().Escribir(consulta, parametros);
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
