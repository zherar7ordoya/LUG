using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           // MostrarXML("Libros.xml");
           MostrarXML("Juegos.xml");
        }


        void MostrarXML(string rutaArchivo)
        {
            // Limpia el treeview
            ControlArbol.Nodes.Clear();

            // Crea el objeto lectorXml del tipo XmlTextReader
            XmlTextReader lectorXml = new XmlTextReader(rutaArchivo);

            try
            {
                TreeNode nodoPadre = null;

                while (lectorXml.Read())
                {
                    // Verifica si el nodo actual es un elemento XML.////////////////////
                    if (lectorXml.NodeType == XmlNodeType.Element)
                    {
                        // Crea un nuevo nodo para el elemento actual
                        TreeNode nuevoNodo = new TreeNode(lectorXml.Name);

                        // Si el elemento tiene atributos, añádelos al nodo actual
                        if (lectorXml.HasAttributes)
                        {
                            while (lectorXml.MoveToNextAttribute())
                            {
                                // Añade un nodo para cada atributo del elemento
                                nuevoNodo.Nodes.Add($"{lectorXml.Name} = {lectorXml.Value}");
                            }
                        }

                        // Si hay un nodo padre, agrega el nuevo nodo a él.
                        // De lo contrario, es el nodo raíz.
                        if (nodoPadre != null)
                        {
                            nodoPadre.Nodes.Add(nuevoNodo);
                        }
                        else
                        {
                            ControlArbol.Nodes.Add(nuevoNodo);
                        }

                        // Establece el nuevo nodo como el nodo padre para los siguientes nodos.
                        nodoPadre = nuevoNodo;
                    }
                    // Verifica si el nodo actual es un texto.///////////////////////////
                    else if (lectorXml.NodeType == XmlNodeType.Text)
                    {
                        // Agrega el valor como un nodo al nodo padre actual.
                        nodoPadre?.Nodes.Add(lectorXml.Value);
                    }
                    // Verifica si el nodo actual es el cierre de un elemento.///////////
                    else if (lectorXml.NodeType == XmlNodeType.EndElement)
                    {
                        // Si el nodo actual es el cierre de un elemento, retrocede al nodo padre
                        if (nodoPadre != null)
                        {
                            nodoPadre = nodoPadre.Parent;
                        }
                    }
                }
            }
            catch (XmlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                lectorXml.Close();
            }
        }





        private void LecturaEscrituraI_Load(object sender, EventArgs e)
        {

        }
       
        private void Button2_Click_1(object sender, EventArgs e)
        {    // se escribe el documento de 0
            XmlTextWriter archivoxml = new XmlTextWriter("Ejemplo2.xml", System.Text.Encoding.UTF8);
            archivoxml.Formatting = Formatting.Indented;
            //identation es para que se escriba nueva lineas
            archivoxml.Indentation=2;
            archivoxml.WriteStartDocument(true);
            archivoxml.WriteStartElement("Alumno");
            archivoxml.WriteAttributeString("DNI", textBox1.Text.ToString());
            archivoxml.WriteElementString("Nombre", textBox2.Text.ToString());
            archivoxml.WriteElementString("Apellido", textBox3.Text.ToString());
            archivoxml.WriteEndElement();
            archivoxml.WriteEndDocument();
            archivoxml.Close();
            MostrarXML("Ejemplo2.xml");
            Limpiar();
        }

        //void CrearItem(XmlTextWriter archivoxml)
        //{
        //    archivoxml.WriteAttributeString("DNI", this.textBox1.Text.ToString());
        //    archivoxml.WriteElementString("Nombre", this.textBox2.Text.ToString());
        //    archivoxml.WriteElementString("Apellido", this.textBox3.Text.ToString());
        //}

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
        private void Button3_Click_1(object sender, EventArgs e)
        {
            //limpio el treeview
            ControlArbol.Nodes.Clear();
            XmlDocument doc = new XmlDocument();
             doc.Load("libros.xml");
           // doc.Load("Juegos.XML");
            foreach (XmlNode f in doc.DocumentElement)
            {
                foreach (XmlNode a in f.Attributes)
                {
                    ControlArbol.Nodes.Add (a.InnerText);
                }
                foreach (XmlNode ff in f.ChildNodes)
                {
                    ControlArbol.Nodes.Add(ff.InnerText);
                }

            }
        }
    }
}
