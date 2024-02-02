using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;

namespace Reports
{
    public class Vehiculo
    {
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Patente { get; set; }

        public override string ToString()
        {
            return string.Format($"Tipo: {Tipo} - Marca: {Marca} - Modelo: {Modelo} - Patente: {Patente}");
        }
    }
}
