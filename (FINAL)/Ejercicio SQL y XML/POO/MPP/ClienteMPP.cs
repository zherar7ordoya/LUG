using ABS;

using BEL;

using DAL;

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

/* ************************************************************************** *\
La capa de mapeo tiene la responsabilidad exclusiva de facilitar la conversión
entre las estructuras de datos específicas de la DAL y los tipos de datos
nativos de C#. Su función principal es realizar el mapeado de datos, permitiendo
una comunicación efectiva entre la capa de acceso a datos (DAL) y las capas
superiores del sistema. Esta capa se encarga de convertir la información entre
las representaciones de datos utilizadas por la DAL y las estructuras de datos
de C#, asegurando así una transición fluida entre ambas sin agregar
responsabilidades adicionales. Al mantener un enfoque claro en el mapeo de
datos, esta capa sigue los principios SOLID, evitando la sobrecarga de
responsabilidades y contribuyendo a la claridad y mantenibilidad del sistema de
persistencia mixto (SQL y XML).
\* ************************************************************************** */

namespace MPP
{
    public class ClienteMPP : IMapeadoSql<Cliente>
    {
        public List<Cliente> MapearDesdeSql(string consulta)
        {
            try
            {
                List<Cliente> listaClientes = new List<Cliente>();
                DataTable tablaClientes = new ConexionSql().Leer(consulta, null);

                foreach (DataRow registro in tablaClientes.Rows)
                {
                    Cliente cliente = new Cliente
                    {
                        Codigo = int.Parse(registro["Codigo"].ToString()),
                        Nombre = registro["Nombre"].ToString(),
                        Apellido = registro["Apellido"].ToString(),
                        DNI = int.Parse(registro["DNI"].ToString()),
                        FechaNacimiento = DateTime.Parse(registro["FechaNacimiento"].ToString()),
                        Email = registro["Email"].ToString(),
                        VehiculosRentados = new List<Vehiculo>()
                    };
                    listaClientes.Add(cliente);
                }
                return listaClientes;
            }
            catch (SqlException ex) { throw new Exception(ex.Message); }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }


        public bool MapearHaciaSql(string consulta, Cliente objeto)
        {
            try
            {
                // A "Código" siempre lo voy a necesitar
                Dictionary<string, object> parametros = new Dictionary<string, object>
                {
                    { "@Codigo", objeto.Codigo }
                };

                // Pero el resto de los campos son opcionales (caso "Borrar")
                if (!string.IsNullOrEmpty(objeto.Nombre))
                {
                    parametros.Add("@Nombre", objeto.Nombre);
                }

                if (!string.IsNullOrEmpty(objeto.Apellido))
                {
                    parametros.Add("@Apellido", objeto.Apellido);
                }

                if (objeto.DNI > 0)
                {
                    parametros.Add("@DNI", objeto.DNI);
                }

                if (objeto.FechaNacimiento != DateTime.MinValue)
                {
                    parametros.Add("@FechaNacimiento", objeto.FechaNacimiento);
                }

                if (!string.IsNullOrEmpty(objeto.Email))
                {
                    parametros.Add("@Email", objeto.Email);
                }

                return new ConexionSql().Escribir(consulta, parametros);
            }
            catch (SqlException ex) { throw new Exception(ex.Message); }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
