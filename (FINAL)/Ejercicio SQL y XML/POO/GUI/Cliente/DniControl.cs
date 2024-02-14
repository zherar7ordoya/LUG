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

namespace GUI
{
    public partial class DniControl : UserControl
    {
        private readonly ToolTip tip = new ToolTip();

        public string Dni
        {
            get { return DniTextbox.Text; }
            set { DniTextbox.Text = value; }
        }

        public DniControl()
        {
            InitializeComponent();
            tip.SetToolTip(DniTextbox, "Formato esperado: ocho dígitos.");
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
                DniError.SetError(DniTextbox, "El DNI no es válido");
            }

            return valido;
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
