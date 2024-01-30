﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace UI_C
{
    public partial class frmArrays : Form
    {
        public frmArrays()
        {
            InitializeComponent();
        }

        private void frmArrays_Load(object sender, EventArgs e)
        {
            cargargraficoArray();
        }

        void cargargraficoArray()
        {
            //creo los array y le asigno valores
            double[] yValores = { 40, 3.125, 22.5, 6.25, 28.125 };
            string[] xNombres = { " Juan", " Pedro", " Martín", " Julio", " Aníbal" };
            //bindeo los valores con la serie del chart
            chart1.Series[0].Points.DataBindXY(xNombres, yValores);
            //digo q tipo de grafico quiero (pie= torta)
            chart1.Series[0].ChartType = SeriesChartType.Pie;
            //y si lo quiero en 3D
           chart1.ChartAreas[0].Area3DStyle.Enable3D = true;

        }

       
    }
}
