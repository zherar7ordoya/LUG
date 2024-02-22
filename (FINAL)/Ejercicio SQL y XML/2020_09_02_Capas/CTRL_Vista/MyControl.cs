using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTRL_Vista
{
    class MyControl
    {
        object _puntero = null;
        public MyControl(string pNombre, object pPuntero) { Nombre = pNombre; _puntero = pPuntero; }
        public string Nombre { get; set; }
        public object Puntero { get { return _puntero; } }
    }
}
