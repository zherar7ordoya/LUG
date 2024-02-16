using BEL;

using System.Collections.Generic;
using System.Linq;

namespace ASL
{
    public partial class RentaASL
    {
        public List<Renta> ObtenerTodosVehiculosRentados()
        {
            List<Renta> rentados = Consultar();

            // Eliminar duplicados basándose en la propiedad Codigo del objeto
            return rentados
                .GroupBy(x => x.Vehiculo.Codigo) // Agrupa rentas por código de vehículo
                .Select(group => group.First()) // SELECT para seleccionar el 1er elemento de cada grupo
                .ToList();
        }

        public List<Renta> ObtenerVehiculosMasRentados()
        {
            List<Renta> rentados = Consultar();

            return rentados
                .GroupBy(x => x.Vehiculo.Codigo)
                .Select(group => group.First())
                .ToList();
        }

        public List<Renta> ObtenerVehiculosMenosRentados()
        {
            List<Renta> rentados = Consultar();

            return rentados
                .GroupBy(x => x.Vehiculo.Codigo)
                .Select(group => group.Last())
                .ToList();
        }

        public Dictionary<VehiculoTipo, decimal> ObtenerTotalRecaudadoPorTipoDeVehiculo()
        {
            List<Renta> rentados = Consultar();

            return rentados
                .GroupBy(x => x.Vehiculo.Tipo)
                .ToDictionary(group => group.Key, group => group.Sum(x => x.Importe));
        }
    }
}
