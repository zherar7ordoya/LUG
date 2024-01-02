using LUG.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LUG.SegundoParcial
{
    public partial class StreamingTotalRecaudadoForm : Form
    {
        private BLLStreamingReporte _bLLStreamingReporte;
        public StreamingTotalRecaudadoForm()
        {
            InitializeComponent();
            _bLLStreamingReporte = new BLLStreamingReporte();
        }

        private void StreamingTotalRecaudadoForm_Load(object sender, EventArgs e)
        {
            try {
                chart1.Titles.Add("Total recaudado agrupado por categoria");
                CargarData();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarData()
        {
            try {
                chart1.Series["s1"].Points.Clear();
                chart1.Series["s1"].IsValueShownAsLabel = true;
                foreach (var item in _bLLStreamingReporte.ObtenerTotalRecaudado()) {
                    chart1.Series["s1"].Points.AddXY(item.Key, item.Value.ToString());                    
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
