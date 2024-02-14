using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GUI
{
    public partial class DniControl : UserControl
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
