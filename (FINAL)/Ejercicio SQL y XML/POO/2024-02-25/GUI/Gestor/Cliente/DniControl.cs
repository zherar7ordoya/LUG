using ABS;

using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GUI
{
    public partial class DniControl : UserControl, IDniControl
    {
        public string Dni
        {
            get { return DniTextbox.Text; }
            set { DniTextbox.Text = value; }
        }

        public DniControl()
        {
            InitializeComponent();
            DniTextbox.Validating += Validar;

            // Evento para que el control notifique al formulario que el texto ha cambiado
            DniTextbox.TextChanged += (s, e) => OnTextChanged(EventArgs.Empty);
        }

        //|||||||||||||||||||||||||||||||||||||||||||||| MÉTODOS PARA EL CONTROL

        private void Validar(object sender, EventArgs e)
        {
            Validar();
        }


        public bool Validar()
        {
            string regex = @"^\d{8}$";

            bool valido = Regex.IsMatch(DniTextbox.Text, regex);

            if (valido)
            {
                DniError.SetError(DniTextbox, null);
            }
            else
            {
                DniError.SetError(
                    DniTextbox,
                    "Formato esperado: ocho dígitos");
            }

            return valido;
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
