namespace GUI
{
    partial class EmailControl
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
            this.EmailTextbox = new System.Windows.Forms.TextBox();
            this.EmailError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EmailError)).BeginInit();
            this.SuspendLayout();
            // 
            // EmailTextbox
            // 
            this.EmailTextbox.Location = new System.Drawing.Point(0, 0);
            this.EmailTextbox.Name = "EmailTextbox";
            this.EmailTextbox.Size = new System.Drawing.Size(180, 25);
            this.EmailTextbox.TabIndex = 0;
            // 
            // EmailError
            // 
            this.EmailError.ContainerControl = this;
            // 
            // EmailControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EmailTextbox);
            this.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EmailControl";
            this.Size = new System.Drawing.Size(200, 25);
            ((System.ComponentModel.ISupportInitialize)(this.EmailError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmailTextbox;
        private System.Windows.Forms.ErrorProvider EmailError;
    }
}
