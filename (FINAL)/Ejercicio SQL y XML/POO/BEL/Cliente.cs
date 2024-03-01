using System;
using System.Collections.Generic;


namespace BEL
{
    public class Cliente : Entidad
    {
        public Cliente()
        {
            // 🅱🆁🅴🅰🅺🅸🅽🅶 🅱🅰🅳
        }
        public Cliente
            (
            int codigo,
            string nombre,
            string apellido,
            int dni,
            DateTime fechaNacimiento,
            string email,
            List<Vehiculo> vehiculosRentados
            )
        {
            Codigo = codigo;
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            FechaNacimiento = fechaNacimiento;
            Email = email;
            VehiculosRentados = vehiculosRentados;
        }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Email { get; set; }
        public List<Vehiculo> VehiculosRentados { get; set; }

        public override string ToString()
        {
            return $"{Nombre} {Apellido}";
        }
    }
}
