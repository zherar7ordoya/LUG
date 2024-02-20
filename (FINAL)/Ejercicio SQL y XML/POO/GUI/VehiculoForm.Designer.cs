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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
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
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListadoDgv
            // 
            this.ListadoDgv.AllowUserToAddRows = false;
            this.ListadoDgv.AllowUserToDeleteRows = false;
            this.ListadoDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ListadoDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListadoDgv.Location = new System.Drawing.Point(14, 15);
            this.ListadoDgv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ListadoDgv.Name = "ListadoDgv";
            this.ListadoDgv.ReadOnly = true;
            this.ListadoDgv.RowHeadersWidth = 51;
            this.ListadoDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListadoDgv.Size = new System.Drawing.Size(549, 233);
            this.ListadoDgv.TabIndex = 0;
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(644, 255);
            this.CancelarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(90, 37);
            this.CancelarButton.TabIndex = 3;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Visible = false;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(740, 255);
            this.GuardarButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(90, 37);
            this.GuardarButton.TabIndex = 4;
            this.GuardarButton.Text = "Alta";
            this.GuardarButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.CodigoTextbox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.MarcaControl, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ModeloControl, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.PatenteControl, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.TipoCombobox, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(569, 15);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(304, 233);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Modelo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Patente";
            // 
            // CodigoTextbox
            // 
            this.CodigoTextbox.Enabled = false;
            this.CodigoTextbox.Location = new System.Drawing.Point(78, 4);
            this.CodigoTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CodigoTextbox.Name = "CodigoTextbox";
            this.CodigoTextbox.Size = new System.Drawing.Size(60, 30);
            this.CodigoTextbox.TabIndex = 6;
            // 
            // MarcaControl
            // 
            this.MarcaControl.Location = new System.Drawing.Point(79, 97);
            this.MarcaControl.Marca = "";
            this.MarcaControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MarcaControl.Name = "MarcaControl";
            this.MarcaControl.Size = new System.Drawing.Size(219, 36);
            this.MarcaControl.TabIndex = 7;
            // 
            // ModeloControl
            // 
            this.ModeloControl.Location = new System.Drawing.Point(79, 143);
            this.ModeloControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ModeloControl.Modelo = "";
            this.ModeloControl.Name = "ModeloControl";
            this.ModeloControl.Size = new System.Drawing.Size(219, 36);
            this.ModeloControl.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo";
            // 
            // PatenteControl
            // 
            this.PatenteControl.Location = new System.Drawing.Point(79, 189);
            this.PatenteControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PatenteControl.Name = "PatenteControl";
            this.PatenteControl.Patente = "";
            this.PatenteControl.Size = new System.Drawing.Size(218, 38);
            this.PatenteControl.TabIndex = 9;
            // 
            // TipoCombobox
            // 
            this.TipoCombobox.FormattingEnabled = true;
            this.TipoCombobox.Location = new System.Drawing.Point(78, 50);
            this.TipoCombobox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TipoCombobox.Name = "TipoCombobox";
            this.TipoCombobox.Size = new System.Drawing.Size(186, 30);
            this.TipoCombobox.TabIndex = 5;
            // 
            // VehiculoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 320);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.ListadoDgv);
            this.Controls.Add(this.CancelarButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VehiculoForm";
            this.Text = "VehiculoForm";
            this.Load += new System.EventHandler(this.VehiculoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListadoDgv)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ListadoDgv;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
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