namespace LUG.SegundoParcial
{
    partial class ContratacionForm
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
            this.comboBoxClientes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxStreaming = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxClientesConsultados = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxClientes
            // 
            this.comboBoxClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClientes.FormattingEnabled = true;
            this.comboBoxClientes.Location = new System.Drawing.Point(62, 12);
            this.comboBoxClientes.Name = "comboBoxClientes";
            this.comboBoxClientes.Size = new System.Drawing.Size(121, 21);
            this.comboBoxClientes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Servicios streaming";
            // 
            // comboBoxStreaming
            // 
            this.comboBoxStreaming.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStreaming.FormattingEnabled = true;
            this.comboBoxStreaming.Location = new System.Drawing.Point(308, 12);
            this.comboBoxStreaming.Name = "comboBoxStreaming";
            this.comboBoxStreaming.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStreaming.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(599, 322);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Accionar_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Consultar cliente:";
            // 
            // comboBoxClientesConsultados
            // 
            this.comboBoxClientesConsultados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClientesConsultados.FormattingEnabled = true;
            this.comboBoxClientesConsultados.Location = new System.Drawing.Point(97, 89);
            this.comboBoxClientesConsultados.Name = "comboBoxClientesConsultados";
            this.comboBoxClientesConsultados.Size = new System.Drawing.Size(121, 21);
            this.comboBoxClientesConsultados.TabIndex = 6;
            this.comboBoxClientesConsultados.SelectedIndexChanged += new System.EventHandler(this.comboBoxClientesConsultados_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(357, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Consultar contrataciones realizadas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(454, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Contratar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnContratar_Click);
            // 
            // ContratacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxClientesConsultados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxStreaming);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxClientes);
            this.Name = "ContratacionForm";
            this.Text = "Contrataciones";
            this.Load += new System.EventHandler(this.ContratacionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxStreaming;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxClientesConsultados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}