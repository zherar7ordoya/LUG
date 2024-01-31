namespace Reports
{
    partial class ReporteForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.VehiculosRViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // VehiculosRViewer
            // 
            this.VehiculosRViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet";
            reportDataSource1.Value = null;
            this.VehiculosRViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.VehiculosRViewer.LocalReport.ReportEmbeddedResource = "Reports.Reporte.rdlc";
            this.VehiculosRViewer.Location = new System.Drawing.Point(0, 0);
            this.VehiculosRViewer.Name = "VehiculosRViewer";
            this.VehiculosRViewer.ServerReport.BearerToken = null;
            this.VehiculosRViewer.Size = new System.Drawing.Size(800, 450);
            this.VehiculosRViewer.TabIndex = 0;
            // 
            // ReporteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VehiculosRViewer);
            this.Name = "ReporteForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ReporteForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer VehiculosRViewer;
    }
}

