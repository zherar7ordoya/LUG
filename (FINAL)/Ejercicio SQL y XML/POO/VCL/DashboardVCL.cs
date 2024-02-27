using BLL;

using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace VCL
{
    public class DashboardVCL
    {
        readonly Form formulario;

        // Los controles del formulario
        Chart VehiculosMasRentadosPorTipoChart;
        Chart VehiculosMasRentadosPorImporteChart;
        Chart VehiculosMenosRentadosPorTipoChart;
        Chart VehiculosMenosRentadosPorImporteChart;
        Chart TotalRecaudadoPorTipoChart;

        public DashboardVCL(Form formulario)
        {
            this.formulario = formulario;
            IncializarControles();
            formulario.Load += FormularioLoad;
        }

        private void IncializarControles()
        {
            VehiculosMasRentadosPorTipoChart = (Chart)formulario.Controls["VehiculosMasRentadosPorTipoChart"];
            VehiculosMasRentadosPorImporteChart = (Chart)formulario.Controls["VehiculosMasRentadosPorImporteChart"];
            VehiculosMenosRentadosPorTipoChart = (Chart)formulario.Controls["VehiculosMenosRentadosPorTipoChart"];
            VehiculosMenosRentadosPorImporteChart = (Chart)formulario.Controls["VehiculosMenosRentadosPorImporteChart"];
            TotalRecaudadoPorTipoChart = (Chart)formulario.Controls["TotalRecaudadoPorTipoChart"];
        }

        private void FormularioLoad(object sender, EventArgs e)
        {
            CargarChartVehiculosMasRentadosPorTipo();
            CargarChartVehiculosMasRentadosPorImporte();
            CargarChartVehiculosMenosRentadosPorTipo();
            CargarChartVehiculosMenosRentadosPorImporte();
            CargarChartTotalRecaudadoPorTipo();
        }

        //|||||||||||||||||||||||||||||||||||||||||||||||||||||||||| MÉTODOS |||

        private void CargarChartVehiculosMasRentadosPorTipo()
        {
            VehiculosMasRentadosPorTipoChart.DataSource = new RentaBLL().VehiculosMasRentadosPorTipo();
            VehiculosMasRentadosPorTipoChart.Series[0].XValueMember = "Key";
            VehiculosMasRentadosPorTipoChart.Series[0].YValueMembers = "Value";
            VehiculosMasRentadosPorTipoChart.Series[0].IsVisibleInLegend = false;
            VehiculosMasRentadosPorTipoChart.Titles.Add("Vehículos más rentados (por tipo)");
        }

        private void CargarChartVehiculosMasRentadosPorImporte()
        {
            VehiculosMasRentadosPorImporteChart.DataSource = new RentaBLL().VehiculosMasRentadosPorImporte();
            VehiculosMasRentadosPorImporteChart.Series[0].XValueMember = "Key";
            VehiculosMasRentadosPorImporteChart.Series[0].YValueMembers = "Value";
            VehiculosMasRentadosPorImporteChart.Series[0].ChartType = SeriesChartType.Pie;
            VehiculosMasRentadosPorImporteChart.Series[0].IsVisibleInLegend = false;
            VehiculosMasRentadosPorImporteChart.Titles.Add("Vehículos más rentados (por importe)");
        }

        private void CargarChartVehiculosMenosRentadosPorTipo()
        {
            VehiculosMenosRentadosPorTipoChart.DataSource = new RentaBLL().VehiculosMenosRentadosPorTipo();
            VehiculosMenosRentadosPorTipoChart.Series[0].XValueMember = "Key";
            VehiculosMenosRentadosPorTipoChart.Series[0].YValueMembers = "Value";
            VehiculosMenosRentadosPorTipoChart.Series[0].IsVisibleInLegend = false;
            VehiculosMenosRentadosPorTipoChart.Titles.Add("Vehículos menos rentados (por tipo)");
        }

        private void CargarChartVehiculosMenosRentadosPorImporte()
        {
            VehiculosMenosRentadosPorImporteChart.DataSource = new RentaBLL().VehiculosMenosRentadosPorImporte();
            VehiculosMenosRentadosPorImporteChart.Series[0].XValueMember = "Key";
            VehiculosMenosRentadosPorImporteChart.Series[0].YValueMembers = "Value";
            VehiculosMenosRentadosPorImporteChart.Series[0].ChartType = SeriesChartType.Pie;
            VehiculosMenosRentadosPorImporteChart.Series[0].IsVisibleInLegend = false;
            VehiculosMenosRentadosPorImporteChart.Titles.Add("Vehículos menos rentados (por importe)");
        }

        private void CargarChartTotalRecaudadoPorTipo()
        {
            TotalRecaudadoPorTipoChart.DataSource = new RentaBLL().TotalRecaudadoPorTipo();
            TotalRecaudadoPorTipoChart.Series[0].XValueMember = "Key";
            TotalRecaudadoPorTipoChart.Series[0].YValueMembers = "Value";
            TotalRecaudadoPorTipoChart.Series[0].IsVisibleInLegend = false;
            TotalRecaudadoPorTipoChart.Titles.Add("Total Recaudado por Tipo de Vehículo");
        }

        //\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\\
    }
}
