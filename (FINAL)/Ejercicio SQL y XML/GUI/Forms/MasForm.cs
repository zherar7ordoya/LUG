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
    public partial class MasForm : Form
    {
        private static MasForm formulario = null;
        public static MasForm Instance()
        {
            if (formulario == null)
            {
                formulario = new MasForm();
            }
            return formulario;
        }
        public MasForm()
        {
            InitializeComponent();
        }
    }
}
