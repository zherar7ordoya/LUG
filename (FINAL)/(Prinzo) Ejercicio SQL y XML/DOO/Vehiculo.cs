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

        // Método para obtener el costo diario basado en el modelo utilizando funciones hash
        public decimal ObtenerCostoDiarioPorModelo()
        {
            int valorNumerico = ObtenerValorNumerico(Modelo);
            // Puedes ajustar esta lógica según tus necesidades específicas.
            // Aquí se asume que el costo base es proporcional al valor numérico derivado del modelo.
            decimal costoBase = valorNumerico % 100; // Se toma módulo 100 para obtener un valor entre 0 y 99.
            return costoBase + 50; // Se agrega un costo base mínimo de 50.
        }

        // Función de hash para obtener un valor numérico de un modelo
        private int ObtenerValorNumerico(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                return Math.Abs(BitConverter.ToInt32(hashBytes, 0));
            }
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
