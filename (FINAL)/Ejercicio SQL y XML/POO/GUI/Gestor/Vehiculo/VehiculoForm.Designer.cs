namespace GUI
{
    partial class VehiculoForm
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
            this.CancelarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CodigoTextbox = new System.Windows.Forms.TextBox();
            this.MarcaControl = new GUI.MarcaControl();
            this.ModeloControl = new GUI.ModeloControl();
            this.label2 = new System.Windows.Forms.Label();
            this.PatenteControl = new GUI.PatenteControl();
            this.TipoCombobox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // ListadoDgv
            // 
            this.ListadoDgv.AllowUserToAddRows = false;
            this.ListadoDgv.AllowUserToDeleteRows = false;
            this.ListadoDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ListadoDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadoDgv.Location = new System.Drawing.Point(12, 12);
            this.ListadoDgv.Name = "ListadoDgv";
            this.ListadoDgv.ReadOnly = true;
            this.ListadoDgv.RowHeadersWidth = 51;
            this.ListadoDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListadoDgv.Size = new System.Drawing.Size(484, 209);
            this.ListadoDgv.TabIndex = 0;
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(502, 191);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(80, 30);
            this.CancelarButton.TabIndex = 3;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Visible = false;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(588, 191);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(80, 30);
            this.GuardarButton.TabIndex = 4;
            this.GuardarButton.Text = "Alta";
            this.GuardarButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(524, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(524, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marca";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(523, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Modelo";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(523, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Patente";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CodigoTextbox
            // 
            this.CodigoTextbox.Enabled = false;
            this.CodigoTextbox.Location = new System.Drawing.Point(592, 16);
            this.CodigoTextbox.Name = "CodigoTextbox";
            this.CodigoTextbox.Size = new System.Drawing.Size(54, 25);
            this.CodigoTextbox.TabIndex = 6;
            // 
            // MarcaControl
            // 
            this.MarcaControl.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarcaControl.Location = new System.Drawing.Point(592, 79);
            this.MarcaControl.Marca = "";
            this.MarcaControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MarcaControl.Name = "MarcaControl";
            this.MarcaControl.Size = new System.Drawing.Size(120, 29);
            this.MarcaControl.TabIndex = 7;
            // 
            // ModeloControl
            // 
            this.ModeloControl.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModeloControl.Location = new System.Drawing.Point(592, 115);
            this.ModeloControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ModeloControl.Modelo = "";
            this.ModeloControl.Name = "ModeloControl";
            this.ModeloControl.Size = new System.Drawing.Size(120, 29);
            this.ModeloControl.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(524, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PatenteControl
            // 
            this.PatenteControl.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatenteControl.Location = new System.Drawing.Point(592, 152);
            this.PatenteControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PatenteControl.Name = "PatenteControl";
            this.PatenteControl.Patente = "";
            this.PatenteControl.Size = new System.Drawing.Size(120, 31);
            this.PatenteControl.TabIndex = 9;
            // 
            // TipoCombobox
            // 
            this.TipoCombobox.FormattingEnabled = true;
            this.TipoCombobox.Location = new System.Drawing.Point(592, 47);
            this.TipoCombobox.Name = "TipoCombobox";
            this.TipoCombobox.Size = new System.Drawing.Size(102, 26);
            this.TipoCombobox.TabIndex = 5;
            // 
            // VehiculoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 241);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListadoDgv);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.ModeloControl);
            this.Controls.Add(this.PatenteControl);
            this.Controls.Add(this.MarcaControl);
            this.Controls.Add(this.CodigoTextbox);
            this.Controls.Add(this.TipoCombobox);
            this.Name = "VehiculoForm";
            this.Text = "Gestor de Vehículos";
            ((System.ComponentModel.ISupportInitialize)(this.ListadoDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ListadoDgv;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox TipoCombobox;
        public System.Windows.Forms.TextBox CodigoTextbox;
        public MarcaControl MarcaControl;
        public ModeloControl ModeloControl;
        public PatenteControl PatenteControl;
    }
}