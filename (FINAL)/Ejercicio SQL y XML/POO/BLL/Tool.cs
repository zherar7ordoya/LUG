using ASL;

using BEL;

using System;
using System.Collections.Generic;

namespace BLL
{
    public static class Tool
    {
        public static bool SinAsignar(Vehiculo objeto)
        {
            List<Renta> rentas = new RentaASL().Consultar();
            foreach (Renta renta in rentas)
            {
                if (renta.Vehiculo.Codigo == objeto.Codigo)
                {
                    throw new Exception("El vehículo ya está asignado a una renta.");
                }
            }
            return true;
        }
    }
}
