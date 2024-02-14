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
            EmailTextbox.Validating += Validar;
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
                EmailError.SetError(EmailTextbox, "El email no es válido");
            }

            return valido;
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
