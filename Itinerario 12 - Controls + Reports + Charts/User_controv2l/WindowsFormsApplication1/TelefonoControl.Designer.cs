namespace WindowsFormsApplication1
{
    partial class TelefonoControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TelefonoTextbox = new System.Windows.Forms.TextBox();
            this.TelefonoLabel = new System.Windows.Forms.Label();
            this.TelefonoError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TelefonoError)).BeginInit();
            this.SuspendLayout();
            // 
            // TelefonoTextbox
            // 
            this.TelefonoTextbox.Location = new System.Drawing.Point(75, 3);
            this.TelefonoTextbox.Name = "TelefonoTextbox";
            this.TelefonoTextbox.Size = new System.Drawing.Size(129, 24);
            this.TelefonoTextbox.TabIndex = 0;
            this.TelefonoTextbox.Text = "(XXX) XXX-XXXX";
            // 
            // TelefonoLabel
            // 
            this.TelefonoLabel.AutoSize = true;
            this.TelefonoLabel.Location = new System.Drawing.Point(3, 6);
            this.TelefonoLabel.Name = "TelefonoLabel";
            this.TelefonoLabel.Size = new System.Drawing.Size(66, 18);
            this.TelefonoLabel.TabIndex = 1;
            this.TelefonoLabel.Text = "Teléfono";
            // 
            // TelefonoError
            // 
            this.TelefonoError.ContainerControl = this;
            // 
            // TelefonoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TelefonoLabel);
            this.Controls.Add(this.TelefonoTextbox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TelefonoControl";
            this.Size = new System.Drawing.Size(225, 31);
            ((System.ComponentModel.ISupportInitialize)(this.TelefonoError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TelefonoTextbox;
        private System.Windows.Forms.Label TelefonoLabel;
        private System.Windows.Forms.ErrorProvider TelefonoError;
    }
}
