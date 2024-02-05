using ABS;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public abstract class Entidad : IEntidad
    {
        public int Codigo { get; set; }
    }
}
