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

namespace WindowsFormsApplication1
{
    public partial class TelefonoControl : UserControl
    {
        public string PhoneNumber
        {
            get { return TelefonoTextbox.Text; }
            set { TelefonoTextbox.Text = value; }
        }

        public TelefonoControl()
        {
            InitializeComponent();
            TelefonoTextbox.Validating += ValidarTelefono;
        }

        private void ValidarTelefono(object sender, CancelEventArgs e)
        {
            // Validar el formato del número telefónico usando una expresión regular
            string pattern = @"^\(\d{3}\) \d{3}-\d{4}$";
            if (!Regex.IsMatch(TelefonoTextbox.Text, pattern))
            {
                // Mostrar un mensaje de error si el formato no es válido
                TelefonoError.SetError(TelefonoTextbox, "Formato de teléfono no válido. Use (XXX) XXX-XXXX");
                //e.Cancel = true;
            }
            else
            {
                // Limpiar el mensaje de error si el formato es válido
                TelefonoError.SetError(TelefonoTextbox, "");
            }
        }

    }
}
