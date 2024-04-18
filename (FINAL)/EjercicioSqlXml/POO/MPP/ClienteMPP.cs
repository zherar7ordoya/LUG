using ABS;
using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// ¿Por qué la capa de mapeo de datos (MPP) está tan cerca de la DAL? Porque no
/// olvidemos que PML (la capa gestora de persistencia, encima de la MPP), aún
/// maneja operaciones de lectura y escritura. ¿No hubiera sido mejor que la MPP
/// estuviera arriba de la PML, y que la PML estuviera arriba de la DAL?
/// Se hizo así para deshacerse lo antes posible de las estructuras de datos que
/// maneja la DAL (DataTable y XElement) y convertirlas en objetos de negocio lo
/// antes posible. La PML, así, puede realizar sus operaciones con objetos de
/// negocio en lugar de estructuras de datos que solo tienen sentido en la DAL 
/// ya que las estructuras de datos devueltas por los repositorios de datos no
/// coinciden directamente con las estructuras de los objetos de negocio.
/// Por esa razón es necesaria, lo antes posible, la conversión de estructuras.
/// </summary>
namespace MPP
{
    public class ClienteMPP : IMapeadoSql<Cliente>
    {
        /// <summary>
        /// Convierte un DataTable en una lista de objetos Cliente.
        /// </summary>
        /// <param name="stored">
        /// TRUE si la consulta es un procedimiento almacenado.
        /// FALSE si la consulta es un comando de texto.
        /// </param>
        /// <param name="consulta">
        /// Nombre del procedimiento almacenado o comando de texto.
        /// </param>
        public List<Cliente> MapearDesdeSql(bool stored, string consulta)
        {
            try
            {
                List<Cliente> listaClientes = new List<Cliente>();
                DataTable tablaClientes = new ConexionSql().Leer(stored, consulta, null);

                foreach (DataRow registro in tablaClientes.Rows)
                {
                    // Si esto no es mapeo...
                    Cliente cliente = new Cliente
                    {
                        Codigo = int.Parse(registro["Codigo"].ToString()),
                        Nombre = registro["Nombre"].ToString(),
                        Apellido = registro["Apellido"].ToString(),
                        DNI = int.Parse(registro["DNI"].ToString()),
                        FechaNacimiento = DateTime.Parse(registro["FechaNacimiento"].ToString()),
                        Email = registro["Email"].ToString(),
                        // Esto es conceptual: el objeto Cliente tiene una lista
                        // de Vehiculos, pero la tabla de la base de datos no
                        // tiene una lista sino una relación con Vehículo a
                        // través de la tabla Rentas.
                        VehiculosRentados = new List<Vehiculo>()
                    };
                    listaClientes.Add(cliente);
                }
                return listaClientes;
            }
            catch (SqlException ex) { throw new Exception(ex.Message); }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }


        /// <summary>
        /// Convierte un objeto Cliente en un comando SQL.
        /// </summary>
        /// <param name="stored">
        /// TRUE si la consulta es un procedimiento almacenado.
        /// FALSE si la consulta es un comando de texto.
        /// </param>
        /// <param name="consulta">
        /// Nombre del procedimiento almacenado o comando de texto.
        /// </param>
        /// <param name="objeto">
        /// El objeto Cliente a mapear.
        /// </param>
        public bool MapearHaciaSql(bool stored, string consulta, Cliente objeto)
        {
            // Interesante: en esta instancia, el mapeo es de los parámetros de
            //              la consulta.
            try
            {
                // A "Código" siempre lo voy a necesitar...
                Dictionary<string, object> parametros = new Dictionary<string, object>
                {
                    { "@Codigo", objeto.Codigo }
                };

                // ...pero el resto de los campos son opcionales (caso "Borrar")
                if (!string.IsNullOrEmpty(objeto.Nombre)) parametros.Add("@Nombre", objeto.Nombre);
                if (!string.IsNullOrEmpty(objeto.Apellido)) parametros.Add("@Apellido", objeto.Apellido);
                if (objeto.DNI > 0) parametros.Add("@DNI", objeto.DNI);
                if (objeto.FechaNacimiento != DateTime.MinValue) parametros.Add("@FechaNacimiento", objeto.FechaNacimiento);
                if (!string.IsNullOrEmpty(objeto.Email)) parametros.Add("@Email", objeto.Email);

                // ¿Y Vehículos Rentados? La tabla de la base de datos no tiene
                // una lista sino una relación con Vehículo a través de la tabla
                // Rentas. No se puede mapear directamente.

                return new ConexionSql().Escribir(stored, consulta, parametros);
            }
            catch (SqlException ex) { throw new Exception(ex.Message); }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        //\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\\
    }
}
