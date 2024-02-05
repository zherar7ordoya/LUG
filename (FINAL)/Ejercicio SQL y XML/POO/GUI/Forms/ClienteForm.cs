using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Forms
{
    public partial class ClienteForm : Form
    {
        private static ClienteForm formulario = null;
        public static ClienteForm Instance()
        {
            if (formulario == null)
            {
                formulario = new ClienteForm();
            }
            return formulario;
        }
        public ClienteForm()
        {
            InitializeComponent();
        }
    }
}
