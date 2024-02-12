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
            this.NombreTextbox = new System.Windows.Forms.TextBox();
            this.ApellidoTextbox = new System.Windows.Forms.TextBox();
            this.DniTextbox = new System.Windows.Forms.TextBox();
            this.EmailTextbox = new System.Windows.Forms.TextBox();
            this.FechaNacimientoDTP = new System.Windows.Forms.DateTimePicker();
            this.AltaButton = new System.Windows.Forms.Button();
            this.ListadoDGV = new System.Windows.Forms.DataGridView();
            this.ModificacionButton = new System.Windows.Forms.Button();
            this.VehiculosDGV = new System.Windows.Forms.DataGridView();
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
            this.DetallePanel.Controls.Add(this.NombreTextbox, 1, 1);
            this.DetallePanel.Controls.Add(this.ApellidoTextbox, 1, 2);
            this.DetallePanel.Controls.Add(this.DniTextbox, 1, 3);
            this.DetallePanel.Controls.Add(this.EmailTextbox, 1, 5);
            this.DetallePanel.Controls.Add(this.FechaNacimientoDTP, 1, 4);
            this.DetallePanel.Location = new System.Drawing.Point(696, 16);
            this.DetallePanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DetallePanel.Name = "DetallePanel";
            this.DetallePanel.RowCount = 6;
            this.DetallePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.DetallePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.DetallePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.DetallePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.DetallePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.DetallePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.DetallePanel.Size = new System.Drawing.Size(425, 244);
            this.DetallePanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 120);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "DNI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 160);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha de nacimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 200);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "E-mail";
            // 
            // CodigoTextbox
            // 
            this.CodigoTextbox.Location = new System.Drawing.Point(179, 5);
            this.CodigoTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CodigoTextbox.Name = "CodigoTextbox";
            this.CodigoTextbox.Size = new System.Drawing.Size(60, 30);
            this.CodigoTextbox.TabIndex = 1;
            // 
            // NombreTextbox
            // 
            this.NombreTextbox.Location = new System.Drawing.Point(179, 45);
            this.NombreTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NombreTextbox.Name = "NombreTextbox";
            this.NombreTextbox.Size = new System.Drawing.Size(240, 30);
            this.NombreTextbox.TabIndex = 2;
            // 
            // ApellidoTextbox
            // 
            this.ApellidoTextbox.Location = new System.Drawing.Point(179, 85);
            this.ApellidoTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ApellidoTextbox.Name = "ApellidoTextbox";
            this.ApellidoTextbox.Size = new System.Drawing.Size(240, 30);
            this.ApellidoTextbox.TabIndex = 3;
            // 
            // DniTextbox
            // 
            this.DniTextbox.Location = new System.Drawing.Point(179, 125);
            this.DniTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DniTextbox.Name = "DniTextbox";
            this.DniTextbox.Size = new System.Drawing.Size(120, 30);
            this.DniTextbox.TabIndex = 4;
            // 
            // EmailTextbox
            // 
            this.EmailTextbox.Location = new System.Drawing.Point(179, 205);
            this.EmailTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EmailTextbox.Name = "EmailTextbox";
            this.EmailTextbox.Size = new System.Drawing.Size(240, 30);
            this.EmailTextbox.TabIndex = 6;
            // 
            // FechaNacimientoDTP
            // 
            this.FechaNacimientoDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaNacimientoDTP.Location = new System.Drawing.Point(179, 165);
            this.FechaNacimientoDTP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FechaNacimientoDTP.Name = "FechaNacimientoDTP";
            this.FechaNacimientoDTP.Size = new System.Drawing.Size(120, 30);
            this.FechaNacimientoDTP.TabIndex = 5;
            // 
            // AltaButton
            // 
            this.AltaButton.Location = new System.Drawing.Point(744, 269);
            this.AltaButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AltaButton.Name = "AltaButton";
            this.AltaButton.Size = new System.Drawing.Size(125, 35);
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
            this.ListadoDGV.Location = new System.Drawing.Point(14, 15);
            this.ListadoDGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ListadoDGV.Name = "ListadoDGV";
            this.ListadoDGV.ReadOnly = true;
            this.ListadoDGV.RowHeadersWidth = 51;
            this.ListadoDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListadoDGV.Size = new System.Drawing.Size(675, 244);
            this.ListadoDGV.TabIndex = 9;
            // 
            // ModificacionButton
            // 
            this.ModificacionButton.Location = new System.Drawing.Point(875, 269);
            this.ModificacionButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ModificacionButton.Name = "ModificacionButton";
            this.ModificacionButton.Size = new System.Drawing.Size(125, 35);
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
            this.VehiculosDGV.Location = new System.Drawing.Point(12, 267);
            this.VehiculosDGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.VehiculosDGV.Name = "VehiculosDGV";
            this.VehiculosDGV.ReadOnly = true;
            this.VehiculosDGV.RowHeadersWidth = 51;
            this.VehiculosDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.VehiculosDGV.Size = new System.Drawing.Size(675, 244);
            this.VehiculosDGV.TabIndex = 10;
            // 
            // ClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 532);
            this.Controls.Add(this.VehiculosDGV);
            this.Controls.Add(this.ModificacionButton);
            this.Controls.Add(this.ListadoDGV);
            this.Controls.Add(this.AltaButton);
            this.Controls.Add(this.DetallePanel);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "ClienteForm";
            this.Text = "ClienteForm";
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
        private System.Windows.Forms.TextBox NombreTextbox;
        private System.Windows.Forms.TextBox ApellidoTextbox;
        private System.Windows.Forms.TextBox DniTextbox;
        private System.Windows.Forms.TextBox EmailTextbox;
        private System.Windows.Forms.DateTimePicker FechaNacimientoDTP;
        private System.Windows.Forms.Button AltaButton;
        private System.Windows.Forms.DataGridView ListadoDGV;
        private System.Windows.Forms.Button ModificacionButton;
        private System.Windows.Forms.DataGridView VehiculosDGV;
    }
}