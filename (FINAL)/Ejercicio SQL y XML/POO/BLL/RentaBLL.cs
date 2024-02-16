using ASL;

using BEL;

using System.Collections.Generic;

namespace BLL
{
    public partial class RentaBLL
    {
        public List<Renta> ObtenerTodosVehiculosRentados()
        {
            return new RentaASL().ObtenerTodosVehiculosRentados();
        }

        public List<Renta> ObtenerVehiculosMasRentados()
        {
            return new RentaASL().ObtenerVehiculosMasRentados();
        }

        public List<Renta> ObtenerVehiculosMenosRentados()
        {
            return new RentaASL().ObtenerVehiculosMenosRentados();
        }

        public Dictionary<VehiculoTipo, decimal> ObtenerTotalRecaudadoPorTipoDeVehiculo()
        {
           return new RentaASL().ObtenerTotalRecaudadoPorTipoDeVehiculo();
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
