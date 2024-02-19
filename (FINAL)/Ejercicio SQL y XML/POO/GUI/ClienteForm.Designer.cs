namespace GUI
{
    partial class ClienteForm
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
            this.DetallePanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CodigoTextbox = new System.Windows.Forms.TextBox();
            this.FechaNacimientoDtp = new System.Windows.Forms.DateTimePicker();
            this.NombreControl = new GUI.NombreControl();
            this.ApellidoControl = new GUI.ApellidoControl();
            this.DniControl = new GUI.DniControl();
            this.EmailControl = new GUI.EmailControl();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.ListadoDgv = new System.Windows.Forms.DataGridView();
            this.VehiculosDgv = new System.Windows.Forms.DataGridView();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.DetallePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VehiculosDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // DetallePanel
            // 
            this.DetallePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DetallePanel.ColumnCount = 2;
            this.DetallePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.DetallePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.DetallePanel.Controls.Add(this.label1, 0, 0);
            this.DetallePanel.Controls.Add(this.label2, 0, 1);
            this.DetallePanel.Controls.Add(this.label3, 0, 2);
            this.DetallePanel.Controls.Add(this.label4, 0, 3);
            this.DetallePanel.Controls.Add(this.label5, 0, 4);
            this.DetallePanel.Controls.Add(this.label6, 0, 5);
            this.DetallePanel.Controls.Add(this.CodigoTextbox, 1, 0);
            this.DetallePanel.Controls.Add(this.FechaNacimientoDtp, 1, 4);
            this.DetallePanel.Controls.Add(this.NombreControl, 1, 1);
            this.DetallePanel.Controls.Add(this.ApellidoControl, 1, 2);
            this.DetallePanel.Controls.Add(this.DniControl, 1, 3);
            this.DetallePanel.Controls.Add(this.EmailControl, 1, 5);
            this.DetallePanel.Location = new System.Drawing.Point(713, 12);
            this.DetallePanel.Margin = new System.Windows.Forms.Padding(4);
            this.DetallePanel.Name = "DetallePanel";
            this.DetallePanel.RowCount = 6;
            this.DetallePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.DetallePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.DetallePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.DetallePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.DetallePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.DetallePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.DetallePanel.Size = new System.Drawing.Size(395, 208);
            this.DetallePanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "DNI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 139);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha de nacimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 172);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "E-mail";
            // 
            // CodigoTextbox
            // 
            this.CodigoTextbox.Enabled = false;
            this.CodigoTextbox.Location = new System.Drawing.Point(148, 4);
            this.CodigoTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.CodigoTextbox.Name = "CodigoTextbox";
            this.CodigoTextbox.Size = new System.Drawing.Size(54, 25);
            this.CodigoTextbox.TabIndex = 1;
            // 
            // FechaNacimientoDtp
            // 
            this.FechaNacimientoDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaNacimientoDtp.Location = new System.Drawing.Point(148, 143);
            this.FechaNacimientoDtp.Margin = new System.Windows.Forms.Padding(4);
            this.FechaNacimientoDtp.Name = "FechaNacimientoDtp";
            this.FechaNacimientoDtp.Size = new System.Drawing.Size(107, 25);
            this.FechaNacimientoDtp.TabIndex = 5;
            // 
            // NombreControl
            // 
            this.NombreControl.Location = new System.Drawing.Point(146, 35);
            this.NombreControl.Margin = new System.Windows.Forms.Padding(2);
            this.NombreControl.Name = "NombreControl";
            this.NombreControl.Nombre = "";
            this.NombreControl.Size = new System.Drawing.Size(245, 31);
            this.NombreControl.TabIndex = 2;
            // 
            // ApellidoControl
            // 
            this.ApellidoControl.Apellido = "";
            this.ApellidoControl.Location = new System.Drawing.Point(146, 70);
            this.ApellidoControl.Margin = new System.Windows.Forms.Padding(2);
            this.ApellidoControl.Name = "ApellidoControl";
            this.ApellidoControl.Size = new System.Drawing.Size(245, 33);
            this.ApellidoControl.TabIndex = 3;
            // 
            // DniControl
            // 
            this.DniControl.Dni = "";
            this.DniControl.Location = new System.Drawing.Point(146, 107);
            this.DniControl.Margin = new System.Windows.Forms.Padding(2);
            this.DniControl.Name = "DniControl";
            this.DniControl.Size = new System.Drawing.Size(139, 30);
            this.DniControl.TabIndex = 4;
            // 
            // EmailControl
            // 
            this.EmailControl.Email = "";
            this.EmailControl.Location = new System.Drawing.Point(146, 174);
            this.EmailControl.Margin = new System.Windows.Forms.Padding(2);
            this.EmailControl.Name = "EmailControl";
            this.EmailControl.Size = new System.Drawing.Size(245, 30);
            this.EmailControl.TabIndex = 6;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(969, 228);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(102, 30);
            this.GuardarButton.TabIndex = 7;
            this.GuardarButton.Text = "Alta";
            this.GuardarButton.UseVisualStyleBackColor = true;
            // 
            // ListadoDgv
            // 
            this.ListadoDgv.AllowUserToAddRows = false;
            this.ListadoDgv.AllowUserToDeleteRows = false;
            this.ListadoDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ListadoDgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.ListadoDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadoDgv.Location = new System.Drawing.Point(12, 12);
            this.ListadoDgv.Name = "ListadoDgv";
            this.ListadoDgv.ReadOnly = true;
            this.ListadoDgv.RowHeadersWidth = 51;
            this.ListadoDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListadoDgv.Size = new System.Drawing.Size(694, 209);
            this.ListadoDgv.TabIndex = 9;
            // 
            // VehiculosDgv
            // 
            this.VehiculosDgv.AllowUserToAddRows = false;
            this.VehiculosDgv.AllowUserToDeleteRows = false;
            this.VehiculosDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.VehiculosDgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.VehiculosDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VehiculosDgv.Location = new System.Drawing.Point(12, 228);
            this.VehiculosDgv.Name = "VehiculosDgv";
            this.VehiculosDgv.ReadOnly = true;
            this.VehiculosDgv.RowHeadersWidth = 51;
            this.VehiculosDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.VehiculosDgv.Size = new System.Drawing.Size(694, 209);
            this.VehiculosDgv.TabIndex = 10;
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(861, 227);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(102, 30);
            this.CancelarButton.TabIndex = 12;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Visible = false;
            // 
            // ClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 449);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.VehiculosDgv);
            this.Controls.Add(this.ListadoDgv);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.DetallePanel);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ClienteForm";
            this.Text = "ClienteForm";
            this.Load += new System.EventHandler(this.ClienteForm_Load);
            this.DetallePanel.ResumeLayout(false);
            this.DetallePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VehiculosDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel DetallePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.DataGridView ListadoDgv;
        private System.Windows.Forms.DataGridView VehiculosDgv;
        private System.Windows.Forms.Button CancelarButton;
        public System.Windows.Forms.TextBox CodigoTextbox;
        public System.Windows.Forms.DateTimePicker FechaNacimientoDtp;
        public NombreControl NombreControl;
        public ApellidoControl ApellidoControl;
        public DniControl DniControl;
        public EmailControl EmailControl;
    }
}