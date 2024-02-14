using ABS;

using BEL;

using DAL;

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace MPP
{
    public class RentaMPP : IMapeadoSql<Renta>
    {
        public List<Renta> MapearDesdeSql(string consulta)
        {
            try
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
            catch (SqlException ex) { throw new Exception(ex.Message); }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public bool MapearHaciaSql(string consulta, Renta objeto)
        {
            try
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
            catch (SqlException ex) { throw new Exception(ex.Message); }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
