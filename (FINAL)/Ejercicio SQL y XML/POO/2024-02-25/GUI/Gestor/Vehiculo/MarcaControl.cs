using ABS;

using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GUI
{
    public partial class MarcaControl : UserControl, IMarcaControl
    {
        public string Marca
        {
            get { return MarcaTextbox.Text; }
            set { MarcaTextbox.Text = value; }
        }
        public MarcaControl()
        {
            InitializeComponent();
            MarcaTextbox.Validating += Validar;

            // Evento para que el control de usuario notifique al formulario que
            // el texto ha cambiado.
            MarcaTextbox.TextChanged += (s, e) => OnTextChanged(EventArgs.Empty);
        }

        private void Validar(object sender, EventArgs e)
        {
            Validar();
        }

        public bool Validar()
        {
            string regex = @"^[A-Za-z]+$";
            bool valido = Regex.IsMatch(MarcaTextbox.Text, regex);

            if (valido) MarcaError.SetError(MarcaTextbox, null);
            else MarcaError.SetError(MarcaTextbox, "Formato esperado: Letras");

            return valido;
        }
    }
}
