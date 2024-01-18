using System;

namespace BE
{
    public class BETecnico : Entidad
    {
        public BETecnico() { }
        public BETecnico(string nombre, string apellido, int dni)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
        }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public bool Estado { get; set; }

        public override string ToString()
        {
            return $"{Nombre} {Apellido} {DNI}";
        }

    }
}
