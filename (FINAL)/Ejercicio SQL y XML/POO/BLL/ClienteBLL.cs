using System;


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
    }
}
