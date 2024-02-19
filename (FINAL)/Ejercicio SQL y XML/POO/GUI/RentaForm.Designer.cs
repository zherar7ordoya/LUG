namespace GUI
{
    partial class RentaForm
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
            this.ListadoDgv = new System.Windows.Forms.DataGridView();
            this.ClientesDgv = new System.Windows.Forms.DataGridView();
            this.VehiculosDgv = new System.Windows.Forms.DataGridView();
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MarcaControl = new GUI.MarcaControl();
            this.ModeloControl = new GUI.ModeloControl();
            this.label11 = new System.Windows.Forms.Label();
            this.PatenteControl = new GUI.PatenteControl();
            this.TipoCombobox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VehiculosDgv)).BeginInit();
            this.DetallePanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListadoDgv
            // 
            this.ListadoDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadoDgv.Location = new System.Drawing.Point(415, 229);
            this.ListadoDgv.Name = "ListadoDgv";
            this.ListadoDgv.Size = new System.Drawing.Size(445, 150);
            this.ListadoDgv.TabIndex = 0;
            // 
            // ClientesDgv
            // 
            this.ClientesDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientesDgv.Location = new System.Drawing.Point(12, 12);
            this.ClientesDgv.Name = "ClientesDgv";
            this.ClientesDgv.Size = new System.Drawing.Size(240, 150);
            this.ClientesDgv.TabIndex = 1;
            // 
            // VehiculosDgv
            // 
            this.VehiculosDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VehiculosDgv.Location = new System.Drawing.Point(896, 12);
            this.VehiculosDgv.Name = "VehiculosDgv";
            this.VehiculosDgv.Size = new System.Drawing.Size(240, 150);
            this.VehiculosDgv.TabIndex = 2;
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
            this.DetallePanel.Location = new System.Drawing.Point(13, 229);
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
            this.DetallePanel.TabIndex = 3;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.MarcaControl, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ModeloControl, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.PatenteControl, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.TipoCombobox, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(866, 229);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(270, 191);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Código";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "Marca";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 18);
            this.label9.TabIndex = 3;
            this.label9.Text = "Modelo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 18);
            this.label10.TabIndex = 4;
            this.label10.Text = "Patente";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(66, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 25);
            this.textBox1.TabIndex = 6;
            // 
            // MarcaControl
            // 
            this.MarcaControl.Location = new System.Drawing.Point(66, 79);
            this.MarcaControl.Marca = "";
            this.MarcaControl.Name = "MarcaControl";
            this.MarcaControl.Size = new System.Drawing.Size(195, 32);
            this.MarcaControl.TabIndex = 7;
            // 
            // ModeloControl
            // 
            this.ModeloControl.Location = new System.Drawing.Point(66, 117);
            this.ModeloControl.Modelo = "";
            this.ModeloControl.Name = "ModeloControl";
            this.ModeloControl.Size = new System.Drawing.Size(195, 32);
            this.ModeloControl.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 18);
            this.label11.TabIndex = 1;
            this.label11.Text = "Tipo";
            // 
            // PatenteControl
            // 
            this.PatenteControl.Location = new System.Drawing.Point(67, 156);
            this.PatenteControl.Margin = new System.Windows.Forms.Padding(4);
            this.PatenteControl.Name = "PatenteControl";
            this.PatenteControl.Patente = "";
            this.PatenteControl.Size = new System.Drawing.Size(194, 31);
            this.PatenteControl.TabIndex = 9;
            // 
            // TipoCombobox
            // 
            this.TipoCombobox.FormattingEnabled = true;
            this.TipoCombobox.Location = new System.Drawing.Point(66, 41);
            this.TipoCombobox.Name = "TipoCombobox";
            this.TipoCombobox.Size = new System.Drawing.Size(166, 26);
            this.TipoCombobox.TabIndex = 5;
            // 
            // RentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.DetallePanel);
            this.Controls.Add(this.VehiculosDgv);
            this.Controls.Add(this.ClientesDgv);
            this.Controls.Add(this.ListadoDgv);
            this.Name = "RentaForm";
            this.Text = "RentaForm";
            ((System.ComponentModel.ISupportInitialize)(this.ListadoDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VehiculosDgv)).EndInit();
            this.DetallePanel.ResumeLayout(false);
            this.DetallePanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ListadoDgv;
        private System.Windows.Forms.DataGridView ClientesDgv;
        private System.Windows.Forms.DataGridView VehiculosDgv;
        private System.Windows.Forms.TableLayoutPanel DetallePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox CodigoTextbox;
        public System.Windows.Forms.DateTimePicker FechaNacimientoDtp;
        public NombreControl NombreControl;
        public ApellidoControl ApellidoControl;
        public DniControl DniControl;
        public EmailControl EmailControl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox textBox1;
        public MarcaControl MarcaControl;
        public ModeloControl ModeloControl;
        private System.Windows.Forms.Label label11;
        public PatenteControl PatenteControl;
        public System.Windows.Forms.ComboBox TipoCombobox;
    }
}