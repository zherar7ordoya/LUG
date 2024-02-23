using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCL
{
    public class Controlador
    {
        private readonly object puntero = null;
        public Controlador(string nombre, object puntero)
        {
            Nombre = nombre;
            this.puntero = puntero; 
        }
        public string Nombre { get; set; }
        public object Puntero
        {
            get { return puntero; } 
        }
    }
}
