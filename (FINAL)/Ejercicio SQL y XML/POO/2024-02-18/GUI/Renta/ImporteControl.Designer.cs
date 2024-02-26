namespace GUI
{
    partial class ImporteControl
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
            this.ImporteTextbox = new System.Windows.Forms.TextBox();
            this.ImporteError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ImporteError)).BeginInit();
            this.SuspendLayout();
            // 
            // ImporteTextbox
            // 
            this.ImporteTextbox.Location = new System.Drawing.Point(0, 0);
            this.ImporteTextbox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ImporteTextbox.Name = "ImporteTextbox";
            this.ImporteTextbox.Size = new System.Drawing.Size(100, 30);
            this.ImporteTextbox.TabIndex = 0;
            // 
            // ImporteError
            // 
            this.ImporteError.ContainerControl = this;
            // 
            // ImporteControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ImporteTextbox);
            this.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ImporteControl";
            this.Size = new System.Drawing.Size(125, 30);
            ((System.ComponentModel.ISupportInitialize)(this.ImporteError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ImporteTextbox;
        private System.Windows.Forms.ErrorProvider ImporteError;
    }
}
