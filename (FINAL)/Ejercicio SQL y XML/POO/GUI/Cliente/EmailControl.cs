using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class EmailControl : UserControl
    {
        private readonly ToolTip tip = new ToolTip();

        public string Email
        {
            get { return EmailTextbox.Text; }
            set { EmailTextbox.Text = value; }
        }

        public EmailControl()
        {
            InitializeComponent();
            tip.SetToolTip(EmailTextbox, "Formato esperado: un e-mail válido.");
            EmailTextbox.Validating += ValidarEmail;
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||| EVENTOS PARA EL FORM

        // Evento para notificar al formulario principal el estado de la validación
        public event EventHandler<bool> ValidacionCompleta;

        // Método para notificar al formulario principal el estado de la validación
        private void OnValidacionCompleta(bool esValido)
        {
            ValidacionCompleta?.Invoke(this, esValido);
        }

        //|||||||||||||||||||||||||||||||||||||||||||||| MÉTODOS PARA EL CONTROL

        private void ValidarEmail(object sender, EventArgs e)
        {
            bool esValido = ValidarEmail();

            // Notificar al formulario principal sobre el estado de la validación
            OnValidacionCompleta(esValido);
        }


        public bool ValidarEmail()
        {
            string regex = @"^([\w.-]+)@([\w-]+)\.(\w{2,3})(\.\w{2,3})?$";

            bool esValido = Regex.IsMatch(EmailTextbox.Text, regex);

            if (esValido)
            {
                EmailError.SetError(EmailTextbox, null);
            }
            else
            {
                EmailError.SetError(EmailTextbox, "El email no es válido");
            }

            return esValido;
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
