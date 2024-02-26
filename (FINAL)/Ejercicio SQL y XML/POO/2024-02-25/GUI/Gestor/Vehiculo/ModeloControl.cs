using ABS;

using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GUI
{
    public partial class ModeloControl : UserControl, IModeloControl
    {
        public string Modelo
        {
            get { return ModeloTextbox.Text; }
            set { ModeloTextbox.Text = value; }
        }

        public ModeloControl()
        {
            InitializeComponent();
            ModeloTextbox.Validating += Validar;

            // Evento para que el control notifique al formulario que el texto ha cambiado
            ModeloTextbox.TextChanged += (s, e) => OnTextChanged(EventArgs.Empty);
        }

        private void Validar(object sender, EventArgs e)
        {
            Validar();
        }

        public bool Validar()
        {
            string regex = @"^[A-Za-z0-9\-]+$";
            bool valido = Regex.IsMatch(ModeloTextbox.Text, regex);

            if (valido) ModeloError.SetError(ModeloTextbox, null);
            else ModeloError.SetError(ModeloTextbox, "Formato esperado: letras, números y guiones");

            return valido;
        }
    }
}
