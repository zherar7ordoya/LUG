
namespace GUI
{
    partial class MenuForm
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
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SalirMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClienteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RentaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VehiculoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DashboardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AcercaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.entidadesToolStripMenuItem,
            this.verToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.MenuStrip.Size = new System.Drawing.Size(299, 25);
            this.MenuStrip.TabIndex = 1;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SalirMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 19);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // SalirMenuItem
            // 
            this.SalirMenuItem.Name = "SalirMenuItem";
            this.SalirMenuItem.Size = new System.Drawing.Size(96, 22);
            this.SalirMenuItem.Text = "Salir";
            // 
            // entidadesToolStripMenuItem
            // 
            this.entidadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClienteMenuItem,
            this.RentaMenuItem,
            this.VehiculoMenuItem});
            this.entidadesToolStripMenuItem.Name = "entidadesToolStripMenuItem";
            this.entidadesToolStripMenuItem.Size = new System.Drawing.Size(53, 19);
            this.entidadesToolStripMenuItem.Text = "Gestor";
            // 
            // ClienteMenuItem
            // 
            this.ClienteMenuItem.Name = "ClienteMenuItem";
            this.ClienteMenuItem.Size = new System.Drawing.Size(177, 22);
            this.ClienteMenuItem.Text = "Gestor de Clientes";
            // 
            // RentaMenuItem
            // 
            this.RentaMenuItem.Name = "RentaMenuItem";
            this.RentaMenuItem.Size = new System.Drawing.Size(177, 22);
            this.RentaMenuItem.Text = "Gestor de Rentas";
            // 
            // VehiculoMenuItem
            // 
            this.VehiculoMenuItem.Name = "VehiculoMenuItem";
            this.VehiculoMenuItem.Size = new System.Drawing.Size(177, 22);
            this.VehiculoMenuItem.Text = "Gestor de Vehículos";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DashboardMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(35, 19);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // DashboardMenuItem
            // 
            this.DashboardMenuItem.Name = "DashboardMenuItem";
            this.DashboardMenuItem.Size = new System.Drawing.Size(131, 22);
            this.DashboardMenuItem.Text = "Dashboard";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AcercaMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 19);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // AcercaMenuItem
            // 
            this.AcercaMenuItem.Name = "AcercaMenuItem";
            this.AcercaMenuItem.Size = new System.Drawing.Size(223, 22);
            this.AcercaMenuItem.Text = "Acerca de La Transportadora";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 156);
            this.Controls.Add(this.MenuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuStrip;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.Name = "MenuForm";
            this.Text = "Agencia de Transporte";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AcercaMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClienteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RentaMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VehiculoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DashboardMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SalirMenuItem;
    }
}