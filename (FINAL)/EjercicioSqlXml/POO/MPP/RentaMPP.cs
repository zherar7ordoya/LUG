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
        /// <summary>
        /// Convierte un DataTable en una lista de objetos Renta.
        /// </summary>
        /// <param name="stored">
        /// TRUE si la consulta es un procedimiento almacenado.
        /// FALSE si la consulta es un comando de texto.
        /// </param>
        /// <param name="consulta">
        /// Nombre del procedimiento almacenado o comando de texto.
        /// </param>
        public List<Renta> MapearDesdeSql(bool stored, string consulta)
        {
            try
            {
                List<Renta> listaRentas = new List<Renta>();
                DataTable tablaRentas = new ConexionSql().Leer(stored, consulta, null);

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


        /// <summary>
        /// Convierte un objeto Renta en un diccionario de parámetros para un
        /// procedimiento almacenado o comando de texto.
        /// </summary>
        /// <param name="stored">
        /// TRUE si la consulta es un procedimiento almacenado.
        /// FALSE si la consulta es un comando de texto.
        /// </param>
        /// <param name="consulta">
        /// Nombre del procedimiento almacenado o comando de texto.
        /// </param>
        /// <param name="objeto">
        /// El objeto Renta a mapear.
        /// </param>
        public bool MapearHaciaSql(bool stored, string consulta, Renta objeto)
        {
            try
            {
                // Caso borrar:
                // Solo necesito el código, de otro modo,  el procedimiento
                // almacenado rechaza los demás parámetros.
                Dictionary<string, object> parametros = new Dictionary<string, object>
                {
                    { "@Codigo", objeto.Codigo }
                };

                // Cuando no es un borrado, apelo a los valores "default" para
                // diferenciar borrado de no-borrado.
                if (objeto.Cliente != null) parametros.Add("@Codigo_Cliente", objeto.Cliente.Codigo);
                if (objeto.Vehiculo != null) parametros.Add("@Codigo_Vehiculo", objeto.Vehiculo.Codigo);
                if (objeto.DiasRentados > 0) parametros.Add("@DiasRentados", objeto.DiasRentados);
                if (objeto.Importe > 0) parametros.Add("@Importe", objeto.Importe);

                return new ConexionSql().Escribir(stored, consulta, parametros);
            }
            catch (SqlException ex) { throw new Exception(ex.Message); }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
