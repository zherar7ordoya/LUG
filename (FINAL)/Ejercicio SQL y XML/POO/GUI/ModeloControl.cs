using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GUI
{
    public partial class ModeloControl : UserControl
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
        }

        private void Validar(object sender, CancelEventArgs e)
        {
            Validar();
        }

        public bool Validar()
        {
            string regex = @"^[A-Za-z\-]+$";
            bool valido = Regex.IsMatch(ModeloTextbox.Text, regex);

            if (valido) ModeloError.SetError(ModeloTextbox, null);
            else ModeloError.SetError(ModeloTextbox, "Formato esperado: Letras y guiones");

            return valido;
        }
    }
}
