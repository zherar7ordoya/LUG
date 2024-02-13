using ABS;

using BEL;

using DAL;

using System;
using System.Collections.Generic;
using System.Data;

namespace MPP
{
    public class ClienteMPP : IMapeadoSql<Cliente>
    {
        public List<Cliente> MapearDesdeSql(string consulta)
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


        public bool MapearHaciaSql(string consulta, Cliente objeto)
        {
            // El código siempre lo voy a necesitar
            Dictionary<string, object> parametros = new Dictionary<string, object>
            {
                { "@Codigo", objeto.Codigo }
            };

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

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
