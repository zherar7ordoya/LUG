using BEL;

using PML;

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

        // TODO => Se hace este método para hacer un login. No es parte del ABMC.
        //         Debería estar en la capa servicio.
        //         Pero, por ahora, lo dejo acá...
        //         Pero este método me parece que debería estar en la BLL ya que
        //         el login está intrínsecamente relacionado con la lógica del
        //         negocio y las reglas de acceso.
        public bool ConsultarCliente(string email, string clave)
        {
            try
            {
                List<Cliente> clientes = new ClientePML().Consultar();
                Cliente cliente = clientes.Find(c => c.Email == email);
                if (cliente == null)
                {
                    throw new Exception("El email ingresado no existe");
                }
                //if (cliente.Clave != clave)
                //{
                //    throw new Exception("La clave ingresada es incorrecta");
                //}
                return true;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
    }
}
