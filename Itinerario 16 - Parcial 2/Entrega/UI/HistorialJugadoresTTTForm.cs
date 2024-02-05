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

namespace UI
{
    public partial class HistorialJugadoresTTTForm : Form
    {
        BE.Historial BE_HISTORIAL;
        BLL.Historial BLL_HISTORIAL;

        public HistorialJugadoresTTTForm()
        {
            InitializeComponent();
            BE_HISTORIAL = new BE.Historial();
            BLL_HISTORIAL = new BLL.Historial();
        }

        private void HistorialJugadoresTTTForm_Load(object sender, EventArgs e)
        {
            EstadoCombobox.SelectedIndex = 0;
            CargarDatosXML();
        }

        void CargarDatosXML()
        {
            BE_HISTORIAL.ArchivoXML = "JugadoresHistorialTTT.xml";
            BarrasChart.DataSource = BLL_HISTORIAL.CargarDatosXML(BE_HISTORIAL);

            BarrasChart.Series[0].XValueMember = "Nombre";
            BarrasChart.Series[0].YValueMembers = EstadoCombobox.Text;
            BarrasChart.Series[0].LegendText = EstadoCombobox.Text;

            BarrasChart.Series[0].ChartType = SeriesChartType.StackedColumn;
            BarrasChart.DataBind();
        }

        private void EstadoCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDatosXML();
        }
    }
}
