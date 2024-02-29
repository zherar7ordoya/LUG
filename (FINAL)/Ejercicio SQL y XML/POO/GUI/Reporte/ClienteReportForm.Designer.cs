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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteDataSet = new GUI.ClienteDataSet();
            this.ClienteReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.clienteTableAdapter = new GUI.ClienteDataSetTableAdapters.ClienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.clienteDataSet;
            // 
            // clienteDataSet
            // 
            this.clienteDataSet.DataSetName = "ClienteDataSet";
            this.clienteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ClienteReportViewer
            // 
            reportDataSource2.Name = "ClienteDataSet";
            reportDataSource2.Value = this.clienteBindingSource;
            this.ClienteReportViewer.LocalReport.DataSources.Add(reportDataSource2);
            this.ClienteReportViewer.LocalReport.ReportEmbeddedResource = "GUI.ClienteReport.rdlc";
            this.ClienteReportViewer.Location = new System.Drawing.Point(17, 18);
            this.ClienteReportViewer.Margin = new System.Windows.Forms.Padding(4);
            this.ClienteReportViewer.Name = "ClienteReportViewer";
            this.ClienteReportViewer.ServerReport.BearerToken = null;
            this.ClienteReportViewer.Size = new System.Drawing.Size(654, 528);
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
            this.ClientSize = new System.Drawing.Size(693, 564);
            this.Controls.Add(this.ClienteReportViewer);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ClienteReportForm";
            this.Text = "Reporte de clientes";
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ClienteReportViewer;
        private ClienteDataSet clienteDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private ClienteDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
    }
}