using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class LabeledTextBox : UserControl
    {
        private readonly Label label;
        private readonly TextBox textbox;

        public LabeledTextBox()
        {
            label = new Label();
            textbox = new TextBox();

            // Configurar el tamaño y la posición del label y el textbox
            label.Width = 100;
            label.Text = "Etiqueta";
            
            textbox.Width = 150;
            textbox.Left = label.Width + 5;
            textbox.Text = "Caja de Texto";

            // Agregar los controles al UserControl
            Controls.Add(label);
            Controls.Add(textbox);
        }

        // Propiedades para acceder al texto del label y el textbox
        public string LabelText
        {
            get { return label.Text; }
            set { label.Text = value; }
        }

        public string TextBoxText
        {
            get { return textbox.Text; }
            set { textbox.Text = value; }
        }
    }
}
