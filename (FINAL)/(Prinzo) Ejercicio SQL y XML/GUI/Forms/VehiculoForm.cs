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
    public partial class VehiculoForm : Form
    {
        private static VehiculoForm formulario = null;
        public static VehiculoForm Instance()
        {
            if (formulario == null)
            {
                formulario = new VehiculoForm();
            }
            return formulario;
        }
        public VehiculoForm()
        {
            InitializeComponent();
        }
    }
}
