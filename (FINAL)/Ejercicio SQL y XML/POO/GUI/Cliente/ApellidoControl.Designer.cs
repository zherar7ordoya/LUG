namespace GUI
{
    partial class ApellidoControl
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
            this.ApellidoTextbox = new System.Windows.Forms.TextBox();
            this.ApellidoError = new System.Windows.Forms.ErrorProvider(this.components);
            this.ApellidoTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ApellidoError)).BeginInit();
            this.SuspendLayout();
            // 
            // ApellidoTextbox
            // 
            this.ApellidoTextbox.Location = new System.Drawing.Point(3, 3);
            this.ApellidoTextbox.Name = "ApellidoTextbox";
            this.ApellidoTextbox.Size = new System.Drawing.Size(210, 22);
            this.ApellidoTextbox.TabIndex = 0;
            // 
            // ApellidoError
            // 
            this.ApellidoError.ContainerControl = this;
            // 
            // ApellidoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ApellidoTextbox);
            this.Name = "ApellidoControl";
            this.Size = new System.Drawing.Size(240, 30);
            ((System.ComponentModel.ISupportInitialize)(this.ApellidoError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ApellidoTextbox;
        private System.Windows.Forms.ErrorProvider ApellidoError;
        private System.Windows.Forms.ToolTip ApellidoTip;
    }
}
