
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
            this.InfoLabel = new System.Windows.Forms.Label();
            this.BuscarEquipoButton = new System.Windows.Forms.Button();
            this.dataGridJugadores = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridEquipo = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.AgregarJugadorButton = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.TecnicosCombobox = new System.Windows.Forms.ComboBox();
            this.TxtColoresEquipo = new System.Windows.Forms.TextBox();
            this.TxtNombreEquipo = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.AgregarEquipoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridJugadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEquipo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(50, 674);
            this.InfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(66, 20);
            this.InfoLabel.TabIndex = 44;
            this.InfoLabel.Text = "Label14";
            // 
            // BuscarEquipoButton
            // 
            this.BuscarEquipoButton.Location = new System.Drawing.Point(54, 594);
            this.BuscarEquipoButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BuscarEquipoButton.Name = "BuscarEquipoButton";
            this.BuscarEquipoButton.Size = new System.Drawing.Size(484, 35);
            this.BuscarEquipoButton.TabIndex = 43;
            this.BuscarEquipoButton.Text = "Buscar Equipo con Mayor Puntaje";
            this.BuscarEquipoButton.UseVisualStyleBackColor = true;
            this.BuscarEquipoButton.Click += new System.EventHandler(this.Button3_Click);
            // 
            // dataGridJugadores
            // 
            this.dataGridJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridJugadores.Location = new System.Drawing.Point(720, 294);
            this.dataGridJugadores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridJugadores.Name = "dataGridJugadores";
            this.dataGridJugadores.RowHeadersWidth = 62;
            this.dataGridJugadores.Size = new System.Drawing.Size(807, 291);
            this.dataGridJugadores.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(716, 262);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Jugadores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(716, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Equipos";
            // 
            // dataGridEquipo
            // 
            this.dataGridEquipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEquipo.Location = new System.Drawing.Point(716, 31);
            this.dataGridEquipo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridEquipo.Name = "dataGridEquipo";
            this.dataGridEquipo.RowHeadersWidth = 62;
            this.dataGridEquipo.Size = new System.Drawing.Size(812, 214);
            this.dataGridEquipo.TabIndex = 39;
            this.dataGridEquipo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEquipo_CellContentClick);
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
            this.groupBox1.Location = new System.Drawing.Point(16, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(690, 568);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Equipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "DT";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.AgregarJugadorButton);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.Label15);
            this.groupBox2.Controls.Add(this.Label9);
            this.groupBox2.Controls.Add(this.TextBox4);
            this.groupBox2.Controls.Add(this.Label8);
            this.groupBox2.Controls.Add(this.Label7);
            this.groupBox2.Controls.Add(this.Label6);
            this.groupBox2.Controls.Add(this.TextBox3);
            this.groupBox2.Controls.Add(this.TextBox2);
            this.groupBox2.Controls.Add(this.TextBox1);
            this.groupBox2.Location = new System.Drawing.Point(24, 206);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(636, 352);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Jugadores";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(159, 122);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(446, 26);
            this.textBox6.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(66, 126);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "DNI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Apellido";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(158, 75);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(446, 26);
            this.textBox5.TabIndex = 19;
            // 
            // AgregarJugadorButton
            // 
            this.AgregarJugadorButton.Location = new System.Drawing.Point(15, 282);
            this.AgregarJugadorButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AgregarJugadorButton.Name = "AgregarJugadorButton";
            this.AgregarJugadorButton.Size = new System.Drawing.Size(591, 57);
            this.AgregarJugadorButton.TabIndex = 18;
            this.AgregarJugadorButton.Text = "Agregar Jugador";
            this.AgregarJugadorButton.UseVisualStyleBackColor = true;
            this.AgregarJugadorButton.Click += new System.EventHandler(this.Button2_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Profesional",
            "Principiante"});
            this.comboBox2.Location = new System.Drawing.Point(456, 215);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(148, 28);
            this.comboBox2.TabIndex = 17;
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(452, 175);
            this.Label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(78, 20);
            this.Label15.TabIndex = 14;
            this.Label15.Text = "Categoria";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(312, 175);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(51, 20);
            this.Label9.TabIndex = 15;
            this.Label9.Text = "Goles";
            // 
            // TextBox4
            // 
            this.TextBox4.Location = new System.Drawing.Point(316, 215);
            this.TextBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.Size = new System.Drawing.Size(106, 26);
            this.TextBox4.TabIndex = 16;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(153, 175);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(134, 20);
            this.Label8.TabIndex = 9;
            this.Label8.Text = "Tarjetas Amarillas";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(10, 175);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(111, 20);
            this.Label7.TabIndex = 10;
            this.Label7.Text = "Tarjetas Rojas";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(56, 38);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(65, 20);
            this.Label6.TabIndex = 8;
            this.Label6.Text = "Nombre";
            // 
            // TextBox3
            // 
            this.TextBox3.Location = new System.Drawing.Point(158, 215);
            this.TextBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(106, 26);
            this.TextBox3.TabIndex = 13;
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(15, 217);
            this.TextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(106, 26);
            this.TextBox2.TabIndex = 12;
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(158, 29);
            this.TextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(448, 26);
            this.TextBox1.TabIndex = 11;
            // 
            // TecnicosCombobox
            // 
            this.TecnicosCombobox.FormattingEnabled = true;
            this.TecnicosCombobox.Location = new System.Drawing.Point(176, 143);
            this.TecnicosCombobox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TecnicosCombobox.Name = "TecnicosCombobox";
            this.TecnicosCombobox.Size = new System.Drawing.Size(180, 28);
            this.TecnicosCombobox.TabIndex = 31;
            // 
            // TxtColoresEquipo
            // 
            this.TxtColoresEquipo.Location = new System.Drawing.Point(176, 88);
            this.TxtColoresEquipo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtColoresEquipo.Name = "TxtColoresEquipo";
            this.TxtColoresEquipo.Size = new System.Drawing.Size(344, 26);
            this.TxtColoresEquipo.TabIndex = 27;
            // 
            // TxtNombreEquipo
            // 
            this.TxtNombreEquipo.Location = new System.Drawing.Point(176, 45);
            this.TxtNombreEquipo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNombreEquipo.Name = "TxtNombreEquipo";
            this.TxtNombreEquipo.Size = new System.Drawing.Size(344, 26);
            this.TxtNombreEquipo.TabIndex = 26;
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(20, 92);
            this.Label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(63, 20);
            this.Label12.TabIndex = 29;
            this.Label12.Text = "Colores";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(20, 45);
            this.Label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(144, 20);
            this.Label11.TabIndex = 30;
            this.Label11.Text = "Nombre del Equipo";
            // 
            // AgregarEquipoButton
            // 
            this.AgregarEquipoButton.Location = new System.Drawing.Point(531, 45);
            this.AgregarEquipoButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AgregarEquipoButton.Name = "AgregarEquipoButton";
            this.AgregarEquipoButton.Size = new System.Drawing.Size(129, 131);
            this.AgregarEquipoButton.TabIndex = 28;
            this.AgregarEquipoButton.Text = "Agregar Equipo";
            this.AgregarEquipoButton.UseVisualStyleBackColor = true;
            this.AgregarEquipoButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // FrmEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1538, 708);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.BuscarEquipoButton);
            this.Controls.Add(this.dataGridJugadores);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridEquipo);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmEquipo";
            this.Text = "Equipo";
            this.Load += new System.EventHandler(this.FrmEquipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridJugadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEquipo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label InfoLabel;
        internal System.Windows.Forms.Button BuscarEquipoButton;
        public System.Windows.Forms.DataGridView dataGridJugadores;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dataGridEquipo;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Button AgregarJugadorButton;
        internal System.Windows.Forms.ComboBox comboBox2;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox TextBox4;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox TextBox3;
        internal System.Windows.Forms.TextBox TextBox2;
        internal System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.ComboBox TecnicosCombobox;
        internal System.Windows.Forms.TextBox TxtColoresEquipo;
        internal System.Windows.Forms.TextBox TxtNombreEquipo;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Button AgregarEquipoButton;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox textBox5;
        internal System.Windows.Forms.TextBox textBox6;
        internal System.Windows.Forms.Label label10;
    }
}