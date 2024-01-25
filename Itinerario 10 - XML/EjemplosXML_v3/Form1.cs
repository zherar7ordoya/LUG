using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace UI_XML
{
    public partial class Form1 : Form
    {
        string rutaArchivo = "Ejemplo2.xml";
        public Form1()
        {
            InitializeComponent();
            CargarArchivoButton.Click += MostrarConLINQ;
            GuardarArchivoButton.Click += CrearXmlConLINQ;
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||


        private void MostrarConLINQ(object sender, EventArgs e)
        {
            // Limpiar el treeview
            ControlArbol.Nodes.Clear();

            try
            {
                XDocument doc = XDocument.Load(rutaArchivo);

                var treeNodes = from juego in doc.Descendants("juego")
                                select new TreeNode($"{juego.Element("nombre")?.Value} (ID: {juego.Attribute("id")?.Value})")
                                {
                                    Nodes = {
                                new TreeNode($"Género: {juego.Element("genero")?.Value}"),
                                new TreeNode($"Plataforma: {juego.Element("plataforma")?.Value}"),
                                new TreeNode($"Compañía Creadora: {juego.Element("companiaCreadora")?.Value}")
                            }
                                };

                ControlArbol.Nodes.AddRange(treeNodes.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar el archivo XML: {ex.Message}");
            }
        }






        private void CrearXmlConLINQ(object sender, EventArgs e)
        {
            var nuevoXml = new XDocument(
                new XElement("Alumno",
                    new XAttribute("DNI", textBox1.Text),
                    new XElement("Nombre", textBox2.Text),
                    new XElement("Apellido", textBox3.Text)
                )
            );

            nuevoXml.Save(rutaArchivo);
        }




        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
