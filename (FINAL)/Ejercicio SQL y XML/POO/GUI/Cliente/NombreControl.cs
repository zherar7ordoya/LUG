using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;



namespace GUI
{
    public partial class NombreControl : UserControl
    {
        private readonly ToolTip tip = new ToolTip();
        public string Nombre
        {
            get { return NombreTextbox.Text; }
            set { NombreTextbox.Text = value; }
        }

        public NombreControl()
        {
            InitializeComponent();
            tip.SetToolTip(NombreTextbox, "Formato esperado: Primera letra mayúscula, siguientes letras minúsculas.");
            NombreTextbox.Validating += ValidarNombre;
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

        private void ValidarNombre(object sender, EventArgs e)
        {
            bool esValido = ValidarNombre();

            // Notificar al formulario principal sobre el estado de la validación
            OnValidacionCompleta(esValido);
        }

        // Nuevo método público que realiza la validación y devuelve un booleano
        public bool ValidarNombre()
        {
            string regex = @"^[A-Z][a-z]+$";

            bool esValido = Regex.IsMatch(NombreTextbox.Text, regex);

            if (esValido)
            {
                NombreError.SetError(NombreTextbox, null);
            }
            else
            {
                NombreError.SetError(NombreTextbox, "El nombre no es válido");
            }

            return esValido;
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
