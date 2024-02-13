namespace GUI
{
    partial class NombreControl
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
            this.NombreError = new System.Windows.Forms.ErrorProvider(this.components);
            this.NombreTextbox = new System.Windows.Forms.TextBox();
            this.NombreTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.NombreError)).BeginInit();
            this.SuspendLayout();
            // 
            // NombreError
            // 
            this.NombreError.ContainerControl = this;
            // 
            // NombreTextbox
            // 
            this.NombreTextbox.Location = new System.Drawing.Point(3, 3);
            this.NombreTextbox.Name = "NombreTextbox";
            this.NombreTextbox.Size = new System.Drawing.Size(210, 22);
            this.NombreTextbox.TabIndex = 0;
            // 
            // NombreControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NombreTextbox);
            this.Name = "NombreControl";
            this.Size = new System.Drawing.Size(240, 30);
            ((System.ComponentModel.ISupportInitialize)(this.NombreError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider NombreError;
        private System.Windows.Forms.TextBox NombreTextbox;
        private System.Windows.Forms.ToolTip NombreTip;
    }
}
