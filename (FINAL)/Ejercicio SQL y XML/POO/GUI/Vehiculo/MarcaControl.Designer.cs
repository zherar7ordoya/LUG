namespace GUI
{
    partial class MarcaControl
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
            this.MarcaError = new System.Windows.Forms.ErrorProvider(this.components);
            this.MarcaTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MarcaError)).BeginInit();
            this.SuspendLayout();
            // 
            // MarcaError
            // 
            this.MarcaError.ContainerControl = this;
            // 
            // MarcaTextbox
            // 
            this.MarcaTextbox.Location = new System.Drawing.Point(3, 3);
            this.MarcaTextbox.Name = "MarcaTextbox";
            this.MarcaTextbox.Size = new System.Drawing.Size(120, 20);
            this.MarcaTextbox.TabIndex = 0;
            // 
            // MarcaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MarcaTextbox);
            this.Name = "MarcaControl";
            this.Size = new System.Drawing.Size(150, 26);
            ((System.ComponentModel.ISupportInitialize)(this.MarcaError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider MarcaError;
        private System.Windows.Forms.TextBox MarcaTextbox;
    }
}
