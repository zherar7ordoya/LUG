using ABS;

using BLL;

using System;
using System.Windows.Forms;

namespace VCL
{
    public class LoginVCL
    {
        // Formulario y controles
        readonly Form formulario;
        IEmailControl EmailControl;
        TextBox ClaveTextbox;
        Button ValidarButton;

        // Constructor
        public LoginVCL(Form formulario)
        {
            this.formulario = formulario;
            InicializarControles();
            InicializarEventHandlers();
        }

        private void InicializarControles()
        {
            EmailControl = (IEmailControl)formulario.Controls["EmailControl"];
            ClaveTextbox = (TextBox)formulario.Controls["ClaveTextbox"];
            ValidarButton = (Button)formulario.Controls["ValidarButton"];
        }

        private void InicializarEventHandlers()
        {
            EmailControl.TextChanged += ValidarInput;
            ClaveTextbox.TextChanged += ValidarInput;
            ValidarButton.Click += ValidarEmail;
        }

        private void ValidarInput(object sender, EventArgs e)
        {
            bool email = EmailControl.Validar();
            bool clave = ClaveTextbox.Text.Length > 0;
            ValidarButton.Enabled = email && clave;
        }

        private void ValidarEmail(object sender, EventArgs e)
        {
            try
            {
                string email = EmailControl.Email;
                string clave = ClaveTextbox.Text;
                bool validado = new LoginBLL().ValidarLogin(email, clave);
                formulario.DialogResult = DialogResult.OK;
                formulario.Close();
            }
            catch (Exception ex)
            {
                Tool.MostrarError(ex.Message);
            }
        }
    }
}
