namespace GUI
{
    partial class PatenteControl
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
            this.PatenteTextbox = new System.Windows.Forms.TextBox();
            this.PatenteError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PatenteError)).BeginInit();
            this.SuspendLayout();
            // 
            // PatenteTextbox
            // 
            this.PatenteTextbox.Location = new System.Drawing.Point(0, 0);
            this.PatenteTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PatenteTextbox.Name = "PatenteTextbox";
            this.PatenteTextbox.Size = new System.Drawing.Size(100, 25);
            this.PatenteTextbox.TabIndex = 0;
            // 
            // PatenteError
            // 
            this.PatenteError.ContainerControl = this;
            // 
            // PatenteControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PatenteTextbox);
            this.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PatenteControl";
            this.Size = new System.Drawing.Size(125, 25);
            ((System.ComponentModel.ISupportInitialize)(this.PatenteError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PatenteTextbox;
        private System.Windows.Forms.ErrorProvider PatenteError;
    }
}
