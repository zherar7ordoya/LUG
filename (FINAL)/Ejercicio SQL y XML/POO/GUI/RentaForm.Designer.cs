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
            this.ClientePanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CodigoClienteTextbox = new System.Windows.Forms.TextBox();
            this.FechaNacimientoDtp = new System.Windows.Forms.DateTimePicker();
            this.NombreControl = new GUI.NombreControl();
            this.ApellidoControl = new GUI.ApellidoControl();
            this.DniControl = new GUI.DniControl();
            this.EmailControl = new GUI.EmailControl();
            this.VehiculoPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CodigoVehiculoTextbox = new System.Windows.Forms.TextBox();
            this.MarcaControl = new GUI.MarcaControl();
            this.ModeloControl = new GUI.ModeloControl();
            this.label11 = new System.Windows.Forms.Label();
            this.PatenteControl = new GUI.PatenteControl();
            this.TipoCombobox = new System.Windows.Forms.ComboBox();
            this.DiasRentadosNumeric = new System.Windows.Forms.NumericUpDown();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.CodigoRentaTextbox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ImporteControl = new GUI.ImporteControl();
            this.ManualCheckbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VehiculosDgv)).BeginInit();
            this.ClientePanel.SuspendLayout();
            this.VehiculoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiasRentadosNumeric)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListadoDgv
            // 
            this.ListadoDgv.AllowUserToAddRows = false;
            this.ListadoDgv.AllowUserToDeleteRows = false;
            this.ListadoDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ListadoDgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.ListadoDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadoDgv.Location = new System.Drawing.Point(260, 13);
            this.ListadoDgv.Name = "ListadoDgv";
            this.ListadoDgv.ReadOnly = true;
            this.ListadoDgv.RowHeadersWidth = 51;
            this.ListadoDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListadoDgv.Size = new System.Drawing.Size(627, 180);
            this.ListadoDgv.TabIndex = 0;
            // 
            // ClientesDgv
            // 
            this.ClientesDgv.AllowUserToAddRows = false;
            this.ClientesDgv.AllowUserToDeleteRows = false;
            this.ClientesDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ClientesDgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.ClientesDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientesDgv.Location = new System.Drawing.Point(12, 200);
            this.ClientesDgv.MultiSelect = false;
            this.ClientesDgv.Name = "ClientesDgv";
            this.ClientesDgv.ReadOnly = true;
            this.ClientesDgv.RowHeadersWidth = 51;
            this.ClientesDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientesDgv.Size = new System.Drawing.Size(241, 180);
            this.ClientesDgv.TabIndex = 1;
            // 
            // VehiculosDgv
            // 
            this.VehiculosDgv.AllowUserToAddRows = false;
            this.VehiculosDgv.AllowUserToDeleteRows = false;
            this.VehiculosDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.VehiculosDgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.VehiculosDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VehiculosDgv.Location = new System.Drawing.Point(893, 202);
            this.VehiculosDgv.Name = "VehiculosDgv";
            this.VehiculosDgv.ReadOnly = true;
            this.VehiculosDgv.RowHeadersWidth = 51;
            this.VehiculosDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.VehiculosDgv.Size = new System.Drawing.Size(236, 180);
            this.VehiculosDgv.TabIndex = 2;
            // 
            // ClientePanel
            // 
            this.ClientePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientePanel.ColumnCount = 2;
            this.ClientePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.ClientePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.ClientePanel.Controls.Add(this.label1, 0, 0);
            this.ClientePanel.Controls.Add(this.label2, 0, 1);
            this.ClientePanel.Controls.Add(this.label3, 0, 2);
            this.ClientePanel.Controls.Add(this.label4, 0, 3);
            this.ClientePanel.Controls.Add(this.label5, 0, 4);
            this.ClientePanel.Controls.Add(this.label6, 0, 5);
            this.ClientePanel.Controls.Add(this.CodigoClienteTextbox, 1, 0);
            this.ClientePanel.Controls.Add(this.FechaNacimientoDtp, 1, 4);
            this.ClientePanel.Controls.Add(this.NombreControl, 1, 1);
            this.ClientePanel.Controls.Add(this.ApellidoControl, 1, 2);
            this.ClientePanel.Controls.Add(this.DniControl, 1, 3);
            this.ClientePanel.Controls.Add(this.EmailControl, 1, 5);
            this.ClientePanel.Enabled = false;
            this.ClientePanel.Location = new System.Drawing.Point(13, 13);
            this.ClientePanel.Margin = new System.Windows.Forms.Padding(4);
            this.ClientePanel.Name = "ClientePanel";
            this.ClientePanel.RowCount = 6;
            this.ClientePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ClientePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ClientePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ClientePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ClientePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ClientePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.ClientePanel.Size = new System.Drawing.Size(240, 180);
            this.ClientePanel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(4, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(4, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "DNI";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(4, 116);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nacimiento";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(4, 145);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "E-mail";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CodigoClienteTextbox
            // 
            this.CodigoClienteTextbox.Enabled = false;
            this.CodigoClienteTextbox.Location = new System.Drawing.Point(100, 4);
            this.CodigoClienteTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.CodigoClienteTextbox.Name = "CodigoClienteTextbox";
            this.CodigoClienteTextbox.Size = new System.Drawing.Size(50, 25);
            this.CodigoClienteTextbox.TabIndex = 1;
            // 
            // FechaNacimientoDtp
            // 
            this.FechaNacimientoDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaNacimientoDtp.Location = new System.Drawing.Point(100, 120);
            this.FechaNacimientoDtp.Margin = new System.Windows.Forms.Padding(4);
            this.FechaNacimientoDtp.Name = "FechaNacimientoDtp";
            this.FechaNacimientoDtp.Size = new System.Drawing.Size(100, 25);
            this.FechaNacimientoDtp.TabIndex = 5;
            // 
            // NombreControl
            // 
            this.NombreControl.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreControl.Location = new System.Drawing.Point(98, 31);
            this.NombreControl.Margin = new System.Windows.Forms.Padding(2);
            this.NombreControl.Name = "NombreControl";
            this.NombreControl.Nombre = "";
            this.NombreControl.Size = new System.Drawing.Size(125, 25);
            this.NombreControl.TabIndex = 2;
            // 
            // ApellidoControl
            // 
            this.ApellidoControl.Apellido = "";
            this.ApellidoControl.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApellidoControl.Location = new System.Drawing.Point(98, 60);
            this.ApellidoControl.Margin = new System.Windows.Forms.Padding(2);
            this.ApellidoControl.Name = "ApellidoControl";
            this.ApellidoControl.Size = new System.Drawing.Size(125, 25);
            this.ApellidoControl.TabIndex = 3;
            // 
            // DniControl
            // 
            this.DniControl.Dni = "";
            this.DniControl.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DniControl.Location = new System.Drawing.Point(98, 89);
            this.DniControl.Margin = new System.Windows.Forms.Padding(2);
            this.DniControl.Name = "DniControl";
            this.DniControl.Size = new System.Drawing.Size(125, 25);
            this.DniControl.TabIndex = 4;
            // 
            // EmailControl
            // 
            this.EmailControl.Email = "";
            this.EmailControl.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailControl.Location = new System.Drawing.Point(98, 147);
            this.EmailControl.Margin = new System.Windows.Forms.Padding(2);
            this.EmailControl.Name = "EmailControl";
            this.EmailControl.Size = new System.Drawing.Size(125, 25);
            this.EmailControl.TabIndex = 6;
            // 
            // VehiculoPanel
            // 
            this.VehiculoPanel.ColumnCount = 2;
            this.VehiculoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.VehiculoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.VehiculoPanel.Controls.Add(this.label7, 0, 0);
            this.VehiculoPanel.Controls.Add(this.label8, 0, 2);
            this.VehiculoPanel.Controls.Add(this.label9, 0, 3);
            this.VehiculoPanel.Controls.Add(this.label10, 0, 4);
            this.VehiculoPanel.Controls.Add(this.CodigoVehiculoTextbox, 1, 0);
            this.VehiculoPanel.Controls.Add(this.MarcaControl, 1, 2);
            this.VehiculoPanel.Controls.Add(this.ModeloControl, 1, 3);
            this.VehiculoPanel.Controls.Add(this.label11, 0, 1);
            this.VehiculoPanel.Controls.Add(this.PatenteControl, 1, 4);
            this.VehiculoPanel.Controls.Add(this.TipoCombobox, 1, 1);
            this.VehiculoPanel.Enabled = false;
            this.VehiculoPanel.Location = new System.Drawing.Point(893, 13);
            this.VehiculoPanel.Name = "VehiculoPanel";
            this.VehiculoPanel.RowCount = 5;
            this.VehiculoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.VehiculoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.VehiculoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.VehiculoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.VehiculoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.VehiculoPanel.Size = new System.Drawing.Size(240, 180);
            this.VehiculoPanel.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Código";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(3, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "Marca";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(3, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "Modelo";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(3, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 25);
            this.label10.TabIndex = 4;
            this.label10.Text = "Patente";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CodigoVehiculoTextbox
            // 
            this.CodigoVehiculoTextbox.Enabled = false;
            this.CodigoVehiculoTextbox.Location = new System.Drawing.Point(99, 3);
            this.CodigoVehiculoTextbox.Name = "CodigoVehiculoTextbox";
            this.CodigoVehiculoTextbox.Size = new System.Drawing.Size(50, 25);
            this.CodigoVehiculoTextbox.TabIndex = 6;
            // 
            // MarcaControl
            // 
            this.MarcaControl.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarcaControl.Location = new System.Drawing.Point(100, 76);
            this.MarcaControl.Marca = "";
            this.MarcaControl.Margin = new System.Windows.Forms.Padding(4);
            this.MarcaControl.Name = "MarcaControl";
            this.MarcaControl.Size = new System.Drawing.Size(125, 25);
            this.MarcaControl.TabIndex = 7;
            // 
            // ModeloControl
            // 
            this.ModeloControl.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModeloControl.Location = new System.Drawing.Point(100, 112);
            this.ModeloControl.Margin = new System.Windows.Forms.Padding(4);
            this.ModeloControl.Modelo = "";
            this.ModeloControl.Name = "ModeloControl";
            this.ModeloControl.Size = new System.Drawing.Size(125, 25);
            this.ModeloControl.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(3, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 25);
            this.label11.TabIndex = 1;
            this.label11.Text = "Tipo";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PatenteControl
            // 
            this.PatenteControl.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatenteControl.Location = new System.Drawing.Point(100, 148);
            this.PatenteControl.Margin = new System.Windows.Forms.Padding(4);
            this.PatenteControl.Name = "PatenteControl";
            this.PatenteControl.Patente = "";
            this.PatenteControl.Size = new System.Drawing.Size(125, 25);
            this.PatenteControl.TabIndex = 9;
            // 
            // TipoCombobox
            // 
            this.TipoCombobox.FormattingEnabled = true;
            this.TipoCombobox.Location = new System.Drawing.Point(99, 39);
            this.TipoCombobox.Name = "TipoCombobox";
            this.TipoCombobox.Size = new System.Drawing.Size(100, 26);
            this.TipoCombobox.TabIndex = 5;
            // 
            // DiasRentadosNumeric
            // 
            this.DiasRentadosNumeric.Location = new System.Drawing.Point(119, 38);
            this.DiasRentadosNumeric.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DiasRentadosNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DiasRentadosNumeric.Name = "DiasRentadosNumeric";
            this.DiasRentadosNumeric.Size = new System.Drawing.Size(50, 25);
            this.DiasRentadosNumeric.TabIndex = 7;
            this.DiasRentadosNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(556, 353);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(107, 29);
            this.CancelarButton.TabIndex = 14;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Visible = false;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(668, 353);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(107, 29);
            this.GuardarButton.TabIndex = 13;
            this.GuardarButton.Text = "Alta";
            this.GuardarButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel2.Controls.Add(this.CalcularButton, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label13, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.CodigoRentaTextbox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.DiasRentadosNumeric, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label14, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.ImporteControl, 1, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(373, 200);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(258, 146);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // CalcularButton
            // 
            this.CalcularButton.Location = new System.Drawing.Point(119, 75);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(89, 29);
            this.CalcularButton.TabIndex = 16;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(3, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 25);
            this.label13.TabIndex = 18;
            this.label13.Text = "Días rentados";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CodigoRentaTextbox
            // 
            this.CodigoRentaTextbox.Enabled = false;
            this.CodigoRentaTextbox.Location = new System.Drawing.Point(119, 2);
            this.CodigoRentaTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CodigoRentaTextbox.Name = "CodigoRentaTextbox";
            this.CodigoRentaTextbox.Size = new System.Drawing.Size(50, 25);
            this.CodigoRentaTextbox.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 25);
            this.label12.TabIndex = 17;
            this.label12.Text = "Código";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(3, 108);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 25);
            this.label14.TabIndex = 19;
            this.label14.Text = "Importe";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ImporteControl
            // 
            this.ImporteControl.Enabled = false;
            this.ImporteControl.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImporteControl.Importe = "";
            this.ImporteControl.Location = new System.Drawing.Point(120, 113);
            this.ImporteControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ImporteControl.Name = "ImporteControl";
            this.ImporteControl.Size = new System.Drawing.Size(125, 25);
            this.ImporteControl.TabIndex = 20;
            // 
            // ManualCheckbox
            // 
            this.ManualCheckbox.AutoSize = true;
            this.ManualCheckbox.Location = new System.Drawing.Point(636, 316);
            this.ManualCheckbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ManualCheckbox.Name = "ManualCheckbox";
            this.ManualCheckbox.Size = new System.Drawing.Size(126, 22);
            this.ManualCheckbox.TabIndex = 16;
            this.ManualCheckbox.Text = "Importe manual";
            this.ManualCheckbox.UseVisualStyleBackColor = true;
            // 
            // RentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 402);
            this.Controls.Add(this.ManualCheckbox);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.VehiculoPanel);
            this.Controls.Add(this.ClientePanel);
            this.Controls.Add(this.VehiculosDgv);
            this.Controls.Add(this.ClientesDgv);
            this.Controls.Add(this.ListadoDgv);
            this.Name = "RentaForm";
            this.Text = "RentaForm";
            this.Load += new System.EventHandler(this.RentaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListadoDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VehiculosDgv)).EndInit();
            this.ClientePanel.ResumeLayout(false);
            this.ClientePanel.PerformLayout();
            this.VehiculoPanel.ResumeLayout(false);
            this.VehiculoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiasRentadosNumeric)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ListadoDgv;
        private System.Windows.Forms.DataGridView ClientesDgv;
        private System.Windows.Forms.DataGridView VehiculosDgv;
        private System.Windows.Forms.TableLayoutPanel ClientePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox CodigoClienteTextbox;
        public System.Windows.Forms.DateTimePicker FechaNacimientoDtp;
        public NombreControl NombreControl;
        public ApellidoControl ApellidoControl;
        public DniControl DniControl;
        public EmailControl EmailControl;
        private System.Windows.Forms.TableLayoutPanel VehiculoPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox CodigoVehiculoTextbox;
        public MarcaControl MarcaControl;
        public ModeloControl ModeloControl;
        private System.Windows.Forms.Label label11;
        public PatenteControl PatenteControl;
        public System.Windows.Forms.ComboBox TipoCombobox;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button CalcularButton;
        private System.Windows.Forms.CheckBox ManualCheckbox;
        public System.Windows.Forms.NumericUpDown DiasRentadosNumeric;
        public System.Windows.Forms.TextBox CodigoRentaTextbox;
        public ImporteControl ImporteControl;
    }
}