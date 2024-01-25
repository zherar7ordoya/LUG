using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace UI_XML
{
    public partial class LecturaEscrituraI : Form
    {
        public LecturaEscrituraI()
        {
            InitializeComponent();
            AbrirXmlButton.Click += AbrirXml;
            CrearXmlButton.Click += CrearXml;
            LeerDomButton.Click += MostrarConXmlDocument;
        }

        //**********************************************************************

        private void AbrirXml(object sender, EventArgs e)
        {
            MostrarConXmlReader("Libros.xml");
            //MostrarXml("Juegos.xml");
        }


        //void MostrarXml(string rutaArchivo)
        //{
        //    // Limpia el treeview
        //    ControlArbol.Nodes.Clear();

        //    // Crea el objeto lectorXml del tipo XmlTextReader
        //    XmlTextReader xmlLector = new XmlTextReader(rutaArchivo);

        //    try
        //    {
        //        TreeNode nodoPadre = null;

        //        while (xmlLector.Read())
        //        {
        //            // Verifica si el nodo actual es un elemento XML.---------------------------------------------------
        //            if (xmlLector.NodeType == XmlNodeType.Element)
        //            {
        //                // Crea un nuevo nodo para el elemento actual
        //                TreeNode nodoHijo = new TreeNode(xmlLector.Name);

        //                // Si el elemento tiene atributos, se agrega al nodo actual
        //                if (xmlLector.HasAttributes)
        //                {
        //                    // Añade un nodo para cada atributo del elemento
        //                    while (xmlLector.MoveToNextAttribute())
        //                    {
        //                        nodoHijo.Nodes.Add($"{xmlLector.Name} = {xmlLector.Value}");
        //                    }
        //                }

        //                // Si hay un nodo padre, agrega el nuevo nodo a él.
        //                // De lo contrario, es el nodo raíz.
        //                if (nodoPadre != null)
        //                {
        //                    nodoPadre.Nodes.Add(nodoHijo);
        //                }
        //                else
        //                {
        //                    ControlArbol.Nodes.Add(nodoHijo);
        //                }

        //                // Establece el nuevo nodo como el nodo padre para los siguientes nodos.
        //                nodoPadre = nodoHijo;
        //            }
        //            // Verifica si el nodo actual es un texto.----------------------------------------------------------
        //            else if (xmlLector.NodeType == XmlNodeType.Text)
        //            {
        //                // Agrega el valor como un nodo al nodo padre actual.
        //                nodoPadre?.Nodes.Add(xmlLector.Value);
        //            }
        //            // Verifica si el nodo actual es el cierre de un elemento.------------------------------------------
        //            else if (xmlLector.NodeType == XmlNodeType.EndElement)
        //            {
        //                // Si el nodo actual es el cierre de un elemento, retrocede al nodo padre
        //                if (nodoPadre != null)
        //                {
        //                    nodoPadre = nodoPadre.Parent;
        //                }
        //            }
        //        }
        //    }
        //    catch (XmlException ex) { MessageBox.Show(ex.Message); }
        //    finally { xmlLector.Close(); }
        //}


        void MostrarConXmlReader(string rutaArchivo)
        {
            // Verificar la existencia del archivo antes de intentar abrirlo
            if (!File.Exists(rutaArchivo))
            {
                MessageBox.Show("El archivo no existe.");
                return;
            }

            // Limpiar el treeview
            ControlArbol.Nodes.Clear();

            // Utilizar XmlReader en lugar de XmlTextReader (obsoleto)

            /* NOTA: Se ha utilizado la instrucción using para garantizar que el
                     objeto XmlReader se cierre correctamente incluso si se
                     produce una excepción.
            */
            using (XmlReader xmlLector = XmlReader.Create(rutaArchivo))
            {
                try
                {
                    TreeNode nodoPadre = null;

                    while (xmlLector.Read())
                    {
                        switch (xmlLector.NodeType)
                        {
                            case XmlNodeType.Element:
                                // Crear un nuevo nodo para el elemento actual
                                TreeNode nodoHijo = new TreeNode(xmlLector.Name);

                                // Si el elemento tiene atributos, agregarlos al nodo actual
                                if (xmlLector.HasAttributes)
                                {
                                    while (xmlLector.MoveToNextAttribute())
                                    {
                                        nodoHijo.Nodes.Add($"{xmlLector.Name} = {xmlLector.Value}");
                                    }
                                }

                                // Agregar el nuevo nodo al nodo padre o al treeview
                                if (nodoPadre != null)
                                {
                                    nodoPadre.Nodes.Add(nodoHijo);
                                }
                                else
                                {
                                    ControlArbol.Nodes.Add(nodoHijo);
                                }

                                // Establecer el nuevo nodo como el nodo padre para los siguientes nodos.
                                nodoPadre = nodoHijo;
                                break;

                            case XmlNodeType.Text:
                                // Agregar el valor como un nodo al nodo padre actual.
                                nodoPadre?.Nodes.Add(xmlLector.Value);
                                break;

                            case XmlNodeType.EndElement:
                                // Retroceder al nodo padre si es el cierre de un elemento.
                                nodoPadre = nodoPadre?.Parent;
                                break;
                        }
                    }
                }
                catch (XmlException ex)
                {
                    MessageBox.Show($"Error al procesar el archivo XML: {ex.Message}");
                }
            }
        }


        //**********************************************************************

        //private void CrearXml(object sender, EventArgs e)
        //{
        //    XmlTextWriter archivoxml = new XmlTextWriter("Ejemplo2.xml", System.Text.Encoding.UTF8)
        //    {
        //        Formatting = Formatting.Indented,
        //        Indentation = 4
        //    };
        //    archivoxml.WriteStartDocument(true);
        //    archivoxml.WriteStartElement("Alumno");
        //    archivoxml.WriteAttributeString("DNI", textBox1.Text.ToString());
        //    archivoxml.WriteElementString("Nombre", textBox2.Text.ToString());
        //    archivoxml.WriteElementString("Apellido", textBox3.Text.ToString());
        //    archivoxml.WriteEndElement();
        //    archivoxml.WriteEndDocument();
        //    archivoxml.Close();
        //    MostrarConXmlReader("Ejemplo2.xml");
        //    Limpiar();
        //}


        private void CrearXml(object sender, EventArgs e)
        {
            string rutaArchivo = "Ejemplo2.xml";

            // Crear XmlWriter con formato y codificación
            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true,
                IndentChars = "    ", // Espacios para la indentación
                Encoding = System.Text.Encoding.UTF8
            };

            using (XmlWriter writer = XmlWriter.Create(rutaArchivo, settings))
            {
                // Escribir el documento XML
                writer.WriteStartDocument(true);
                writer.WriteStartElement("Alumno");
                writer.WriteAttributeString("DNI", textBox1.Text);
                writer.WriteElementString("Nombre", textBox2.Text);
                writer.WriteElementString("Apellido", textBox3.Text);
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }

            // Mostrar el XML recién creado
            MostrarConXmlReader(rutaArchivo);
            Limpiar();
        }




        void Limpiar()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    control.Text = null;
                }
            }
        }

        //**********************************************************************

        //private void MostrarConXmlDocument(object sender, EventArgs e)
        //{
        //    //limpio el treeview
        //    ControlArbol.Nodes.Clear();
        //    XmlDocument doc = new XmlDocument();
        //    doc.Load("Libros.xml");
        //    // doc.Load("Juegos.xml");
        //    foreach (XmlNode f in doc.DocumentElement)
        //    {
        //        foreach (XmlNode a in f.Attributes)
        //        {
        //            ControlArbol.Nodes.Add(a.InnerText);
        //        }
        //        foreach (XmlNode ff in f.ChildNodes)
        //        {
        //            ControlArbol.Nodes.Add(ff.InnerText);
        //        }
        //    }
        //}




        private void MostrarConXmlDocument(object sender, EventArgs e)
        {
            string rutaArchivo = "Juegos.xml";

            // Verificar la existencia del archivo antes de intentar abrirlo
            if (!File.Exists(rutaArchivo))
            {
                MessageBox.Show("El archivo no existe.");
                return;
            }

            // Limpiar el treeview
            ControlArbol.Nodes.Clear();

            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(rutaArchivo);

                XmlNode root = doc.DocumentElement;
                TreeNode rootNode = DesdeXmlNodeHaciaTreeNode(root);

                // Agregar el nodo raíz al treeview
                ControlArbol.Nodes.Add(rootNode);
            }
            catch (XmlException ex)
            {
                MessageBox.Show($"Error al procesar el archivo XML: {ex.Message}");
            }
        }

        private TreeNode DesdeXmlNodeHaciaTreeNode(XmlNode xmlNode)
        {
            // Manejar nodos de texto de manera específica
            if (xmlNode.NodeType == XmlNodeType.Text)
            {
                return new TreeNode(xmlNode.Value);
            }

            TreeNode treeNode = new TreeNode(xmlNode.Name);

            // Agregar atributos como nodos al treeNode
            if (xmlNode.Attributes != null)
            {
                foreach (XmlAttribute attribute in xmlNode.Attributes)
                {
                    treeNode.Nodes.Add($"{attribute.Name} = {attribute.Value}");
                }
            }

            // Agregar nodos hijos recursivamente
            foreach (XmlNode childNode in xmlNode.ChildNodes)
            {
                treeNode.Nodes.Add(DesdeXmlNodeHaciaTreeNode(childNode));
            }

            return treeNode;
        }



        //**********************************************************************

    }
}
