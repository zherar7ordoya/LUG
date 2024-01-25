namespace UI_XML
{
    partial class Form1
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
            this.CargarArchivoButton = new System.Windows.Forms.Button();
            this.ControlArbol = new System.Windows.Forms.TreeView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.GuardarArchivoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CargarArchivoButton
            // 
            this.CargarArchivoButton.AutoSize = true;
            this.CargarArchivoButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CargarArchivoButton.Location = new System.Drawing.Point(12, 12);
            this.CargarArchivoButton.Name = "CargarArchivoButton";
            this.CargarArchivoButton.Size = new System.Drawing.Size(150, 28);
            this.CargarArchivoButton.TabIndex = 0;
            this.CargarArchivoButton.Text = "Cargar archivo XML";
            this.CargarArchivoButton.UseVisualStyleBackColor = true;
            // 
            // ControlArbol
            // 
            this.ControlArbol.Location = new System.Drawing.Point(12, 46);
            this.ControlArbol.Name = "ControlArbol";
            this.ControlArbol.Size = new System.Drawing.Size(292, 286);
            this.ControlArbol.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(367, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 24);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(367, 99);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 24);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(367, 160);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 24);
            this.textBox3.TabIndex = 4;
            // 
            // GuardarArchivoButton
            // 
            this.GuardarArchivoButton.AutoSize = true;
            this.GuardarArchivoButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GuardarArchivoButton.Location = new System.Drawing.Point(346, 221);
            this.GuardarArchivoButton.Name = "GuardarArchivoButton";
            this.GuardarArchivoButton.Size = new System.Drawing.Size(159, 28);
            this.GuardarArchivoButton.TabIndex = 5;
            this.GuardarArchivoButton.Text = "Guardar archivo XML";
            this.GuardarArchivoButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 371);
            this.Controls.Add(this.GuardarArchivoButton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ControlArbol);
            this.Controls.Add(this.CargarArchivoButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CargarArchivoButton;
        private System.Windows.Forms.TreeView ControlArbol;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button GuardarArchivoButton;
    }
}