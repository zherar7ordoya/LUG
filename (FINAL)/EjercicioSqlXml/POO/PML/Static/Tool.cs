using BEL;

using System;
using System.Collections.Generic;

namespace PML
{
    public static class Tool
    {
        //||||||||||||||||||||||||||||||||||||||||||||||||| VALIDACIONES LÓGICAS

        public static bool ClienteSinAsignar(Cliente objeto)
        {
            List<Renta> rentas = new RentaPML().Consultar();
            foreach (Renta renta in rentas)
            {
                if (renta.Cliente.Codigo == objeto.Codigo) throw new Exception("El cliente ya está asignado a una renta.");
            }
            return true;
        }


        public static bool VehiculoSinAsignar(Vehiculo objeto)
        {
            List<Renta> rentas = new RentaPML().Consultar();
            foreach (Renta renta in rentas)
            {
                if (renta.Vehiculo.Codigo == objeto.Codigo) throw new Exception("El vehículo ya está asignado a una renta.");
            }
            return true;
        }
    }

    //\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\\
}
