namespace LUG.SegundoParcial
{
    partial class StreamingABMForm
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
            if (disposing && (components != null)) {
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
            this.textBoxDuracion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonLive = new System.Windows.Forms.RadioButton();
            this.radioButtonVod = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxTipoReproduccion = new System.Windows.Forms.ComboBox();
            this.labelTipoReproduccion = new System.Windows.Forms.Label();
            this.labelFechaTransmicion = new System.Windows.Forms.Label();
            this.fechaTransmicion = new System.Windows.Forms.DateTimePicker();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxDuracion
            // 
            this.textBoxDuracion.Location = new System.Drawing.Point(205, 7);
            this.textBoxDuracion.Name = "textBoxDuracion";
            this.textBoxDuracion.Size = new System.Drawing.Size(100, 20);
            this.textBoxDuracion.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Duracion";
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(367, 6);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCategoria.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Categoria";
            // 
            // radioButtonLive
            // 
            this.radioButtonLive.AutoSize = true;
            this.radioButtonLive.Location = new System.Drawing.Point(12, 64);
            this.radioButtonLive.Name = "radioButtonLive";
            this.radioButtonLive.Size = new System.Drawing.Size(45, 17);
            this.radioButtonLive.TabIndex = 4;
            this.radioButtonLive.TabStop = true;
            this.radioButtonLive.Text = "Live";
            this.radioButtonLive.UseVisualStyleBackColor = true;
            this.radioButtonLive.Click += new System.EventHandler(this.RadioButtonTipo_Checked);
            // 
            // radioButtonVod
            // 
            this.radioButtonVod.AutoSize = true;
            this.radioButtonVod.Location = new System.Drawing.Point(12, 92);
            this.radioButtonVod.Name = "radioButtonVod";
            this.radioButtonVod.Size = new System.Drawing.Size(44, 17);
            this.radioButtonVod.TabIndex = 5;
            this.radioButtonVod.TabStop = true;
            this.radioButtonVod.Text = "Vod";
            this.radioButtonVod.UseVisualStyleBackColor = true;
            this.radioButtonVod.Click += new System.EventHandler(this.RadioButtonTipo_Checked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxTipoReproduccion);
            this.groupBox1.Controls.Add(this.labelTipoReproduccion);
            this.groupBox1.Controls.Add(this.labelFechaTransmicion);
            this.groupBox1.Controls.Add(this.fechaTransmicion);
            this.groupBox1.Location = new System.Drawing.Point(63, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 90);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // comboBoxTipoReproduccion
            // 
            this.comboBoxTipoReproduccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoReproduccion.FormattingEnabled = true;
            this.comboBoxTipoReproduccion.Location = new System.Drawing.Point(120, 55);
            this.comboBoxTipoReproduccion.Name = "comboBoxTipoReproduccion";
            this.comboBoxTipoReproduccion.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoReproduccion.TabIndex = 9;
            this.comboBoxTipoReproduccion.Visible = false;
            // 
            // labelTipoReproduccion
            // 
            this.labelTipoReproduccion.AutoSize = true;
            this.labelTipoReproduccion.Location = new System.Drawing.Point(6, 58);
            this.labelTipoReproduccion.Name = "labelTipoReproduccion";
            this.labelTipoReproduccion.Size = new System.Drawing.Size(108, 13);
            this.labelTipoReproduccion.TabIndex = 8;
            this.labelTipoReproduccion.Text = "Tipo de reproduccion";
            this.labelTipoReproduccion.Visible = false;
            // 
            // labelFechaTransmicion
            // 
            this.labelFechaTransmicion.AutoSize = true;
            this.labelFechaTransmicion.Location = new System.Drawing.Point(6, 25);
            this.labelFechaTransmicion.Name = "labelFechaTransmicion";
            this.labelFechaTransmicion.Size = new System.Drawing.Size(108, 13);
            this.labelFechaTransmicion.TabIndex = 7;
            this.labelFechaTransmicion.Text = "Fecha de transmicion";
            this.labelFechaTransmicion.Visible = false;
            // 
            // fechaTransmicion
            // 
            this.fechaTransmicion.Location = new System.Drawing.Point(120, 25);
            this.fechaTransmicion.Name = "fechaTransmicion";
            this.fechaTransmicion.Size = new System.Drawing.Size(200, 20);
            this.fechaTransmicion.TabIndex = 7;
            this.fechaTransmicion.Visible = false;
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(484, 38);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.ReadOnly = true;
            this.textBoxCodigo.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigo.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(424, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Codigo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(578, 150);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Accionar_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(403, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(484, 105);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(43, 7);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 13;
            // 
            // StreamingABMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 450);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radioButtonVod);
            this.Controls.Add(this.radioButtonLive);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDuracion);
            this.Name = "StreamingABMForm";
            this.Text = "Gestor Streaming";
            this.Load += new System.EventHandler(this.ClienteABMForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDuracion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonLive;
        private System.Windows.Forms.RadioButton radioButtonVod;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelFechaTransmicion;
        private System.Windows.Forms.DateTimePicker fechaTransmicion;
        private System.Windows.Forms.Label labelTipoReproduccion;
        private System.Windows.Forms.ComboBox comboBoxTipoReproduccion;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNombre;
    }
}