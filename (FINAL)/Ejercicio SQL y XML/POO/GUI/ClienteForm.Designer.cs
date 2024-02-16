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
            this.FechaNacimientoDTP = new System.Windows.Forms.DateTimePicker();
            this.NombreControl = new GUI.NombreControl();
            this.ApellidoControl = new GUI.ApellidoControl();
            this.DniControl = new GUI.DniControl();
            this.EmailControl = new GUI.EmailControl();
            this.AltaButton = new System.Windows.Forms.Button();
            this.ListadoDGV = new System.Windows.Forms.DataGridView();
            this.ModificacionButton = new System.Windows.Forms.Button();
            this.VehiculosDGV = new System.Windows.Forms.DataGridView();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.DetallePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VehiculosDGV)).BeginInit();
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
            this.DetallePanel.Controls.Add(this.FechaNacimientoDTP, 1, 4);
            this.DetallePanel.Controls.Add(this.NombreControl, 1, 1);
            this.DetallePanel.Controls.Add(this.ApellidoControl, 1, 2);
            this.DetallePanel.Controls.Add(this.DniControl, 1, 3);
            this.DetallePanel.Controls.Add(this.EmailControl, 1, 5);
            this.DetallePanel.Location = new System.Drawing.Point(732, 13);
            this.DetallePanel.Margin = new System.Windows.Forms.Padding(4);
            this.DetallePanel.Name = "DetallePanel";
            this.DetallePanel.RowCount = 6;
            this.DetallePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.DetallePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.DetallePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.DetallePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.DetallePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.DetallePanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.DetallePanel.Size = new System.Drawing.Size(415, 208);
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
            // FechaNacimientoDTP
            // 
            this.FechaNacimientoDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaNacimientoDTP.Location = new System.Drawing.Point(148, 143);
            this.FechaNacimientoDTP.Margin = new System.Windows.Forms.Padding(4);
            this.FechaNacimientoDTP.Name = "FechaNacimientoDTP";
            this.FechaNacimientoDTP.Size = new System.Drawing.Size(107, 25);
            this.FechaNacimientoDTP.TabIndex = 5;
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
            // AltaButton
            // 
            this.AltaButton.Location = new System.Drawing.Point(761, 228);
            this.AltaButton.Name = "AltaButton";
            this.AltaButton.Size = new System.Drawing.Size(111, 29);
            this.AltaButton.TabIndex = 7;
            this.AltaButton.Text = "Alta";
            this.AltaButton.UseVisualStyleBackColor = true;
            // 
            // ListadoDGV
            // 
            this.ListadoDGV.AllowUserToAddRows = false;
            this.ListadoDGV.AllowUserToDeleteRows = false;
            this.ListadoDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ListadoDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.ListadoDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadoDGV.Location = new System.Drawing.Point(12, 12);
            this.ListadoDGV.Name = "ListadoDGV";
            this.ListadoDGV.ReadOnly = true;
            this.ListadoDGV.RowHeadersWidth = 51;
            this.ListadoDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListadoDGV.Size = new System.Drawing.Size(713, 209);
            this.ListadoDGV.TabIndex = 9;
            // 
            // ModificacionButton
            // 
            this.ModificacionButton.Location = new System.Drawing.Point(880, 228);
            this.ModificacionButton.Name = "ModificacionButton";
            this.ModificacionButton.Size = new System.Drawing.Size(111, 29);
            this.ModificacionButton.TabIndex = 8;
            this.ModificacionButton.Text = "Modificación";
            this.ModificacionButton.UseVisualStyleBackColor = true;
            // 
            // VehiculosDGV
            // 
            this.VehiculosDGV.AllowUserToAddRows = false;
            this.VehiculosDGV.AllowUserToDeleteRows = false;
            this.VehiculosDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.VehiculosDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.VehiculosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VehiculosDGV.Location = new System.Drawing.Point(12, 228);
            this.VehiculosDGV.Name = "VehiculosDGV";
            this.VehiculosDGV.ReadOnly = true;
            this.VehiculosDGV.RowHeadersWidth = 51;
            this.VehiculosDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.VehiculosDGV.Size = new System.Drawing.Size(713, 209);
            this.VehiculosDGV.TabIndex = 10;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(880, 263);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(111, 29);
            this.GuardarButton.TabIndex = 11;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Visible = false;
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(763, 263);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(111, 29);
            this.CancelarButton.TabIndex = 12;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Visible = false;
            // 
            // ClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 449);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.VehiculosDGV);
            this.Controls.Add(this.ModificacionButton);
            this.Controls.Add(this.ListadoDGV);
            this.Controls.Add(this.AltaButton);
            this.Controls.Add(this.DetallePanel);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ClienteForm";
            this.Text = "ClienteForm";
            this.Load += new System.EventHandler(this.ClienteForm_Load);
            this.DetallePanel.ResumeLayout(false);
            this.DetallePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VehiculosDGV)).EndInit();
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
        private System.Windows.Forms.TextBox CodigoTextbox;
        private System.Windows.Forms.DateTimePicker FechaNacimientoDTP;
        private System.Windows.Forms.Button AltaButton;
        private System.Windows.Forms.DataGridView ListadoDGV;
        private System.Windows.Forms.Button ModificacionButton;
        private System.Windows.Forms.DataGridView VehiculosDGV;
        private NombreControl NombreControl;
        private ApellidoControl ApellidoControl;
        private DniControl DniControl;
        private EmailControl EmailControl;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button CancelarButton;
    }
}