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
                    parametros.Add("@Codigo_Cliente", objeto.Cliente.Codigo);
                }

                if (objeto.Vehiculo != null)
                {
                    parametros.Add("@Codigo_Vehiculo", objeto.Vehiculo.Codigo);
                }

                if (objeto.DiasRentados > 0) // Dias rentados no puede ser negativo ni cero
                {
                    parametros.Add("@DiasRentados", objeto.DiasRentados);
                }

                if (objeto.Importe > 0) // Importe no puede ser negativo, puede ser cero
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
