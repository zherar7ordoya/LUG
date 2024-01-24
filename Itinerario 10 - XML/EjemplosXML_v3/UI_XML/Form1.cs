using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace UI_XML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ElegirArchivoButton.Click += CargarXML;
        }

        private void CargarXML(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos XML|*.xml";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = openFileDialog.FileName;
                CargarXMLenTreeView(rutaArchivo);
            }
        }

        private void CargarXMLenTreeView(string rutaArchivo)
        {
            // Limpiar el TreeView
            treeView1.Nodes.Clear();

            try
            {
                // Cargar el documento XML utilizando LINQ to XML
                XDocument xDoc = XDocument.Load(rutaArchivo);

                // Crear el nodo raíz en el TreeView
                TreeNode rootNode = new TreeNode(xDoc.Root.Name.LocalName);
                treeView1.Nodes.Add(rootNode);

                // Llamar a un método para construir el árbol desde el elemento raíz
                ConstruirArbolDesdeXElement(xDoc.Root, rootNode);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el archivo XML:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConstruirArbolDesdeXElement(XElement xElement, TreeNode treeNode)
        {
            // Crear nodos para cada elemento hijo
            foreach (XNode childNode in xElement.Nodes())
            {
                TreeNode childTreeNode = new TreeNode();

                if (childNode is XElement element)
                {
                    // Si es un elemento, crear un nuevo nodo y llamar recursivamente
                    childTreeNode = new TreeNode(element.Name.LocalName);
                    ConstruirArbolDesdeXElement(element, childTreeNode);
                }
                else if (childNode is XText text)
                {
                    // Si es un nodo de texto, usar su valor
                    childTreeNode = new TreeNode(text.Value);
                }

                // Agregar el nodo hijo al nodo actual
                treeNode.Nodes.Add(childTreeNode);
            }

            // Agregar atributos como nodos secundarios
            foreach (XAttribute attribute in xElement.Attributes())
            {
                treeNode.Nodes.Add($"{attribute.Name.LocalName} = {attribute.Value}");
            }
        }
    }
}
