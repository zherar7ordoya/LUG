using ABS;

using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GUI
{
    public partial class EmailControl : UserControl, IEmailControl
    {
        public string Email
        {
            get { return EmailTextbox.Text; }
            set { EmailTextbox.Text = value; }
        }

        public EmailControl()
        {
            InitializeComponent();
            EmailTextbox.Validating += Validar;

            // Evento para que el control notifique al formulario que el texto ha cambiado
            EmailTextbox.TextChanged += (s, e) => OnTextChanged(EventArgs.Empty);
        }

        //|||||||||||||||||||||||||||||||||||||||||||||| MÉTODOS PARA EL CONTROL

        private void Validar(object sender, EventArgs e)
        {
            Validar();
        }


        public bool Validar()
        {
            string regex = @"^([\w.-]+)@([\w-]+)\.(\w{2,3})(\.\w{2,3})?$";

            bool valido = Regex.IsMatch(EmailTextbox.Text, regex);

            if (valido)
            {
                EmailError.SetError(EmailTextbox, null);
            }
            else
            {
                EmailError.SetError(
                    EmailTextbox,
                    "Formato esperado: un e-mail válido");
            }

            return valido;
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
