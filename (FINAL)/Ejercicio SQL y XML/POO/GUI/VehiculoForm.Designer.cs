﻿namespace GUI
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
            this.AltaButton = new System.Windows.Forms.Button();
            this.ModificacionButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TipoCombobox = new System.Windows.Forms.ComboBox();
            this.CodigoTextbox = new System.Windows.Forms.TextBox();
            this.MarcaControl = new GUI.MarcaControl();
            this.ModeloControl = new GUI.ModeloControl();
            this.label2 = new System.Windows.Forms.Label();
            this.PatenteControl = new GUI.PatenteControl();
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
            this.ListadoDgv.Location = new System.Drawing.Point(12, 12);
            this.ListadoDgv.Name = "ListadoDgv";
            this.ListadoDgv.ReadOnly = true;
            this.ListadoDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListadoDgv.Size = new System.Drawing.Size(488, 191);
            this.ListadoDgv.TabIndex = 0;
            // 
            // AltaButton
            // 
            this.AltaButton.Location = new System.Drawing.Point(461, 209);
            this.AltaButton.Name = "AltaButton";
            this.AltaButton.Size = new System.Drawing.Size(105, 30);
            this.AltaButton.TabIndex = 1;
            this.AltaButton.Text = "Alta";
            this.AltaButton.UseVisualStyleBackColor = true;
            // 
            // ModificacionButton
            // 
            this.ModificacionButton.Location = new System.Drawing.Point(572, 209);
            this.ModificacionButton.Name = "ModificacionButton";
            this.ModificacionButton.Size = new System.Drawing.Size(105, 30);
            this.ModificacionButton.TabIndex = 2;
            this.ModificacionButton.Text = "Modificación";
            this.ModificacionButton.UseVisualStyleBackColor = true;
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(461, 245);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(105, 30);
            this.CancelarButton.TabIndex = 3;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Visible = false;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(572, 245);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(105, 30);
            this.GuardarButton.TabIndex = 4;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Visible = false;
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
            this.tableLayoutPanel1.Controls.Add(this.TipoCombobox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.CodigoTextbox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.MarcaControl, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ModeloControl, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.PatenteControl, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(506, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(241, 191);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Modelo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Patente";
            // 
            // TipoCombobox
            // 
            this.TipoCombobox.FormattingEnabled = true;
            this.TipoCombobox.Location = new System.Drawing.Point(66, 41);
            this.TipoCombobox.Name = "TipoCombobox";
            this.TipoCombobox.Size = new System.Drawing.Size(135, 26);
            this.TipoCombobox.TabIndex = 5;
            // 
            // CodigoTextbox
            // 
            this.CodigoTextbox.Enabled = false;
            this.CodigoTextbox.Location = new System.Drawing.Point(66, 3);
            this.CodigoTextbox.Name = "CodigoTextbox";
            this.CodigoTextbox.Size = new System.Drawing.Size(135, 25);
            this.CodigoTextbox.TabIndex = 6;
            // 
            // MarcaControl
            // 
            this.MarcaControl.Location = new System.Drawing.Point(66, 79);
            this.MarcaControl.Marca = "";
            this.MarcaControl.Name = "MarcaControl";
            this.MarcaControl.Size = new System.Drawing.Size(174, 32);
            this.MarcaControl.TabIndex = 7;
            // 
            // ModeloControl
            // 
            this.ModeloControl.Location = new System.Drawing.Point(66, 117);
            this.ModeloControl.Modelo = "";
            this.ModeloControl.Name = "ModeloControl";
            this.ModeloControl.Size = new System.Drawing.Size(174, 32);
            this.ModeloControl.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo";
            // 
            // PatenteControl
            // 
            this.PatenteControl.Location = new System.Drawing.Point(67, 156);
            this.PatenteControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PatenteControl.Name = "PatenteControl";
            this.PatenteControl.Patente = "";
            this.PatenteControl.Size = new System.Drawing.Size(172, 31);
            this.PatenteControl.TabIndex = 9;
            // 
            // VehiculoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 287);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.ListadoDgv);
            this.Controls.Add(this.AltaButton);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.ModificacionButton);
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
        private System.Windows.Forms.Button AltaButton;
        private System.Windows.Forms.Button ModificacionButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox TipoCombobox;
        private System.Windows.Forms.TextBox CodigoTextbox;
        private MarcaControl MarcaControl;
        private ModeloControl ModeloControl;
        private PatenteControl PatenteControl;
    }
}