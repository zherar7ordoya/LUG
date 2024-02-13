using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GUI
{
    public partial class ApellidoControl : UserControl
    {
        private readonly ToolTip tip = new ToolTip();

        public string Apellido
        {
            get { return ApellidoTextbox.Text; }
            set { ApellidoTextbox.Text = value; }
        }

        public ApellidoControl()
        {
            InitializeComponent();
            tip.SetToolTip(ApellidoTextbox, "Formato esperado: Primera letra mayúscula, siguientes letras minúsculas.");
            ApellidoTextbox.Validating += ValidarApellido;
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

        private void ValidarApellido(object sender, EventArgs e)
        {
            bool esValido = ValidarApellido();

            // Notificar al formulario principal sobre el estado de la validación
            OnValidacionCompleta(esValido);
        }


        public bool ValidarApellido()
        {
            string regex = @"^[A-Z][a-z]+$";

            bool esValido = Regex.IsMatch(ApellidoTextbox.Text, regex);

            if (esValido)
            {
                ApellidoError.SetError(ApellidoTextbox, null);
            }
            else
            {
                ApellidoError.SetError(ApellidoTextbox, "El apellido no es válido");
            }

            return esValido;
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
