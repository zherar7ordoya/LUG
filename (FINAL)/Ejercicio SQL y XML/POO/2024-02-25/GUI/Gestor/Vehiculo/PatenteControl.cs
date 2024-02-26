using ABS;

using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GUI
{
    public partial class PatenteControl : UserControl, IPatenteControl
    {
        public string Patente
        {
            get { return PatenteTextbox.Text; }
            set { PatenteTextbox.Text = value; }
        }

        public PatenteControl()
        {
            InitializeComponent();
            PatenteTextbox.Validating += Validar;

            // Evento para que el control notifique al formulario que el texto ha cambiado
            PatenteTextbox.TextChanged += (s, e) => OnTextChanged(EventArgs.Empty);
        }

        private void Validar(object sender, EventArgs e)
        {
            Validar();
        }

        public bool Validar()
        {
            string regex = @"^[A-Z]{3}\d{3}$";
            bool valido = Regex.IsMatch(PatenteTextbox.Text, regex);

            if (valido) PatenteError.SetError(PatenteTextbox, null);
            else PatenteError.SetError(PatenteTextbox, "Formato esperado: Tres letras mayúsculas y tres dígitos");

            return valido;
        }
    }
}
