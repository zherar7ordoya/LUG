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
            DniTextbox.Validating += ValidarDni;
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

        private void ValidarDni(object sender, EventArgs e)
        {
            bool esValido = ValidarDni();

            // Notificar al formulario principal sobre el estado de la validación
            OnValidacionCompleta(esValido);
        }


        public bool ValidarDni()
        {
            string regex = @"^\d{8}$";

            bool esValido = Regex.IsMatch(DniTextbox.Text, regex);

            if (esValido)
            {
                DniError.SetError(DniTextbox, null);
            }
            else
            {
                DniError.SetError(DniTextbox, "El DNI no es válido");
            }

            return esValido;
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
