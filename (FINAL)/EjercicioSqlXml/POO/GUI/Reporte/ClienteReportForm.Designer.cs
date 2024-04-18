namespace GUI
{
    partial class ClienteReportForm
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
            this.ClienteReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // ClienteReportViewer
            // 
            this.ClienteReportViewer.LocalReport.ReportEmbeddedResource = "GUI.Reporte.ClienteReport.rdlc";
            this.ClienteReportViewer.Location = new System.Drawing.Point(12, 12);
            this.ClienteReportViewer.Name = "ClienteReportViewer";
            this.ClienteReportViewer.ServerReport.BearerToken = null;
            this.ClienteReportViewer.Size = new System.Drawing.Size(656, 446);
            this.ClienteReportViewer.TabIndex = 0;
            // 
            // ClienteReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 470);
            this.Controls.Add(this.ClienteReportViewer);
            this.Name = "ClienteReportForm";
            this.Text = "Listado de clientes";
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ClienteReportViewer;
    }
}