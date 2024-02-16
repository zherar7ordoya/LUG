using BEL;

using System.Collections.Generic;

namespace ASL
{
    public partial class VehiculoASL
    {
        public bool SinAsignar(Vehiculo objeto)
        {
            List<Renta> rentas = new RentaASL().Consultar();
            foreach (Renta renta in rentas)
            {
                if (renta.Vehiculo.Codigo == objeto.Codigo)
                {
                    throw new System.Exception("El vehículo ya está asignado a una renta.");
                }
            }
            return true;
        }
    }
}
