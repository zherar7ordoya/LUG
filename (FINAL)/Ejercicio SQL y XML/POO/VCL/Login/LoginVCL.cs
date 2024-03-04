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
        Button SalirButton;

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
            SalirButton = (Button)formulario.Controls["SalirButton"];
        }

        private void InicializarEventHandlers()
        {
            EmailControl.TextChanged += ValidarInput;
            ClaveTextbox.TextChanged += ValidarInput;
            ValidarButton.Click += ValidarEmail;
            SalirButton.Click += Salir;
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
                if (validado) formulario.DialogResult = DialogResult.Yes;
                else formulario.DialogResult = DialogResult.No;
                formulario.Close();
            }
            catch (Exception ex) { Mensajeria.MostrarError(ex.Message); }
        }

        private void Salir(object sender, EventArgs e)
        {
            // TODO => Bug: al salir, se escucha el sonido de error.
            if (Mensajeria.MostrarPregunta("¿Desea salir del sistema?") == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
