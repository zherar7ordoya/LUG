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
            this.DniTextbox.Location = new System.Drawing.Point(3, 2);
            this.DniTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DniTextbox.Name = "DniTextbox";
            this.DniTextbox.Size = new System.Drawing.Size(105, 22);
            this.DniTextbox.TabIndex = 0;
            // 
            // DniControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DniTextbox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DniControl";
            this.Size = new System.Drawing.Size(130, 30);
            ((System.ComponentModel.ISupportInitialize)(this.DniError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider DniError;
        private System.Windows.Forms.TextBox DniTextbox;
    }
}
