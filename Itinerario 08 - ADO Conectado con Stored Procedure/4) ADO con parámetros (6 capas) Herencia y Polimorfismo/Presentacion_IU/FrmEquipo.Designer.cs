
namespace Presentacion_IU
{
    partial class FrmEquipo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.BuscarPuntajeButton = new System.Windows.Forms.Button();
            this.JugadoresDGV = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EquiposDGV = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.AgregarJugadorButton = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.TextBox6 = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.TextBox5 = new System.Windows.Forms.TextBox();
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.TecnicosCombobox = new System.Windows.Forms.ComboBox();
            this.TxtColoresEquipo = new System.Windows.Forms.TextBox();
            this.TxtNombreEquipo = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.AgregarEquipoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.JugadoresDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EquiposDGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(33, 438);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(45, 13);
            this.InfoLabel.TabIndex = 44;
            this.InfoLabel.Text = "Label14";
            // 
            // BuscarPuntajeButton
            // 
            this.BuscarPuntajeButton.Location = new System.Drawing.Point(36, 386);
            this.BuscarPuntajeButton.Name = "BuscarPuntajeButton";
            this.BuscarPuntajeButton.Size = new System.Drawing.Size(323, 23);
            this.BuscarPuntajeButton.TabIndex = 43;
            this.BuscarPuntajeButton.Text = "Buscar Equipo con Mayor Puntaje";
            this.BuscarPuntajeButton.UseVisualStyleBackColor = true;
            // 
            // JugadoresDGV
            // 
            this.JugadoresDGV.AllowUserToAddRows = false;
            this.JugadoresDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.JugadoresDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.JugadoresDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.JugadoresDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.JugadoresDGV.Location = new System.Drawing.Point(480, 191);
            this.JugadoresDGV.Name = "JugadoresDGV";
            this.JugadoresDGV.ReadOnly = true;
            this.JugadoresDGV.RowHeadersWidth = 62;
            this.JugadoresDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.JugadoresDGV.Size = new System.Drawing.Size(538, 189);
            this.JugadoresDGV.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(477, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Jugadores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(477, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Equipos";
            // 
            // EquiposDGV
            // 
            this.EquiposDGV.AllowUserToAddRows = false;
            this.EquiposDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.EquiposDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.EquiposDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.EquiposDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EquiposDGV.Location = new System.Drawing.Point(477, 20);
            this.EquiposDGV.Name = "EquiposDGV";
            this.EquiposDGV.ReadOnly = true;
            this.EquiposDGV.RowHeadersWidth = 62;
            this.EquiposDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EquiposDGV.Size = new System.Drawing.Size(541, 139);
            this.EquiposDGV.TabIndex = 39;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.TecnicosCombobox);
            this.groupBox1.Controls.Add(this.TxtColoresEquipo);
            this.groupBox1.Controls.Add(this.TxtNombreEquipo);
            this.groupBox1.Controls.Add(this.Label12);
            this.groupBox1.Controls.Add(this.Label11);
            this.groupBox1.Controls.Add(this.AgregarEquipoButton);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 369);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Equipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "DT";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Controls.Add(this.TextBox3);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TextBox2);
            this.groupBox2.Controls.Add(this.AgregarJugadorButton);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.Label15);
            this.groupBox2.Controls.Add(this.Label9);
            this.groupBox2.Controls.Add(this.TextBox6);
            this.groupBox2.Controls.Add(this.Label8);
            this.groupBox2.Controls.Add(this.Label7);
            this.groupBox2.Controls.Add(this.Label6);
            this.groupBox2.Controls.Add(this.TextBox5);
            this.groupBox2.Controls.Add(this.TextBox4);
            this.groupBox2.Controls.Add(this.TextBox1);
            this.groupBox2.Location = new System.Drawing.Point(16, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 229);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Jugadores";
            // 
            // TextBox3
            // 
            this.TextBox3.Location = new System.Drawing.Point(106, 79);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(299, 20);
            this.TextBox3.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "DNI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Apellido";
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(105, 49);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(299, 20);
            this.TextBox2.TabIndex = 12;
            // 
            // AgregarJugadorButton
            // 
            this.AgregarJugadorButton.Location = new System.Drawing.Point(10, 183);
            this.AgregarJugadorButton.Name = "AgregarJugadorButton";
            this.AgregarJugadorButton.Size = new System.Drawing.Size(394, 37);
            this.AgregarJugadorButton.TabIndex = 18;
            this.AgregarJugadorButton.Text = "Agregar Jugador";
            this.AgregarJugadorButton.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Profesional",
            "Principiante"});
            this.comboBox2.Location = new System.Drawing.Point(304, 140);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 17;
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(301, 114);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(52, 13);
            this.Label15.TabIndex = 14;
            this.Label15.Text = "Categoria";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(208, 114);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(34, 13);
            this.Label9.TabIndex = 15;
            this.Label9.Text = "Goles";
            // 
            // TextBox6
            // 
            this.TextBox6.Location = new System.Drawing.Point(211, 140);
            this.TextBox6.Name = "TextBox6";
            this.TextBox6.Size = new System.Drawing.Size(72, 20);
            this.TextBox6.TabIndex = 16;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(102, 114);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(89, 13);
            this.Label8.TabIndex = 9;
            this.Label8.Text = "Tarjetas Amarillas";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(7, 114);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(75, 13);
            this.Label7.TabIndex = 10;
            this.Label7.Text = "Tarjetas Rojas";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(37, 25);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(44, 13);
            this.Label6.TabIndex = 8;
            this.Label6.Text = "Nombre";
            // 
            // TextBox5
            // 
            this.TextBox5.Location = new System.Drawing.Point(105, 140);
            this.TextBox5.Name = "TextBox5";
            this.TextBox5.Size = new System.Drawing.Size(72, 20);
            this.TextBox5.TabIndex = 15;
            // 
            // TextBox4
            // 
            this.TextBox4.Location = new System.Drawing.Point(10, 141);
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.Size = new System.Drawing.Size(72, 20);
            this.TextBox4.TabIndex = 14;
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(105, 19);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(300, 20);
            this.TextBox1.TabIndex = 11;
            // 
            // TecnicosCombobox
            // 
            this.TecnicosCombobox.FormattingEnabled = true;
            this.TecnicosCombobox.Location = new System.Drawing.Point(117, 93);
            this.TecnicosCombobox.Name = "TecnicosCombobox";
            this.TecnicosCombobox.Size = new System.Drawing.Size(121, 21);
            this.TecnicosCombobox.TabIndex = 31;
            // 
            // TxtColoresEquipo
            // 
            this.TxtColoresEquipo.Location = new System.Drawing.Point(117, 57);
            this.TxtColoresEquipo.Name = "TxtColoresEquipo";
            this.TxtColoresEquipo.Size = new System.Drawing.Size(231, 20);
            this.TxtColoresEquipo.TabIndex = 27;
            // 
            // TxtNombreEquipo
            // 
            this.TxtNombreEquipo.Location = new System.Drawing.Point(117, 29);
            this.TxtNombreEquipo.Name = "TxtNombreEquipo";
            this.TxtNombreEquipo.Size = new System.Drawing.Size(231, 20);
            this.TxtNombreEquipo.TabIndex = 26;
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(13, 60);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(42, 13);
            this.Label12.TabIndex = 29;
            this.Label12.Text = "Colores";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(13, 29);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(97, 13);
            this.Label11.TabIndex = 30;
            this.Label11.Text = "Nombre del Equipo";
            // 
            // AgregarEquipoButton
            // 
            this.AgregarEquipoButton.Location = new System.Drawing.Point(354, 29);
            this.AgregarEquipoButton.Name = "AgregarEquipoButton";
            this.AgregarEquipoButton.Size = new System.Drawing.Size(86, 85);
            this.AgregarEquipoButton.TabIndex = 28;
            this.AgregarEquipoButton.Text = "Agregar Equipo";
            this.AgregarEquipoButton.UseVisualStyleBackColor = true;
            // 
            // FrmEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 456);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.BuscarPuntajeButton);
            this.Controls.Add(this.JugadoresDGV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EquiposDGV);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmEquipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equipo";
            this.Load += new System.EventHandler(this.FrmEquipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.JugadoresDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EquiposDGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label InfoLabel;
        internal System.Windows.Forms.Button BuscarPuntajeButton;
        public System.Windows.Forms.DataGridView JugadoresDGV;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView EquiposDGV;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Button AgregarJugadorButton;
        internal System.Windows.Forms.ComboBox comboBox2;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox TextBox6;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox TextBox5;
        internal System.Windows.Forms.TextBox TextBox4;
        internal System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.ComboBox TecnicosCombobox;
        internal System.Windows.Forms.TextBox TxtColoresEquipo;
        internal System.Windows.Forms.TextBox TxtNombreEquipo;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Button AgregarEquipoButton;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox TextBox2;
        internal System.Windows.Forms.TextBox TextBox3;
        internal System.Windows.Forms.Label label10;
    }
}