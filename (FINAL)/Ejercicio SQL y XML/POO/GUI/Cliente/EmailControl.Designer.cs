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
            this.EmailTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EmailError)).BeginInit();
            this.SuspendLayout();
            // 
            // EmailTextbox
            // 
            this.EmailTextbox.Location = new System.Drawing.Point(3, 3);
            this.EmailTextbox.Name = "EmailTextbox";
            this.EmailTextbox.Size = new System.Drawing.Size(210, 22);
            this.EmailTextbox.TabIndex = 0;
            // 
            // EmailError
            // 
            this.EmailError.ContainerControl = this;
            // 
            // EmailControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EmailTextbox);
            this.Name = "EmailControl";
            this.Size = new System.Drawing.Size(240, 30);
            ((System.ComponentModel.ISupportInitialize)(this.EmailError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmailTextbox;
        private System.Windows.Forms.ErrorProvider EmailError;
        private System.Windows.Forms.ToolTip EmailTip;
    }
}
