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
            MostrarXML("libros.xml");
           // MostrarXML("Juegos.XML");
        }

        void MostrarXML(string pArchivo)
        {
            //limpio el treeview
            MiTreeview.Nodes.Clear();

            // XmlTextReader representa un lector que proporciona acceso rápido
            // a datos XML, sin almacenamiento en caché y con desplazamiento
            // solo hacia delante. A partir de .NET Framework 2.0, se recomienda
            // usar la clase System.Xml.XmlReader en su lugar.

            //creo el objetoArchivoXML del tipo XMLtextereader
            //XmlTextReader archivo = new XmlTextReader(pArchivo);
            XmlReader archivo = XmlReader.Create(pArchivo);

            try
            {   //Leo el archivo XML 
                while (archivo.Read())
                {
                    // Si el nodo es un elemento XML
                    if (archivo.NodeType == XmlNodeType.Element)
                    {
                        // Si el elemento tiene atributos
                        if (archivo.HasAttributes == true)
                        {
                            // Recorrer los atributos del elemento
                            while (archivo.MoveToNextAttribute())
                            {
                                // Agregar el valor del atributo al treeview
                                MiTreeview.Nodes.Add(archivo.Value);
                            }
                        }
                    }

                    // Si el nodo es un nodo de texto dentro del elemento
                    if (archivo.NodeType == XmlNodeType.Text)
                    {
                        // Agregar el valor del nodo de texto al treeview
                        MiTreeview.Nodes.Add(archivo.Value);
                    }
                }
            }
            catch (XmlException ex)
            {  MessageBox.Show(ex.Message); }
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
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
        }
        private void Button3_Click_1(object sender, EventArgs e)
        {
            //limpio el treeview
            MiTreeview.Nodes.Clear();
            XmlDocument doc = new XmlDocument();
             doc.Load("libros.xml");
           // doc.Load("Juegos.XML");
            foreach (XmlNode f in doc.DocumentElement)
            {
                foreach (XmlNode a in f.Attributes)
                {
                    MiTreeview.Nodes.Add (a.InnerText);
                }
                foreach (XmlNode ff in f.ChildNodes)
                {
                    MiTreeview.Nodes.Add(ff.InnerText);
                }
            }
        }
    }
}
