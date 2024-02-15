namespace GUI
{
    partial class ModeloControl
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
            this.ModeloError = new System.Windows.Forms.ErrorProvider(this.components);
            this.ModeloTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ModeloError)).BeginInit();
            this.SuspendLayout();
            // 
            // ModeloError
            // 
            this.ModeloError.ContainerControl = this;
            // 
            // ModeloTextbox
            // 
            this.ModeloTextbox.Location = new System.Drawing.Point(3, 3);
            this.ModeloTextbox.Name = "ModeloTextbox";
            this.ModeloTextbox.Size = new System.Drawing.Size(100, 20);
            this.ModeloTextbox.TabIndex = 0;
            // 
            // ModeloControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ModeloTextbox);
            this.Name = "ModeloControl";
            this.Size = new System.Drawing.Size(150, 26);
            ((System.ComponentModel.ISupportInitialize)(this.ModeloError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider ModeloError;
        private System.Windows.Forms.TextBox ModeloTextbox;
    }
}
