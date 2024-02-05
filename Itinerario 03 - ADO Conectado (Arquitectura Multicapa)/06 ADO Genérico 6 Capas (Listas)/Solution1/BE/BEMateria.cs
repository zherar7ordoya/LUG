using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BEMateria: Entidad
    {
        #region PROPIEDADES
        public string Materia { get; set; }
        #endregion

        #region MÉTODOS
        public override string ToString()
        {
            return Codigo + " " + Materia;
        }
        #endregion
    }
}
