using BEL;

using PML;

using SVC;

using System;
using System.Collections.Generic;

namespace BLL
{
    public class LoginBLL
    {
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
                // Aquí, la manera de recuperar la información para el login.
                List<Cliente> clientes = new ClientePML().Consultar();
                Cliente cliente = clientes.Find(c => c.Email == email);

                /*** ...pero se trabajará con un "mock"  ***/

                // Simulo que recuperé la clave encriptada de la base de datos.
                string emailEncriptado = Seguridad.Encriptar(email);

                // Encripto la clave ingresada.
                string claveEncriptada = Seguridad.Encriptar(clave);

                // Sin desencriptar nada: comparo los valores encriptados.
                if (emailEncriptado != claveEncriptada) return false;

                return true;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
    }
}
