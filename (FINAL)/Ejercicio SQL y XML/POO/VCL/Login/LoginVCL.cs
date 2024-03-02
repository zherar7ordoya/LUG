using ABS;
using BLL;
using SVC;
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
            //formulario.FormClosing += FormularioClosing;
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
                if (validado)
                {
                    formulario.DialogResult = DialogResult.Yes;
                }
                else
                {
                    formulario.DialogResult = DialogResult.No;
                }
                formulario.Close();
            }
            catch (Exception ex)
            {
                Mensajeria.MostrarError(ex.Message);
            }
        }

        private void FormularioClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}
