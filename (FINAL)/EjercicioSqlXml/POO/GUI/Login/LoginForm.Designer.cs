namespace GUI
{
    partial class LoginForm
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
            this.EmailControl = new GUI.EmailControl();
            this.ClaveTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ValidarButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SalirButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmailControl
            // 
            this.EmailControl.Email = "";
            this.EmailControl.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailControl.Location = new System.Drawing.Point(39, 38);
            this.EmailControl.Margin = new System.Windows.Forms.Padding(4);
            this.EmailControl.Name = "EmailControl";
            this.EmailControl.Size = new System.Drawing.Size(206, 26);
            this.EmailControl.TabIndex = 0;
            // 
            // ClaveTextbox
            // 
            this.ClaveTextbox.Location = new System.Drawing.Point(39, 96);
            this.ClaveTextbox.Name = "ClaveTextbox";
            this.ClaveTextbox.PasswordChar = '*';
            this.ClaveTextbox.Size = new System.Drawing.Size(180, 25);
            this.ClaveTextbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "E-mail";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(36, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Clave";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ValidarButton
            // 
            this.ValidarButton.Enabled = false;
            this.ValidarButton.Location = new System.Drawing.Point(156, 145);
            this.ValidarButton.Name = "ValidarButton";
            this.ValidarButton.Size = new System.Drawing.Size(60, 30);
            this.ValidarButton.TabIndex = 4;
            this.ValidarButton.Text = "Validar";
            this.ValidarButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 171);
            this.label3.TabIndex = 5;
            this.label3.Text = "Escriba el mismo e-mail en ambos campos.\r\n\r\nEsto es un \"mock\" (simulador).\r\n\r\nEn " +
    "los métodos pertinentes de la BLL se puede examinar la encriptación, recupero (d" +
    "esde la base de datos) y validación.";
            // 
            // SalirButton
            // 
            this.SalirButton.Location = new System.Drawing.Point(39, 145);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(60, 30);
            this.SalirButton.TabIndex = 6;
            this.SalirButton.Text = "Salir";
            this.SalirButton.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 362);
            this.ControlBox = false;
            this.Controls.Add(this.SalirButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ValidarButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClaveTextbox);
            this.Controls.Add(this.EmailControl);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EmailControl EmailControl;
        private System.Windows.Forms.TextBox ClaveTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ValidarButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SalirButton;
    }
}