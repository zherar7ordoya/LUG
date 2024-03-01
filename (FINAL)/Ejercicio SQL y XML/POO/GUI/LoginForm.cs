using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class LoginForm : BaseForm
    {
        public LoginForm()
        {
            InitializeComponent();
            InicializarControles();
            InicializarEventHandlers();
        }

        private void InicializarControles()
        {
        }

        private void InicializarEventHandlers()
        {
            this.EmailControl.TextChanged += ValidarInput;
            this.ClaveTextbox.TextChanged += ValidarInput;
            this.ValidarButton.Click += ValidarEmail;
        }

        private void ValidarInput(object sender, EventArgs e)
        {
            bool email = EmailControl.Validar();
            bool clave = ClaveTextbox.Text.Length > 0;
            ValidarButton.Enabled = email && clave;
        }

        private void ValidarEmail(object sender, EventArgs e)
        {
         
        }
    }
}
