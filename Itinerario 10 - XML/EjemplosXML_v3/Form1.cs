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
            ElegirArchivoButton.Click -= CargarXML;
            ElegirArchivoButton.Click += CargarXML;
        }

        private void CargarXML(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos XML|*.xml";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = openFileDialog.FileName;

                try
                {
                    XDocument xDoc = XDocument.Load(rutaArchivo);

                    // Limpiar el TreeView
                    treeView1.Nodes.Clear();

                    // Crear el nodo raíz en el TreeView
                    TreeNode rootNode = ConstruirNodo(xDoc.Root);
                    treeView1.Nodes.Add(rootNode);

                    // Construir el árbol desde el elemento raíz
                    ConstruirArbolDesdeXElement(xDoc.Root, rootNode);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar el archivo XML:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private TreeNode ConstruirNodo(XElement xElement)
        {
            // Crear el nodo para el elemento
            TreeNode treeNode = new TreeNode(xElement.Name.LocalName);

            // Agregar atributos como nodos secundarios
            foreach (XAttribute attribute in xElement.Attributes())
            {
                treeNode.Nodes.Add($"{attribute.Name.LocalName} = {attribute.Value}");
            }

            return treeNode;
        }

        private void ConstruirArbolDesdeXElement(XElement xElement, TreeNode treeNode)
        {
            // Crear nodos para cada elemento hijo
            foreach (XNode childNode in xElement.Nodes())
            {
                if (childNode is XElement element)
                {
                    // Si es un elemento, crear un nuevo nodo y agregarlo
                    TreeNode childTreeNode = ConstruirNodo(element);
                    treeNode.Nodes.Add(childTreeNode);

                    // Construir el árbol desde el elemento hijo
                    ConstruirArbolDesdeXElement(element, childTreeNode);
                }
                else if (childNode is XText text)
                {
                    // Si es un nodo de texto, usar su valor
                    treeNode.Nodes.Add(text.Value);
                }
            }
        }
    }
}
