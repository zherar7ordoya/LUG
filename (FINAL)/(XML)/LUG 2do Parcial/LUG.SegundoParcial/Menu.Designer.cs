namespace LUG.SegundoParcial
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.streamingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contrataosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.streamingMayorDuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalRecaudadoPorCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.streamingsToolStripMenuItem,
            this.contrataosToolStripMenuItem,
            this.reporteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.ClientesToolStripMenuItem_Click);
            // 
            // streamingsToolStripMenuItem
            // 
            this.streamingsToolStripMenuItem.Name = "streamingsToolStripMenuItem";
            this.streamingsToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.streamingsToolStripMenuItem.Text = "Streamings";
            this.streamingsToolStripMenuItem.Click += new System.EventHandler(this.StreamingsToolStripMenuItem_Click);
            // 
            // contrataosToolStripMenuItem
            // 
            this.contrataosToolStripMenuItem.Name = "contrataosToolStripMenuItem";
            this.contrataosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.contrataosToolStripMenuItem.Text = "Contratos";
            this.contrataosToolStripMenuItem.Click += new System.EventHandler(this.ContrataosToolStripMenuItem_Click);
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.streamingMayorDuracionToolStripMenuItem,
            this.totalRecaudadoPorCategoriaToolStripMenuItem});
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.reporteToolStripMenuItem.Text = "Reporte";
            // 
            // streamingMayorDuracionToolStripMenuItem
            // 
            this.streamingMayorDuracionToolStripMenuItem.Name = "streamingMayorDuracionToolStripMenuItem";
            this.streamingMayorDuracionToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.streamingMayorDuracionToolStripMenuItem.Text = "Streaming duracion maxima/minima";
            this.streamingMayorDuracionToolStripMenuItem.Click += new System.EventHandler(this.StreamingMayorDuracionToolStripMenuItem_Click);
            // 
            // totalRecaudadoPorCategoriaToolStripMenuItem
            // 
            this.totalRecaudadoPorCategoriaToolStripMenuItem.Name = "totalRecaudadoPorCategoriaToolStripMenuItem";
            this.totalRecaudadoPorCategoriaToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.totalRecaudadoPorCategoriaToolStripMenuItem.Text = "Total recaudado por categoria";
            this.totalRecaudadoPorCategoriaToolStripMenuItem.Click += new System.EventHandler(this.TotalRecaudadoPorCategoriaToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Gestor de streaming";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem streamingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contrataosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem streamingMayorDuracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalRecaudadoPorCategoriaToolStripMenuItem;
    }
}

