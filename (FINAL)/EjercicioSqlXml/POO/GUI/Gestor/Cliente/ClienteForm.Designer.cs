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
            ((System.ComponentModel.ISupportInitialize)(this.ListadoDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VehiculosDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(526, 180);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(526, 215);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(526, 248);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(526, 282);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "DNI";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(526, 318);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fec. Nac.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(526, 343);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "E-mail";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // CodigoTextbox
            // 
            this.CodigoTextbox.Enabled = false;
            this.CodigoTextbox.Location = new System.Drawing.Point(609, 180);
            this.CodigoTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.CodigoTextbox.Name = "CodigoTextbox";
            this.CodigoTextbox.Size = new System.Drawing.Size(50, 25);
            this.CodigoTextbox.TabIndex = 1;
            // 
            // FechaNacimientoDtp
            // 
            this.FechaNacimientoDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaNacimientoDtp.Location = new System.Drawing.Point(609, 314);
            this.FechaNacimientoDtp.Margin = new System.Windows.Forms.Padding(4);
            this.FechaNacimientoDtp.Name = "FechaNacimientoDtp";
            this.FechaNacimientoDtp.Size = new System.Drawing.Size(100, 25);
            this.FechaNacimientoDtp.TabIndex = 5;
            // 
            // NombreControl
            // 
            this.NombreControl.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreControl.Location = new System.Drawing.Point(609, 211);
            this.NombreControl.Margin = new System.Windows.Forms.Padding(2);
            this.NombreControl.Name = "NombreControl";
            this.NombreControl.Nombre = "";
            this.NombreControl.Size = new System.Drawing.Size(127, 30);
            this.NombreControl.TabIndex = 2;
            // 
            // ApellidoControl
            // 
            this.ApellidoControl.Apellido = "";
            this.ApellidoControl.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApellidoControl.Location = new System.Drawing.Point(609, 244);
            this.ApellidoControl.Margin = new System.Windows.Forms.Padding(2);
            this.ApellidoControl.Name = "ApellidoControl";
            this.ApellidoControl.Size = new System.Drawing.Size(127, 30);
            this.ApellidoControl.TabIndex = 3;
            // 
            // DniControl
            // 
            this.DniControl.Dni = "";
            this.DniControl.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DniControl.Location = new System.Drawing.Point(609, 278);
            this.DniControl.Margin = new System.Windows.Forms.Padding(2);
            this.DniControl.Name = "DniControl";
            this.DniControl.Size = new System.Drawing.Size(127, 30);
            this.DniControl.TabIndex = 4;
            // 
            // EmailControl
            // 
            this.EmailControl.Email = "";
            this.EmailControl.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailControl.Location = new System.Drawing.Point(529, 370);
            this.EmailControl.Margin = new System.Windows.Forms.Padding(2);
            this.EmailControl.Name = "EmailControl";
            this.EmailControl.Size = new System.Drawing.Size(207, 30);
            this.EmailControl.TabIndex = 6;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(609, 406);
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
            this.ListadoDgv.Size = new System.Drawing.Size(694, 161);
            this.ListadoDgv.TabIndex = 9;
            // 
            // VehiculosDgv
            // 
            this.VehiculosDgv.AllowUserToAddRows = false;
            this.VehiculosDgv.AllowUserToDeleteRows = false;
            this.VehiculosDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.VehiculosDgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.VehiculosDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VehiculosDgv.Location = new System.Drawing.Point(12, 180);
            this.VehiculosDgv.Name = "VehiculosDgv";
            this.VehiculosDgv.ReadOnly = true;
            this.VehiculosDgv.RowHeadersWidth = 51;
            this.VehiculosDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.VehiculosDgv.Size = new System.Drawing.Size(479, 216);
            this.VehiculosDgv.TabIndex = 10;
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(501, 406);
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
            this.ClientSize = new System.Drawing.Size(742, 447);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.ListadoDgv);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.EmailControl);
            this.Controls.Add(this.FechaNacimientoDtp);
            this.Controls.Add(this.CodigoTextbox);
            this.Controls.Add(this.DniControl);
            this.Controls.Add(this.ApellidoControl);
            this.Controls.Add(this.NombreControl);
            this.Controls.Add(this.VehiculosDgv);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ClienteForm";
            this.Text = "Gestor de Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.ListadoDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VehiculosDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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