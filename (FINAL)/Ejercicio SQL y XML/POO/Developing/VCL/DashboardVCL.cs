using ABS;
using BLL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace VCL
{
    public class DashboardVCL
    {
        public void CargarDashboard(IDashboard formulario)
        {
            formulario.CargarChartVehiculosMasRentadosPorTipo();
            formulario.CargarChartVehiculosMasRentadosPorImporte();
            formulario.CargarChartVehiculosMenosRentadosPorTipo();
            formulario.CargarChartVehiculosMenosRentadosPorImporte();
            formulario.CargarChartTotalRecaudadoPorTipo();
        }

        public void CargarChartVehiculosMasRentadosPorTipo(Chart chart)
        {
            chart.DataSource = new RentaBLL().VehiculosMasRentadosPorTipo();
            chart.Series[0].XValueMember = "Key";
            chart.Series[0].YValueMembers = "Value";
            chart.Series[0].IsVisibleInLegend = false;
            chart.Titles.Add("Vehículos más rentados (por tipo)");
        }

        // Repite este patrón para las demás funciones de carga de gráficos.

        public void CargarChartVehiculosMasRentadosPorImporte(Chart chart)
        {
            chart.DataSource = new RentaBLL().VehiculosMasRentadosPorImporte();
            chart.Series[0].XValueMember = "Key";
            chart.Series[0].YValueMembers = "Value";
            chart.Series[0].ChartType = SeriesChartType.Pie;
            chart.Series[0].IsVisibleInLegend = false;
            chart.Titles.Add("Vehículos más rentados (por importe)");
        }

        public void CargarChartVehiculosMenosRentadosPorTipo(Chart chart)
        {
            chart.DataSource = new RentaBLL().VehiculosMenosRentadosPorTipo();
            chart.Series[0].XValueMember = "Key";
            chart.Series[0].YValueMembers = "Value";
            chart.Series[0].IsVisibleInLegend = false;
            chart.Titles.Add("Vehículos menos rentados (por tipo)");
        }

        public void CargarChartVehiculosMenosRentadosPorImporte(Chart chart)
        {
            chart.DataSource = new RentaBLL().VehiculosMenosRentadosPorImporte();
            chart.Series[0].XValueMember = "Key";
            chart.Series[0].YValueMembers = "Value";
            chart.Series[0].ChartType = SeriesChartType.Pie;
            chart.Series[0].IsVisibleInLegend = false;
            chart.Titles.Add("Vehículos menos rentados (por importe)");
        }

        public void CargarChartTotalRecaudadoPorTipo(Chart chart)
        {
            chart.DataSource = new RentaBLL().TotalRecaudadoPorTipo();
            chart.Series[0].XValueMember = "Key";
            chart.Series[0].YValueMembers = "Value";
            chart.Series[0].IsVisibleInLegend = false;
            chart.Titles.Add("Total Recaudado por Tipo de Vehículo");
        }
    }
}
