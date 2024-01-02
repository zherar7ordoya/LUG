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
    public partial class TotalForm : Form
    {
        private static TotalForm formulario = null;
        public static TotalForm Instance()
        {
            if (formulario == null)
            {
                formulario = new TotalForm();
            }
            return formulario;
        }
        public TotalForm()
        {
            InitializeComponent();
        }
    }
}
