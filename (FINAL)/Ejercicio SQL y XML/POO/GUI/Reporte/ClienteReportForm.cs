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
            // TODO: esta línea de código carga datos en la tabla 'finalDataSet.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.finalDataSet.Cliente);

            this.ClienteReportViewer.RefreshReport();
        }
    }
}
