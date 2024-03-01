using ABS;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace GUI
{
    public partial class ApellidoControl : UserControl, IApellidoControl
    {
        public string Apellido
        {
            get { return ApellidoTextbox.Text; }
            set { ApellidoTextbox.Text = value; }
        }

        public ApellidoControl()
        {
            InitializeComponent();
            ApellidoTextbox.Validating += Validar;

            // Evento para que el control notifique al formulario que el texto ha cambiado
            ApellidoTextbox.TextChanged += (s, e) => OnTextChanged(EventArgs.Empty);
        }

        //|||||||||||||||||||||||||||||||||||||||||||||| MÉTODOS PARA EL CONTROL

        private void Validar(object sender, EventArgs e)
        {
            Validar();
        }


        public bool Validar()
        {
            string regex = @"^[A-Z][a-z]+$";

            bool valido = Regex.IsMatch(ApellidoTextbox.Text, regex);

            if (valido)
            {
                ApellidoError.SetError(ApellidoTextbox, null);
            }
            else
            {
                ApellidoError.SetError(
                    ApellidoTextbox,
                    "Formato esperado: Primera letra mayúscula, siguientes letras minúsculas");
            }

            return valido;
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
