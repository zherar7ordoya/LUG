using BEL;

using PML;

using SVC;

using System;
using System.Collections.Generic;


namespace BLL
{
    public partial class ClienteBLL
    {
        #region VALIDACIONES SEMÁNTICAS
        
        private bool ValidarEdad(DateTime fechaNacimiento)
        {
            if (CalcularEdad(fechaNacimiento) < 18)
            {
                throw new Exception("El cliente debe ser mayor de edad");
            }
            if (CalcularEdad(fechaNacimiento) > 100)
            {
                throw new Exception("El cliente no puede ser mayor de 100 años");
            }
            return true;
        }


        private int CalcularEdad(DateTime fechaNacimiento)
        {
            int edad = DateTime.Now.Year - fechaNacimiento.Year;
            if (
                DateTime.Now.Month < fechaNacimiento.Month || 
                (DateTime.Now.Month == fechaNacimiento.Month && DateTime.Now.Day < fechaNacimiento.Day))
            {
                edad--;
            }
            return edad;
        }

        #endregion

        /// <summary>
        /// Simulador de login.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="clave"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool ValidarLogin(string email, string clave)
        {
            try
            {
                // Aquí, la manera de recuperar la información que podría usarse
                // para el login.
                List<Cliente> clientes = new ClientePML().Consultar();
                Cliente cliente = clientes.Find(c => c.Email == email);

                // ...pero se hará un "mock" de la consulta a la base de datos.

                // Simulo que recuperé la clave encriptada de la base de datos.
                string emailEncriptado = Seguridad.Encriptar(email);
                
                // Encripto la clave ingresada.
                string claveEncriptada = Seguridad.Encriptar(clave);

                // Sin desencriptar nada, comparo los valores encriptados.
                if (emailEncriptado != claveEncriptada)
                {
                    throw new Exception("La clave ingresada es incorrecta");
                }
                return true;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
    }
}
