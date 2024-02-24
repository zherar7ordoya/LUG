namespace GUI
{
    partial class DniControl
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
            this.DniError = new System.Windows.Forms.ErrorProvider(this.components);
            this.DniTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DniError)).BeginInit();
            this.SuspendLayout();
            // 
            // DniError
            // 
            this.DniError.ContainerControl = this;
            // 
            // DniTextbox
            // 
            this.DniTextbox.Location = new System.Drawing.Point(0, 0);
            this.DniTextbox.Name = "DniTextbox";
            this.DniTextbox.Size = new System.Drawing.Size(100, 25);
            this.DniTextbox.TabIndex = 0;
            // 
            // DniControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DniTextbox);
            this.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DniControl";
            this.Size = new System.Drawing.Size(125, 25);
            ((System.ComponentModel.ISupportInitialize)(this.DniError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider DniError;
        private System.Windows.Forms.TextBox DniTextbox;
    }
}
