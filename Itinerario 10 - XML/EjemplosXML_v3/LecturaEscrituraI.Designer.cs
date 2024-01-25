namespace UI_XML
{
    partial class LecturaEscrituraI
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
            this.LeerDomButton = new System.Windows.Forms.Button();
            this.CrearXmlButton = new System.Windows.Forms.Button();
            this.ControlArbol = new System.Windows.Forms.TreeView();
            this.AbrirXmlButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeerDomButton
            // 
            this.LeerDomButton.Location = new System.Drawing.Point(28, 209);
            this.LeerDomButton.Name = "LeerDomButton";
            this.LeerDomButton.Size = new System.Drawing.Size(130, 23);
            this.LeerDomButton.TabIndex = 11;
            this.LeerDomButton.Text = "Leer XML usando DOM";
            this.LeerDomButton.UseVisualStyleBackColor = true;
            this.LeerDomButton.Click += new System.EventHandler(this.MostrarConXmlDocument);
            // 
            // CrearXmlButton
            // 
            this.CrearXmlButton.Location = new System.Drawing.Point(25, 103);
            this.CrearXmlButton.Name = "CrearXmlButton";
            this.CrearXmlButton.Size = new System.Drawing.Size(130, 23);
            this.CrearXmlButton.TabIndex = 10;
            this.CrearXmlButton.Text = "Crear Archivo XML";
            this.CrearXmlButton.UseVisualStyleBackColor = true;
            this.CrearXmlButton.Click += new System.EventHandler(this.CrearXml);
            // 
            // ControlArbol
            // 
            this.ControlArbol.Location = new System.Drawing.Point(249, 12);
            this.ControlArbol.Name = "ControlArbol";
            this.ControlArbol.Size = new System.Drawing.Size(251, 240);
            this.ControlArbol.TabIndex = 9;
            // 
            // AbrirXmlButton
            // 
            this.AbrirXmlButton.Location = new System.Drawing.Point(13, 12);
            this.AbrirXmlButton.Name = "AbrirXmlButton";
            this.AbrirXmlButton.Size = new System.Drawing.Size(130, 23);
            this.AbrirXmlButton.TabIndex = 8;
            this.AbrirXmlButton.Text = "Abrir Archivo XML";
            this.AbrirXmlButton.UseVisualStyleBackColor = true;
            this.AbrirXmlButton.Click += new System.EventHandler(this.AbrirXml);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.CrearXmlButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 136);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escritura";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(71, 73);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(123, 20);
            this.textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(71, 46);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(123, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI";
            // 
            // LecturaEscrituraI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 286);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LeerDomButton);
            this.Controls.Add(this.ControlArbol);
            this.Controls.Add(this.AbrirXmlButton);
            this.Name = "LecturaEscrituraI";
            this.Text = "LecturaEscrituraI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button LeerDomButton;
        internal System.Windows.Forms.Button CrearXmlButton;
        internal System.Windows.Forms.TreeView ControlArbol;
        internal System.Windows.Forms.Button AbrirXmlButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}