namespace Charts
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.PuestosChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SueldosChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.PuestosChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SueldosChart)).BeginInit();
            this.SuspendLayout();
            // 
            // PuestosChart
            // 
            chartArea1.Name = "ChartArea1";
            this.PuestosChart.ChartAreas.Add(chartArea1);
            this.PuestosChart.Dock = System.Windows.Forms.DockStyle.Left;
            legend1.Name = "Legend1";
            this.PuestosChart.Legends.Add(legend1);
            this.PuestosChart.Location = new System.Drawing.Point(0, 0);
            this.PuestosChart.Name = "PuestosChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.PuestosChart.Series.Add(series1);
            this.PuestosChart.Size = new System.Drawing.Size(672, 450);
            this.PuestosChart.TabIndex = 0;
            this.PuestosChart.Text = "chart1";
            // 
            // SueldosChart
            // 
            chartArea2.Name = "ChartArea1";
            this.SueldosChart.ChartAreas.Add(chartArea2);
            this.SueldosChart.Dock = System.Windows.Forms.DockStyle.Right;
            legend2.Name = "Legend1";
            this.SueldosChart.Legends.Add(legend2);
            this.SueldosChart.Location = new System.Drawing.Point(700, 0);
            this.SueldosChart.Name = "SueldosChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.SueldosChart.Series.Add(series2);
            this.SueldosChart.Size = new System.Drawing.Size(672, 450);
            this.SueldosChart.TabIndex = 1;
            this.SueldosChart.Text = "chart2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 450);
            this.Controls.Add(this.SueldosChart);
            this.Controls.Add(this.PuestosChart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PuestosChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SueldosChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart PuestosChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart SueldosChart;
    }
}

