using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LUG.SegundoParcial
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {
                ClienteABMForm clienteAbm = new ClienteABMForm { MdiParent = this };
                clienteAbm.Show();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void StreamingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {
                StreamingABMForm streamingAbm = new StreamingABMForm { MdiParent = this };
                streamingAbm.Show();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void ContrataosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {
                ContratacionForm contratacionForm = new ContratacionForm { MdiParent = this };
                contratacionForm.Show();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void StreamingMayorDuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {
                StreamingMayorDuracionForm reporte = new StreamingMayorDuracionForm { MdiParent = this };
                reporte.Show();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void TotalRecaudadoPorCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {
                StreamingTotalRecaudadoForm reporte = new StreamingTotalRecaudadoForm { MdiParent = this };
                reporte.Show();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
