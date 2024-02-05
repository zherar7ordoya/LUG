
namespace GUI
{
    partial class MainForm
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
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.AlquilerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClienteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VehiculoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MasMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TotalMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AlquilerMenuItem,
            this.ClienteMenuItem,
            this.VehiculoMenuItem,
            this.MasMenuItem,
            this.MenosMenuItem,
            this.TotalMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.MenuStrip.Size = new System.Drawing.Size(834, 25);
            this.MenuStrip.TabIndex = 1;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // AlquilerMenuItem
            // 
            this.AlquilerMenuItem.Name = "AlquilerMenuItem";
            this.AlquilerMenuItem.Size = new System.Drawing.Size(89, 19);
            this.AlquilerMenuItem.Text = "ABM Alquiler";
            this.AlquilerMenuItem.Click += new System.EventHandler(this.AlquilerMenuItem_Click);
            // 
            // ClienteMenuItem
            // 
            this.ClienteMenuItem.Name = "ClienteMenuItem";
            this.ClienteMenuItem.Size = new System.Drawing.Size(85, 19);
            this.ClienteMenuItem.Text = "ABM Cliente";
            this.ClienteMenuItem.Click += new System.EventHandler(this.ClienteMenuItem_Click);
            // 
            // VehiculoMenuItem
            // 
            this.VehiculoMenuItem.Name = "VehiculoMenuItem";
            this.VehiculoMenuItem.Size = new System.Drawing.Size(93, 19);
            this.VehiculoMenuItem.Text = "ABM Vehículo";
            this.VehiculoMenuItem.Click += new System.EventHandler(this.VehiculoMenuItem_Click);
            // 
            // MasMenuItem
            // 
            this.MasMenuItem.Name = "MasMenuItem";
            this.MasMenuItem.Size = new System.Drawing.Size(153, 19);
            this.MasMenuItem.Text = "Vehículos Más Alquilados";
            this.MasMenuItem.Click += new System.EventHandler(this.MasMenuItem_Click);
            // 
            // MenosMenuItem
            // 
            this.MenosMenuItem.Name = "MenosMenuItem";
            this.MenosMenuItem.Size = new System.Drawing.Size(167, 19);
            this.MenosMenuItem.Text = "Vehículos Menos Alquilados";
            this.MenosMenuItem.Click += new System.EventHandler(this.MenosMenuItem_Click);
            // 
            // TotalMenuItem
            // 
            this.TotalMenuItem.Name = "TotalMenuItem";
            this.TotalMenuItem.Size = new System.Drawing.Size(155, 19);
            this.TotalMenuItem.Text = "Total por Tipo de Vehículo";
            this.TotalMenuItem.Click += new System.EventHandler(this.TotalMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 436);
            this.Controls.Add(this.MenuStrip);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agencia de Transporte";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AlquilerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClienteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VehiculoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MasMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenosMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TotalMenuItem;
    }
}