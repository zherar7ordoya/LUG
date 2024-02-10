using ASL;
using BEL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public partial class RentaBLL
    {
        RentaASL rentaASL = new RentaASL();
        public List<Renta> ObtenerTodosVehiculosRentados()
        {
            List<Renta> rentados = rentaASL.Consultar();

            // Utilizar LINQ para eliminar duplicados basándose
            // en la propiedad Codigo del objeto Vehiculo
            List<Renta> unicos = rentados
                /* Agrupa rentas por código de vehículo */
                .GroupBy(x => x.Vehiculo.Codigo)
                /* Luego se usa SELECT para seleccionar el primer elemento de cada grupo */
                .Select(group => group.First())
                .ToList();

            return unicos;
        }

        public List<Renta> ObtenerVehiculosMasRentados()
        {
            List<Renta> todos = rentaASL.Consultar();
            List<Renta> masRentados = todos
                .GroupBy(x => x.Vehiculo.Codigo)
                .Select(group => group.First())
                .ToList();
            return masRentados;
        }

        public List<Renta> ObtenerVehiculosMenosRentados()
        {
            List<Renta> todos = rentaASL.Consultar();
            List<Renta> menosRentados = todos
                .GroupBy(x => x.Vehiculo.Codigo)
                .Select(group => group.Last())
                .ToList();
            return menosRentados;
        }

        public Dictionary<string, decimal> ObtenerTotalRecaudadoPorTipoDeVehiculo()
        {
            List<Renta> todos = rentaASL.Consultar();
            return todos
                .GroupBy(x => x.Vehiculo.Tipo)
                .ToDictionary(group => group.Key,
                              group => group.Sum(x => x.Importe)
                             );
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
