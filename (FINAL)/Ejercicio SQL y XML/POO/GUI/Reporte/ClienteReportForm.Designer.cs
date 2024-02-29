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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalDataSet = new GUI.FinalDataSet();
            this.ClienteReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.clienteTableAdapter = new GUI.FinalDataSetTableAdapters.ClienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.finalDataSet;
            // 
            // finalDataSet
            // 
            this.finalDataSet.DataSetName = "FinalDataSet";
            this.finalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ClienteReportViewer
            // 
            reportDataSource1.Name = "ClienteDataTable";
            reportDataSource1.Value = this.clienteBindingSource;
            this.ClienteReportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.ClienteReportViewer.LocalReport.ReportEmbeddedResource = "GUI.Reporte.ClienteReport.rdlc";
            this.ClienteReportViewer.Location = new System.Drawing.Point(12, 12);
            this.ClienteReportViewer.Name = "ClienteReportViewer";
            this.ClienteReportViewer.ServerReport.BearerToken = null;
            this.ClienteReportViewer.Size = new System.Drawing.Size(654, 445);
            this.ClienteReportViewer.TabIndex = 0;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // ClienteReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 470);
            this.Controls.Add(this.ClienteReportViewer);
            this.Name = "ClienteReportForm";
            this.Text = "ClienteReportForm";
            this.Load += new System.EventHandler(this.ClienteReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ClienteReportViewer;
        private FinalDataSet finalDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private FinalDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
    }
}