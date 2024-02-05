using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BELocalidad: Entidad
    {
        #region PROPIEDADES
        public string Localidad { get; set; }
        #endregion

        #region MÉTODOS
        public override string ToString()
        {
            return Codigo + " " + Localidad;
        }
        #endregion

    }
}
