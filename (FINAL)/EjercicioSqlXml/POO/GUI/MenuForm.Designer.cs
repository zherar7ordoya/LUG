
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
            this.MenuBase = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SalirMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GestorMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ClienteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RentaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VehiculoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VerMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DashboardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClienteReportMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AcercaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CerrarSesionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuBase
            // 
            this.MenuBase.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.GestorMenu,
            this.VerMenu,
            this.ayudaToolStripMenuItem});
            this.MenuBase.Location = new System.Drawing.Point(0, 0);
            this.MenuBase.Name = "MenuBase";
            this.MenuBase.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.MenuBase.Size = new System.Drawing.Size(509, 30);
            this.MenuBase.TabIndex = 1;
            this.MenuBase.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CerrarSesionMenu,
            this.SalirMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // SalirMenuItem
            // 
            this.SalirMenuItem.Name = "SalirMenuItem";
            this.SalirMenuItem.Size = new System.Drawing.Size(180, 24);
            this.SalirMenuItem.Text = "Salir";
            // 
            // GestorMenu
            // 
            this.GestorMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClienteMenuItem,
            this.RentaMenuItem,
            this.VehiculoMenuItem});
            this.GestorMenu.Name = "GestorMenu";
            this.GestorMenu.Size = new System.Drawing.Size(64, 24);
            this.GestorMenu.Text = "Gestor";
            // 
            // ClienteMenuItem
            // 
            this.ClienteMenuItem.Name = "ClienteMenuItem";
            this.ClienteMenuItem.Size = new System.Drawing.Size(208, 24);
            this.ClienteMenuItem.Text = "Gestor de Clientes";
            // 
            // RentaMenuItem
            // 
            this.RentaMenuItem.Name = "RentaMenuItem";
            this.RentaMenuItem.Size = new System.Drawing.Size(208, 24);
            this.RentaMenuItem.Text = "Gestor de Rentas";
            // 
            // VehiculoMenuItem
            // 
            this.VehiculoMenuItem.Name = "VehiculoMenuItem";
            this.VehiculoMenuItem.Size = new System.Drawing.Size(208, 24);
            this.VehiculoMenuItem.Text = "Gestor de Vehículos";
            // 
            // VerMenu
            // 
            this.VerMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DashboardMenuItem,
            this.ClienteReportMenu});
            this.VerMenu.Name = "VerMenu";
            this.VerMenu.Size = new System.Drawing.Size(42, 24);
            this.VerMenu.Text = "Ver";
            // 
            // DashboardMenuItem
            // 
            this.DashboardMenuItem.Name = "DashboardMenuItem";
            this.DashboardMenuItem.Size = new System.Drawing.Size(205, 24);
            this.DashboardMenuItem.Text = "Dashboard";
            // 
            // ClienteReportMenu
            // 
            this.ClienteReportMenu.Name = "ClienteReportMenu";
            this.ClienteReportMenu.Size = new System.Drawing.Size(205, 24);
            this.ClienteReportMenu.Text = "Informe de clientes";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AcercaMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // AcercaMenuItem
            // 
            this.AcercaMenuItem.Name = "AcercaMenuItem";
            this.AcercaMenuItem.Size = new System.Drawing.Size(268, 24);
            this.AcercaMenuItem.Text = "Acerca de La Transportadora";
            // 
            // CerrarSesionMenu
            // 
            this.CerrarSesionMenu.Name = "CerrarSesionMenu";
            this.CerrarSesionMenu.Size = new System.Drawing.Size(180, 24);
            this.CerrarSesionMenu.Text = "Cerrar sesión";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 310);
            this.Controls.Add(this.MenuBase);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuBase;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.Name = "MenuForm";
            this.Text = "Agencia de Transporte";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MenuBase.ResumeLayout(false);
            this.MenuBase.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuBase;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VerMenu;
        private System.Windows.Forms.ToolStripMenuItem GestorMenu;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AcercaMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClienteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RentaMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VehiculoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DashboardMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SalirMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClienteReportMenu;
        private System.Windows.Forms.ToolStripMenuItem CerrarSesionMenu;
    }
}