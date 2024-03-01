using System;

namespace GUI
{
    public partial class ClienteReportForm : BaseForm
    {
        public ClienteReportForm()
        {
            InitializeComponent();
        }

        private void ClienteReportForm_Load(object sender, EventArgs e)
        {
            this.clienteTableAdapter.Fill(this.finalDataSet.Cliente);
            this.ClienteReportViewer.RefreshReport();
        }
    }
}
