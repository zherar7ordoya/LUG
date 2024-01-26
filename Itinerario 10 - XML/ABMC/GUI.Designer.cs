namespace ABMC
{
    partial class GUI
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
            this.PeliculasDGV = new System.Windows.Forms.DataGridView();
            this.DetalleTreeview = new System.Windows.Forms.TreeView();
            this.AltaButton = new System.Windows.Forms.Button();
            this.BajaButton = new System.Windows.Forms.Button();
            this.ModificacionButton = new System.Windows.Forms.Button();
            this.ConsultaButton = new System.Windows.Forms.Button();
            this.ConsultaTextbox = new System.Windows.Forms.TextBox();
            this.TituloRadio = new System.Windows.Forms.RadioButton();
            this.ActorRadio = new System.Windows.Forms.RadioButton();
            this.AñoRadio = new System.Windows.Forms.RadioButton();
            this.ActoresDGV = new System.Windows.Forms.DataGridView();
            this.FiltradoGroup = new System.Windows.Forms.GroupBox();
            this.ProduccionGroup = new System.Windows.Forms.GroupBox();
            this.DistribuidoraTextbox = new System.Windows.Forms.TextBox();
            this.AñoEstrenoTextbox = new System.Windows.Forms.TextBox();
            this.DistribuidoraLabel = new System.Windows.Forms.Label();
            this.EstrenoLabel = new System.Windows.Forms.Label();
            this.TituloTextbox = new System.Windows.Forms.TextBox();
            this.TituloLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PeliculasDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActoresDGV)).BeginInit();
            this.FiltradoGroup.SuspendLayout();
            this.ProduccionGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // PeliculasDGV
            // 
            this.PeliculasDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PeliculasDGV.Location = new System.Drawing.Point(12, 12);
            this.PeliculasDGV.Name = "PeliculasDGV";
            this.PeliculasDGV.Size = new System.Drawing.Size(432, 150);
            this.PeliculasDGV.TabIndex = 0;
            // 
            // DetalleTreeview
            // 
            this.DetalleTreeview.Location = new System.Drawing.Point(450, 168);
            this.DetalleTreeview.Name = "DetalleTreeview";
            this.DetalleTreeview.Size = new System.Drawing.Size(240, 255);
            this.DetalleTreeview.TabIndex = 1;
            // 
            // AltaButton
            // 
            this.AltaButton.Location = new System.Drawing.Point(19, 168);
            this.AltaButton.Name = "AltaButton";
            this.AltaButton.Size = new System.Drawing.Size(100, 35);
            this.AltaButton.TabIndex = 2;
            this.AltaButton.Text = "Alta";
            this.AltaButton.UseVisualStyleBackColor = true;
            // 
            // BajaButton
            // 
            this.BajaButton.Location = new System.Drawing.Point(19, 209);
            this.BajaButton.Name = "BajaButton";
            this.BajaButton.Size = new System.Drawing.Size(100, 35);
            this.BajaButton.TabIndex = 3;
            this.BajaButton.Text = "Baja";
            this.BajaButton.UseVisualStyleBackColor = true;
            // 
            // ModificacionButton
            // 
            this.ModificacionButton.Location = new System.Drawing.Point(19, 250);
            this.ModificacionButton.Name = "ModificacionButton";
            this.ModificacionButton.Size = new System.Drawing.Size(100, 35);
            this.ModificacionButton.TabIndex = 4;
            this.ModificacionButton.Text = "Modificacion";
            this.ModificacionButton.UseVisualStyleBackColor = true;
            // 
            // ConsultaButton
            // 
            this.ConsultaButton.Location = new System.Drawing.Point(6, 23);
            this.ConsultaButton.Name = "ConsultaButton";
            this.ConsultaButton.Size = new System.Drawing.Size(100, 35);
            this.ConsultaButton.TabIndex = 5;
            this.ConsultaButton.Text = "Consulta";
            this.ConsultaButton.UseVisualStyleBackColor = true;
            // 
            // ConsultaTextbox
            // 
            this.ConsultaTextbox.Location = new System.Drawing.Point(225, 23);
            this.ConsultaTextbox.Name = "ConsultaTextbox";
            this.ConsultaTextbox.Size = new System.Drawing.Size(187, 24);
            this.ConsultaTextbox.TabIndex = 6;
            // 
            // TituloRadio
            // 
            this.TituloRadio.AutoSize = true;
            this.TituloRadio.Location = new System.Drawing.Point(125, 23);
            this.TituloRadio.Name = "TituloRadio";
            this.TituloRadio.Size = new System.Drawing.Size(62, 22);
            this.TituloRadio.TabIndex = 7;
            this.TituloRadio.TabStop = true;
            this.TituloRadio.Text = "Título";
            this.TituloRadio.UseVisualStyleBackColor = true;
            // 
            // ActorRadio
            // 
            this.ActorRadio.AutoSize = true;
            this.ActorRadio.Location = new System.Drawing.Point(125, 51);
            this.ActorRadio.Name = "ActorRadio";
            this.ActorRadio.Size = new System.Drawing.Size(61, 22);
            this.ActorRadio.TabIndex = 8;
            this.ActorRadio.TabStop = true;
            this.ActorRadio.Text = "Actor";
            this.ActorRadio.UseVisualStyleBackColor = true;
            // 
            // AñoRadio
            // 
            this.AñoRadio.AutoSize = true;
            this.AñoRadio.Location = new System.Drawing.Point(125, 79);
            this.AñoRadio.Name = "AñoRadio";
            this.AñoRadio.Size = new System.Drawing.Size(52, 22);
            this.AñoRadio.TabIndex = 9;
            this.AñoRadio.TabStop = true;
            this.AñoRadio.Text = "Año";
            this.AñoRadio.UseVisualStyleBackColor = true;
            // 
            // ActoresDGV
            // 
            this.ActoresDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActoresDGV.Location = new System.Drawing.Point(450, 12);
            this.ActoresDGV.Name = "ActoresDGV";
            this.ActoresDGV.Size = new System.Drawing.Size(240, 150);
            this.ActoresDGV.TabIndex = 10;
            // 
            // FiltradoGroup
            // 
            this.FiltradoGroup.BackColor = System.Drawing.SystemColors.Control;
            this.FiltradoGroup.Controls.Add(this.ConsultaTextbox);
            this.FiltradoGroup.Controls.Add(this.TituloRadio);
            this.FiltradoGroup.Controls.Add(this.ConsultaButton);
            this.FiltradoGroup.Controls.Add(this.AñoRadio);
            this.FiltradoGroup.Controls.Add(this.ActorRadio);
            this.FiltradoGroup.Location = new System.Drawing.Point(13, 314);
            this.FiltradoGroup.Name = "FiltradoGroup";
            this.FiltradoGroup.Size = new System.Drawing.Size(431, 109);
            this.FiltradoGroup.TabIndex = 11;
            this.FiltradoGroup.TabStop = false;
            this.FiltradoGroup.Text = "Filtrado";
            // 
            // ProduccionGroup
            // 
            this.ProduccionGroup.Controls.Add(this.DistribuidoraTextbox);
            this.ProduccionGroup.Controls.Add(this.AñoEstrenoTextbox);
            this.ProduccionGroup.Controls.Add(this.DistribuidoraLabel);
            this.ProduccionGroup.Controls.Add(this.EstrenoLabel);
            this.ProduccionGroup.Location = new System.Drawing.Point(125, 209);
            this.ProduccionGroup.Name = "ProduccionGroup";
            this.ProduccionGroup.Size = new System.Drawing.Size(319, 99);
            this.ProduccionGroup.TabIndex = 12;
            this.ProduccionGroup.TabStop = false;
            this.ProduccionGroup.Text = "Producción";
            // 
            // DistribuidoraTextbox
            // 
            this.DistribuidoraTextbox.Location = new System.Drawing.Point(107, 55);
            this.DistribuidoraTextbox.Name = "DistribuidoraTextbox";
            this.DistribuidoraTextbox.Size = new System.Drawing.Size(200, 24);
            this.DistribuidoraTextbox.TabIndex = 3;
            // 
            // AñoEstrenoTextbox
            // 
            this.AñoEstrenoTextbox.Location = new System.Drawing.Point(107, 23);
            this.AñoEstrenoTextbox.Name = "AñoEstrenoTextbox";
            this.AñoEstrenoTextbox.Size = new System.Drawing.Size(100, 24);
            this.AñoEstrenoTextbox.TabIndex = 2;
            // 
            // DistribuidoraLabel
            // 
            this.DistribuidoraLabel.AutoSize = true;
            this.DistribuidoraLabel.Location = new System.Drawing.Point(10, 58);
            this.DistribuidoraLabel.Name = "DistribuidoraLabel";
            this.DistribuidoraLabel.Size = new System.Drawing.Size(91, 18);
            this.DistribuidoraLabel.TabIndex = 1;
            this.DistribuidoraLabel.Text = "Distribuidora";
            // 
            // EstrenoLabel
            // 
            this.EstrenoLabel.AutoSize = true;
            this.EstrenoLabel.Location = new System.Drawing.Point(10, 26);
            this.EstrenoLabel.Name = "EstrenoLabel";
            this.EstrenoLabel.Size = new System.Drawing.Size(60, 18);
            this.EstrenoLabel.TabIndex = 0;
            this.EstrenoLabel.Text = "Estreno";
            // 
            // TituloTextbox
            // 
            this.TituloTextbox.Location = new System.Drawing.Point(232, 179);
            this.TituloTextbox.Name = "TituloTextbox";
            this.TituloTextbox.Size = new System.Drawing.Size(200, 24);
            this.TituloTextbox.TabIndex = 13;
            // 
            // TituloLabel
            // 
            this.TituloLabel.AutoSize = true;
            this.TituloLabel.Location = new System.Drawing.Point(135, 182);
            this.TituloLabel.Name = "TituloLabel";
            this.TituloLabel.Size = new System.Drawing.Size(44, 18);
            this.TituloLabel.TabIndex = 14;
            this.TituloLabel.Text = "Título";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 441);
            this.Controls.Add(this.TituloLabel);
            this.Controls.Add(this.TituloTextbox);
            this.Controls.Add(this.ProduccionGroup);
            this.Controls.Add(this.FiltradoGroup);
            this.Controls.Add(this.ActoresDGV);
            this.Controls.Add(this.ModificacionButton);
            this.Controls.Add(this.BajaButton);
            this.Controls.Add(this.AltaButton);
            this.Controls.Add(this.DetalleTreeview);
            this.Controls.Add(this.PeliculasDGV);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GUI";
            this.Text = "ABMC";
            this.Load += new System.EventHandler(this.GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PeliculasDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActoresDGV)).EndInit();
            this.FiltradoGroup.ResumeLayout(false);
            this.FiltradoGroup.PerformLayout();
            this.ProduccionGroup.ResumeLayout(false);
            this.ProduccionGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PeliculasDGV;
        private System.Windows.Forms.TreeView DetalleTreeview;
        private System.Windows.Forms.Button AltaButton;
        private System.Windows.Forms.Button BajaButton;
        private System.Windows.Forms.Button ModificacionButton;
        private System.Windows.Forms.Button ConsultaButton;
        private System.Windows.Forms.TextBox ConsultaTextbox;
        private System.Windows.Forms.RadioButton TituloRadio;
        private System.Windows.Forms.RadioButton ActorRadio;
        private System.Windows.Forms.RadioButton AñoRadio;
        private System.Windows.Forms.DataGridView ActoresDGV;
        private System.Windows.Forms.GroupBox FiltradoGroup;
        private System.Windows.Forms.GroupBox ProduccionGroup;
        private System.Windows.Forms.Label DistribuidoraLabel;
        private System.Windows.Forms.Label EstrenoLabel;
        private System.Windows.Forms.TextBox DistribuidoraTextbox;
        private System.Windows.Forms.TextBox AñoEstrenoTextbox;
        private System.Windows.Forms.TextBox TituloTextbox;
        private System.Windows.Forms.Label TituloLabel;
    }
}

