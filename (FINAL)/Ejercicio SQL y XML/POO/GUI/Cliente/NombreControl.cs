using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GUI
{
    public partial class NombreControl : UserControl
    {
        public string Nombre
        {
            get { return NombreTextbox.Text; }
            set { NombreTextbox.Text = value; }
        }

        public NombreControl()
        {
            InitializeComponent();
            NombreTextbox.Validating += Validar;
            NombreTextbox.TextChanged += (s, e) => OnTextChanged(EventArgs.Empty);
        }

        //|||||||||||||||||||||||||||||||||||||||||||||| MÉTODOS PARA EL CONTROL

        private void Validar(object sender, EventArgs e)
        {
            Validar();
        }


        public bool Validar()
        {
            string regex = @"^[A-Z][a-z]+$";

            bool valido = Regex.IsMatch(NombreTextbox.Text, regex);

            if (valido)
            {
                NombreError.SetError(NombreTextbox, null);
            }
            else
            {
                NombreError.SetError(
                    NombreTextbox,
                    "Formato esperado: Primera letra mayúscula, siguientes letras minúsculas");
            }

            return valido;
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
