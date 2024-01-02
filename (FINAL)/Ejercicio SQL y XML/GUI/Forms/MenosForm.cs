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
    public partial class MenosForm : Form
    {
        private static MenosForm formulario = null;
        public static MenosForm Instance()
        {
            if (formulario == null)
            {
                formulario = new MenosForm();
            }
            return formulario;
        }
        public MenosForm()
        {
            InitializeComponent();
        }
    }
}
