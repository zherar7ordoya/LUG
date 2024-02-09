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
            return new List<Renta>();
        }

        public List<Renta> ObtenerVehiculosMenosRentados()
        {
            // Lógica para obtener los vehículos menos rentados
            // Puedes ajustar esta lógica según tus requerimientos específicos.
            return new List<Renta>();
        }

        public decimal ObtenerRecaudacionPorTipo(string tipo)
        {
            // Lógica para obtener el monto total recaudado por tipo de transporte
            // Puedes ajustar esta lógica según tus requerimientos específicos.
            return 0;
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
