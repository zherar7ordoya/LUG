﻿namespace UI_XML
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ElegirArchivoButton = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // ElegirArchivoButton
            // 
            this.ElegirArchivoButton.AutoSize = true;
            this.ElegirArchivoButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ElegirArchivoButton.Location = new System.Drawing.Point(12, 12);
            this.ElegirArchivoButton.Name = "ElegirArchivoButton";
            this.ElegirArchivoButton.Size = new System.Drawing.Size(150, 28);
            this.ElegirArchivoButton.TabIndex = 0;
            this.ElegirArchivoButton.Text = "Cargar archivo XML";
            this.ElegirArchivoButton.UseVisualStyleBackColor = true;
            this.ElegirArchivoButton.Click += new System.EventHandler(this.CargarXML);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 46);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(292, 286);
            this.treeView1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 344);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.ElegirArchivoButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ElegirArchivoButton;
        private System.Windows.Forms.TreeView treeView1;
    }
}