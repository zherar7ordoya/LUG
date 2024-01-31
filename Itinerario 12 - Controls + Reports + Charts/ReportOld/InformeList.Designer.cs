
namespace RebootReportes
{
    partial class InformeList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.PersonaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PersonasReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.PersonaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PersonaBindingSource
            // 
            this.PersonaBindingSource.DataSource = typeof(RebootReportes.Persona);
            // 
            // PersonasReportViewer
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PersonaBindingSource;
            this.PersonasReportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.PersonasReportViewer.LocalReport.ReportEmbeddedResource = "RebootReportes.Reporte.rdlc";
            this.PersonasReportViewer.Location = new System.Drawing.Point(13, 13);
            this.PersonasReportViewer.Name = "PersonasReportViewer";
            this.PersonasReportViewer.ServerReport.BearerToken = null;
            this.PersonasReportViewer.Size = new System.Drawing.Size(650, 250);
            this.PersonasReportViewer.TabIndex = 0;
            // 
            // InformeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 275);
            this.Controls.Add(this.PersonasReportViewer);
            this.Name = "InformeList";
            this.Text = "InformeList";
            this.Load += new System.EventHandler(this.InformeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PersonaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer PersonasReportViewer;
        private System.Windows.Forms.BindingSource PersonaBindingSource;
    }
}