using System.ComponentModel;
using System.Windows.Forms;

namespace GUI
{
    public partial class PatenteControl : UserControl
    {
        public string Patente
        {
            get { return PatenteTextbox.Text; }
            set { PatenteTextbox.Text = value; }
        }

        public PatenteControl()
        {
            InitializeComponent();
            PatenteTextbox.Validating += Validar;
        }

        private void Validar(object sender, CancelEventArgs e)
        {
            Validar();
        }

        public bool Validar()
        {
            string regex = @"^[A-Z]{3}\d{3}$";
            bool valido = System.Text.RegularExpressions.Regex.IsMatch(PatenteTextbox.Text, regex);

            if (valido) PatenteError.SetError(PatenteTextbox, null);
            else PatenteError.SetError(PatenteTextbox, "Formato esperado: Tres letras mayúsculas y tres dígitos");

            return valido;
        }
    }
}
