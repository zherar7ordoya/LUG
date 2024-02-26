using ABS;
using BEL;
using PML;
using System.Collections.Generic;


namespace BLL
{
    /// <summary>
    /// En lo que refiere a ABMC, la clase VehiculoBLL es la encargada de hacer
    /// la validación semántica de los datos antes de enviarlos a la capa PML.
    /// </summary>
    public partial class VehiculoBLL : IABMC<Vehiculo>
    {
        public bool Agregar(Vehiculo objeto)
        {
            return new VehiculoPML().Agregar(objeto);
        }

        public bool Borrar(Vehiculo objeto)
        {
            return new VehiculoPML().Borrar(objeto);
        }

        public bool Modificar(Vehiculo objeto)
        {
            return new VehiculoPML().Modificar(objeto);
        }

        public List<Vehiculo> Consultar()
        {
            return new VehiculoPML().Consultar();
        }
    }
}
