namespace WindowsFormsApplication1
{
    partial class TelefonoForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.telefonoControl1 = new WindowsFormsApplication1.TelefonoControl();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // telefonoControl1
            // 
            this.telefonoControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonoControl1.Location = new System.Drawing.Point(37, 42);
            this.telefonoControl1.Margin = new System.Windows.Forms.Padding(4);
            this.telefonoControl1.Name = "telefonoControl1";
            this.telefonoControl1.PhoneNumber = "(XXX) XXX-XXXX";
            this.telefonoControl1.Size = new System.Drawing.Size(225, 31);
            this.telefonoControl1.TabIndex = 2;
            // 
            // TelefonoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 172);
            this.Controls.Add(this.telefonoControl1);
            this.Controls.Add(this.button1);
            this.Name = "TelefonoForm";
            this.Text = "TelefonoForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private TelefonoControl telefonoControl1;
    }
}