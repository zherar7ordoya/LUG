using BEL;

using System.Collections.Generic;
using System.Linq;

/* ************************************************************************** *\
La "Business Logic Layer" (BLL) es una capa fundamental en la arquitectura de
software que se encarga de gestionar la lógica de negocio de una aplicación. Su
función principal es coordinar y ejecutar las operaciones que van más allá de la
manipulación básica de datos, asegurando que estas operaciones cumplan con las
reglas y requisitos específicos del dominio de la aplicación en un sistema mixto
de datos distribuidos.
\* ************************************************************************** */

namespace BLL
{
    /// <summary>
    /// Estas consultas son parte de la lógica de negocio de la aplicación.
    /// Los métodos devuelven diccionarios pues es la estructura de datos que 
    /// mejor resume la información que se quiere mostrar en el dashboard (que
    /// resume la misma información de manera visual a través de los charts).
    /// </summary>
    public partial class RentaBLL
    {
        public Dictionary<string, int> VehiculosMasRentadosPorTipo()
        {
            List<Renta> rentados = Consultar();

            return rentados
                .GroupBy(x => x.Vehiculo.Tipo.ToString())
                .OrderByDescending(grupo => grupo.Count())
                .Take(2)
                .ToDictionary(grupo => grupo.Key, grupo => grupo.Count());
        }


        public Dictionary<string, decimal> VehiculosMasRentadosPorImporte()
        {
            List<Renta> rentados = Consultar();

            return rentados
                .OrderByDescending(renta => renta.Importe)
                .Take(3)
                .ToDictionary(renta => renta.Vehiculo.ToString(), renta => renta.Importe);
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


        public Dictionary<string, decimal> VehiculosMenosRentadosPorImporte()
        {
            List<Renta> rentados = Consultar();

            return rentados
                .OrderBy(renta => renta.Importe)
                .Take(3)
                .ToDictionary(renta => renta.Vehiculo.ToString(), renta => renta.Importe);
        }


        public Dictionary<string, decimal> TotalRecaudadoPorTipo()
        {
            List<Renta> rentados = Consultar();

            return rentados
                .GroupBy(x => x.Vehiculo.Tipo.ToString())
                .ToDictionary(grupo => grupo.Key, grupo => grupo.Sum(x => x.Importe));
        }

        // ...
    }
}
