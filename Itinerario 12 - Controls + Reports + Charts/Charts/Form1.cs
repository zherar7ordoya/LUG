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
using System.Xml.Linq;

namespace Charts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

        private XElement Leer()
        {
            XElement xml = XElement.Load("Empleados.xml");
            return xml;
        }

        private List<Empleado> MapearEmpleados()
        {
            XElement xml = Leer();
            List<Empleado> empleados = new List<Empleado>();

            foreach (XElement x in xml.Elements())
            {
                Empleado empleado = new Empleado
                {
                    Codigo = Convert.ToInt32(x.Attribute("Id").Value),
                    Nombre = x.Element("Nombre").Value,
                    Apellido = x.Element("Apellido").Value,
                    Edad = Convert.ToInt32(x.Element("Edad").Value),
                    Genero = x.Element("Genero").Value,
                    Puesto = x.Element("Puesto").Value,
                    Sueldo = Convert.ToDouble(x.Element("Sueldo").Value),
                    AñoAlta = Convert.ToInt32(x.Element("AñoAlta").Value)
                };
                empleados.Add(empleado);
            }
            return empleados;
        }

        private Dictionary<string, int> ObtenerPuestos()
        {
            List<Empleado> empleados = MapearEmpleados();
            Dictionary<string, int> puestos = new Dictionary<string, int>();

            foreach (Empleado e in empleados)
            {
                if (puestos.ContainsKey(e.Puesto))
                {
                    puestos[e.Puesto]++;
                }
                else
                {
                    puestos.Add(e.Puesto, 1);
                }
            }
            return puestos;
        }

        private Dictionary<string, double> ObtenerSueldos()
        {
            List<Empleado> todos = MapearEmpleados();

            // Ordenar la lista por sueldo de forma descendente
            List<Empleado> ordenados = todos.OrderByDescending(x => x.Sueldo).ToList();

            // Tomar los primeros diez elementos (los sueldos más altos)
            List<Empleado> empleados = ordenados.Take(5).ToList();

            // Devolver diccionario con los diez sueldos más altos
            Dictionary<string, double> datos = new Dictionary<string, double>();

            foreach (Empleado empleado in empleados)
            {
                // Usar el nombre y apellido como clave y el sueldo como valor en el diccionario
                string nombreCompleto = $"{empleado.Nombre} {empleado.Apellido}";
                datos.Add(nombreCompleto, empleado.Sueldo);
            }

            return datos;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarPuestosChart();
            CargarSueldosChart();
        }


        private void CargarPuestosChart()
        {
            // Obtener el diccionario con los puestos y la cantidad de empleados
            Dictionary<string, int> puestos = ObtenerPuestos();

            // Asignar el diccionario como origen de datos para el Chart
            PuestosChart.DataSource = puestos;

            // Especificar qué propiedad del diccionario se usará para el eje X (puestos)
            PuestosChart.Series[0].XValueMember = "Key";

            // Especificar qué propiedad del diccionario se usará para el eje Y (número de empleados)
            PuestosChart.Series[0].YValueMembers = "Value";

            // Cambiar el tipo de gráfico a torta
            PuestosChart.Series[0].ChartType = SeriesChartType.Pie;

            // Actualizar el gráfico
            PuestosChart.DataBind();
        }


        private void CargarSueldosChart()
        {
            // Obtener el diccionario con los puestos y la cantidad de empleados
            Dictionary<string, double> sueldos = ObtenerSueldos();

            // Asignar el diccionario como origen de datos para el Chart
            SueldosChart.DataSource = sueldos;

            // Especificar qué propiedad del diccionario se usará para el eje X (nombre)
            SueldosChart.Series[0].XValueMember = "Key";

            // Especificar qué propiedad del diccionario se usará para el eje Y (sueldo)
            SueldosChart.Series[0].YValueMembers = "Value";

            // Cambiar el tipo de gráfico a columna
            SueldosChart.Series[0].ChartType = SeriesChartType.Column;

            // Actualizar el gráfico
            SueldosChart.DataBind();
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
