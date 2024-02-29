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
    public partial class ClienteReportForm : BaseForm
    {
        public ClienteReportForm()
        {
            InitializeComponent();
            this.Load += FormularioLoad;
        }

        private void FormularioLoad(object sender, EventArgs e)
        {
            // This line of code loads data into the 'clienteDataSet.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.clienteDataSet.Cliente);
            this.ClienteReportViewer.RefreshReport();
        }
    }
}
