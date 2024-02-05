namespace WindowsFormsApp1
{
    partial class WelcomePage
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
            this.BotonAceptar = new System.Windows.Forms.Button();
            this.BotonCancelar = new System.Windows.Forms.Button();
            this.Cbox = new System.Windows.Forms.ComboBox();
            this.EtiquetaContador = new System.Windows.Forms.Label();
            this.BotonIncrementar = new System.Windows.Forms.Button();
            this.BotonGuardar = new System.Windows.Forms.Button();
            this.BotonActualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BotonAceptar
            // 
            this.BotonAceptar.AutoSize = true;
            this.BotonAceptar.Location = new System.Drawing.Point(9, 96);
            this.BotonAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.BotonAceptar.Name = "BotonAceptar";
            this.BotonAceptar.Size = new System.Drawing.Size(56, 26);
            this.BotonAceptar.TabIndex = 0;
            this.BotonAceptar.Text = "Aceptar";
            this.BotonAceptar.UseVisualStyleBackColor = true;
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.AutoSize = true;
            this.BotonCancelar.Location = new System.Drawing.Point(10, 127);
            this.BotonCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Size = new System.Drawing.Size(59, 26);
            this.BotonCancelar.TabIndex = 1;
            this.BotonCancelar.Text = "Cancelar";
            this.BotonCancelar.UseVisualStyleBackColor = true;
            // 
            // Cbox
            // 
            this.Cbox.FormattingEnabled = true;
            this.Cbox.Items.AddRange(new object[] {
            "Türkçe",
            "English",
            "Español"});
            this.Cbox.Location = new System.Drawing.Point(10, 11);
            this.Cbox.Margin = new System.Windows.Forms.Padding(2);
            this.Cbox.Name = "Cbox";
            this.Cbox.Size = new System.Drawing.Size(131, 21);
            this.Cbox.TabIndex = 2;
            this.Cbox.SelectedIndexChanged += new System.EventHandler(this.Cbox_SelectedIndexChanged);
            // 
            // EtiquetaContador
            // 
            this.EtiquetaContador.AutoSize = true;
            this.EtiquetaContador.Location = new System.Drawing.Point(11, 183);
            this.EtiquetaContador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EtiquetaContador.Name = "EtiquetaContador";
            this.EtiquetaContador.Size = new System.Drawing.Size(50, 13);
            this.EtiquetaContador.TabIndex = 3;
            this.EtiquetaContador.Text = "Contador";
            // 
            // BotonIncrementar
            // 
            this.BotonIncrementar.Location = new System.Drawing.Point(137, 127);
            this.BotonIncrementar.Margin = new System.Windows.Forms.Padding(2);
            this.BotonIncrementar.Name = "BotonIncrementar";
            this.BotonIncrementar.Size = new System.Drawing.Size(91, 26);
            this.BotonIncrementar.TabIndex = 4;
            this.BotonIncrementar.Text = "Incrementar";
            this.BotonIncrementar.UseVisualStyleBackColor = true;
            this.BotonIncrementar.Click += new System.EventHandler(this.BotonIncrementar_Click);
            // 
            // BotonGuardar
            // 
            this.BotonGuardar.Location = new System.Drawing.Point(10, 35);
            this.BotonGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.BotonGuardar.Name = "BotonGuardar";
            this.BotonGuardar.Size = new System.Drawing.Size(56, 26);
            this.BotonGuardar.TabIndex = 5;
            this.BotonGuardar.Text = "Guardar";
            this.BotonGuardar.UseVisualStyleBackColor = true;
            this.BotonGuardar.Click += new System.EventHandler(this.BotonGuardar_Click);
            // 
            // BotonActualizar
            // 
            this.BotonActualizar.Location = new System.Drawing.Point(83, 35);
            this.BotonActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.BotonActualizar.Name = "BotonActualizar";
            this.BotonActualizar.Size = new System.Drawing.Size(75, 26);
            this.BotonActualizar.TabIndex = 6;
            this.BotonActualizar.Text = "Actualizar";
            this.BotonActualizar.UseVisualStyleBackColor = true;
            this.BotonActualizar.Click += new System.EventHandler(this.BotonActualizar_Click);
            // 
            // WelcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 215);
            this.Controls.Add(this.BotonActualizar);
            this.Controls.Add(this.BotonGuardar);
            this.Controls.Add(this.BotonIncrementar);
            this.Controls.Add(this.EtiquetaContador);
            this.Controls.Add(this.Cbox);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.BotonAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WelcomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WelcomePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonAceptar;
        private System.Windows.Forms.Button BotonCancelar;
        private System.Windows.Forms.ComboBox Cbox;
        private System.Windows.Forms.Label EtiquetaContador;
        private System.Windows.Forms.Button BotonIncrementar;
        private System.Windows.Forms.Button BotonGuardar;
        private System.Windows.Forms.Button BotonActualizar;
    }
}