using BEL;

using BLL;

using Microsoft.Reporting.WinForms;

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VCL
{
    // Ver nota en App.config
    public class ClienteReportVCL
    {
        // Formulario y controles
        readonly Form formulario;
        ReportViewer ClienteReportViewer;

        public ClienteReportVCL(Form formulario)
        {
            this.formulario = formulario;
            IncializarControles();
            formulario.Load += FormularioLoad;
        }

        private void IncializarControles()
        {
            ClienteReportViewer = (ReportViewer)formulario.Controls["ClienteReportViewer"];
        }

        private void FormularioLoad(object sender, EventArgs e)
        {
            ClienteReportViewer
                .LocalReport
                .DataSources
                .Clear();
            List<Cliente> clientes = new ClienteBLL().Consultar();
            ClienteReportViewer
                .LocalReport
                .DataSources
                .Add(new ReportDataSource("ClienteDataTable", clientes));
            ClienteReportViewer.RefreshReport();
        }
    }
}
