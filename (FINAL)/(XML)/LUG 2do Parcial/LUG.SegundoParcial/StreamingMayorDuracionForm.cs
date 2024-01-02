using LUG.BE;
using LUG.BLL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LUG.SegundoParcial
{
    public partial class StreamingMayorDuracionForm : Form
    {
        
        private BLLStreamingReporte _bLLStreamingReporte;
        public StreamingMayorDuracionForm()
        {
            InitializeComponent();
            _bLLStreamingReporte = new BLLStreamingReporte();
        }

        private void StreamingMayorDuracionForm_Load(object sender, EventArgs e)
        {
            try {
                chart1.Titles.Add("Streaming de mayor duracion por categoria");
                CargarData(false);                
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarData(bool minimo = false)
        {
            try {
                chart1.Series["s1"].Points.Clear();
                chart1.Series["s1"].IsValueShownAsLabel = true;
                int indice = 0;
                foreach (var item in _bLLStreamingReporte.ObtenerDuracion(minimo)) {
                    chart1.Series["s1"].Points.AddXY(item.Key, item.Value.ToString());
                    if (indice == 0)
                        chart1.Series["s1"].Points[indice].Color = Color.Red;
                    else if (indice == 1)
                        chart1.Series["s1"].Points[indice].Color = Color.Brown;
                    indice++;
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) {
                radioButton2.Checked = false;
                CargarData(false);
            } else {
                radioButton1.Checked = false;
                CargarData(true);
            }
        }
    }
}
