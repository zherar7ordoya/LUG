using BEL;
using System;
using System.Collections.Generic;
using System.Linq;


namespace BLL
{
    /// <summary>
    /// Nota 1:
    /// Estas consultas son parte de la lógica de negocio de la aplicación.
    /// Los métodos devuelven diccionarios pues es la estructura de datos que 
    /// mejor resume la información que se quiere mostrar en el dashboard (que
    /// resume la misma información de manera visual a través de los charts).
    /// 
    /// Nota 2:
    /// Obviamente, no es posible hacer esta consulta mediante procedimientos
    /// almacenados pues el repositorio de datos es mixto (XML y SQL Server):
    /// parte de la información se encuentra en un archivo XML y otra parte en
    /// SQL Server.
    /// </summary>
    public partial class RentaBLL
    {
        // NOTA: No hace falta validar ni cantidad de días rentados ni importe
        //       de renta pues ya lo hace la GUI (con un control de tipo numérico
        //       para los días y un control de usuario para el importe).
        //*------------------------------------------------------------------*\\

        public Dictionary<string, int> VehiculosMasRentadosPorTipo()
        {
            List<Renta> rentados = Consultar();

            return rentados
                .GroupBy(x => x.Vehiculo.Tipo.ToString())
                .OrderByDescending(grupo => grupo.Count())
                .Take(2)
                .ToDictionary(grupo => grupo.Key, grupo => grupo.Count());
        }


        /**
         * Este fue mañoso... Al ir ingresando datos se vio la situación de que 
         * el diccionario no soporta valores duplicados. Pero es que un vehículo
         * puede ser rentado más de una vez... (véase nota en la BEL al respecto).
         * Este código utiliza un bucle para recorrer las rentas y construir el
         * diccionario sumando los importes para los vehículos que ya están en
         * el diccionario y agregando nuevos vehículos con sus importes si aún
         * no están presentes. Luego, ordena por importe y toma los tres primeros
         * vehículos con mayores ingresos.
         */
        public Dictionary<string, decimal> VehiculosMasRentadosPorImporte()
        {
            try
            {
                List<Renta> rentados = Consultar();

                var ingresos = new Dictionary<string, decimal>();

                foreach (var renta in rentados)
                {
                    // Ver el método ToString() en la clase Vehiculo
                    string vehiculoKey = renta.Vehiculo.ToString();

                    // Vehículo existe
                    if (ingresos.ContainsKey(vehiculoKey)) ingresos[vehiculoKey] += renta.Importe;

                    // Vehículo no existe
                    else ingresos.Add(vehiculoKey, renta.Importe);
                }

                var resultado = ingresos
                    .OrderByDescending(item => item.Value)
                    .Take(3)
                    .ToDictionary(item => item.Key, item => item.Value);

                return resultado;
            }
            catch (Exception)
            {
                throw new Exception("Error al consultar los vehículos más rentados por importe");
            }
        }


        public Dictionary<string, int> VehiculosMenosRentadosPorTipo()
        {
            List<Renta> rentados = Consultar();

            return rentados
                .GroupBy(x => x.Vehiculo.Tipo.ToString())
                .OrderBy(grupo => grupo.Count())
                .Take(2)
                .ToDictionary(grupo => grupo.Key, grupo => grupo.Count());
        }


         // Ver nota para el método VehiculosMasRentadosPorImporte().
        public Dictionary<string, decimal> VehiculosMenosRentadosPorImporte()
        {
            try
            {
                List<Renta> rentados = Consultar();

                var ingresos = new Dictionary<string, decimal>();

                foreach (var renta in rentados)
                {
                    string vehiculoKey = renta.Vehiculo.ToString();
                    if (ingresos.ContainsKey(vehiculoKey)) ingresos[vehiculoKey] += renta.Importe;
                    else ingresos.Add(vehiculoKey, renta.Importe);
                }

                var resultado = ingresos
                    .OrderBy(item => item.Value)
                    .Take(3)
                    .ToDictionary(item => item.Key, item => item.Value);

                return resultado;
            }
            catch (Exception)
            {
                throw new Exception("Error al consultar los vehículos menos rentados por importe");
            }
        }


        public Dictionary<string, decimal> TotalRecaudadoPorTipo()
        {
            List<Renta> rentados = Consultar();

            return rentados
                .GroupBy(x => x.Vehiculo.Tipo.ToString())
                .ToDictionary(grupo => grupo.Key, grupo => grupo.Sum(x => x.Importe));
        }

        //\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\\
    }
}
