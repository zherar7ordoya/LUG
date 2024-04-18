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
        // Si bien el enunciado pide "el vehículo rentado", se optó por una
        // lista para trabajar con una estructura a manera de historial dado que
        // un cliente puede rentar más de un vehículo a lo largo del tiempo (y
        // porque no se pidió fecha de renta, que en un caso u otro, hubiera
        // sido necesaria).
        public List<Vehiculo> VehiculosRentados { get; set; }

        public override string ToString()
        {
            return $"{Nombre} {Apellido}";
        }
    }
}
