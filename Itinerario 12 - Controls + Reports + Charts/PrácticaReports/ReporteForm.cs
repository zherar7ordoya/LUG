using Microsoft.Reporting.WinForms;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Reports
{
    public partial class ReporteForm : Form
    {
        public ReporteForm()
        {
            InitializeComponent();
        }

        // DAL
        private XElement LeerXml()
        {
            XElement xml = XElement.Load("Vehiculos.xml");
            return xml;
        }

        // ORM
        private List<Vehiculo> MapearVehiculos()
        {
            XElement xml = LeerXml();
            List<Vehiculo> vehiculos = new List<Vehiculo>();

            foreach (XElement vehiculo in xml.Elements("Vehiculo"))
            {
                Vehiculo nuevo = new Vehiculo
                {
                    Tipo = vehiculo.Attribute("Tipo").Value,
                    Marca = vehiculo.Element("Marca").Value,
                    Modelo = vehiculo.Element("Modelo").Value,
                    Patente = vehiculo.Element("Patente").Value
                };
                vehiculos.Add(nuevo);
            }
            return vehiculos;
        }


        // BLL (Innecesaria, pero para mostrar el concepto)


        // GUI
        private void ReporteForm_Load(object sender, EventArgs e)
        {
            VehiculosRViewer.LocalReport.DataSources.Clear();
            VehiculosRViewer.LocalReport.DataSources.Add(new ReportDataSource("VehiculosDataset", MapearVehiculos()));
            VehiculosRViewer.RefreshReport();
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
