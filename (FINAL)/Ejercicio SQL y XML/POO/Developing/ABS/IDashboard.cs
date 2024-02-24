using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ABS
{
    public interface IDashboard
    {
        void CargarChartVehiculosMasRentadosPorTipo();
        void CargarChartVehiculosMasRentadosPorImporte();
        void CargarChartVehiculosMenosRentadosPorTipo();
        void CargarChartVehiculosMenosRentadosPorImporte();
        void CargarChartTotalRecaudadoPorTipo();
    }
}
