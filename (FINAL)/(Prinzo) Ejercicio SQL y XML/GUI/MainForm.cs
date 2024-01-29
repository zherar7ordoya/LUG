// ============================================================================
// Developer/s: Gerardo Tordoya
// Description: https://www.codeproject.com/Articles/7505/Singleton-pattern-for-MDI-child-forms
// Create Date: 2023-06-25
// Update Date: XXXX-XX-XX
// ============================================================================


using GUI.Forms;

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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AlquilerMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = AlquilerForm.Instance();
            formulario.MdiParent = this;
            formulario.Show();
            formulario.Activate();
        }

        private void ClienteMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = ClienteForm.Instance();
            formulario.MdiParent = this;
            formulario.Show();
            formulario.Activate();
        }

        private void VehiculoMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = VehiculoForm.Instance();
            formulario.MdiParent = this;
            formulario.Show();
            formulario.Activate();
        }

        private void MasMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = MasForm.Instance();
            formulario.MdiParent = this;
            formulario.Show();
            formulario.Activate();
        }

        private void MenosMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = MenosForm.Instance();
            formulario.MdiParent = this;
            formulario.Show();
            formulario.Activate();
        }

        private void TotalMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = TotalForm.Instance();
            formulario.MdiParent = this;
            formulario.Show();
            formulario.Activate();
        }
    }
}
