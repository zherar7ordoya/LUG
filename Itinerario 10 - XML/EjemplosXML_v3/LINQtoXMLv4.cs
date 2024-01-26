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

namespace UI_XML
{
    public partial class LINQtoXMLv4 : Form
    {
        XDocument xmlDoc = new XDocument();
        string archivo = "Juegos.xml";
        public LINQtoXMLv4()
        {
            InitializeComponent();
        }
        private void LINQtoXMLv4_Load(object sender, EventArgs e)
        {
            AgregarNodoButton.Click += AgregarNodo;
            ModificarNodoButton.Click += ModificarNodo;
            BorrarNodoButton.Click += BorrarNodo;
            MostrarXmlButton.Click += MostrarXml;
            LimpiarButton.Click += Limpiar;
            ConsultasDGV.RowEnter += DesdeGridHaciaTextboxes;

            CargarGrilla();
            CargarCombobox();
        }

        //|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| HELPERS

        private void CargarGrilla()
        {
            this.ConsultasDGV.DataSource = null;
            this.ConsultasDGV.DataSource = ListarTodo();
        }

        public List<Juego> ListarTodo()
        {
            var consulta =
                from juego
                in XElement.Load(archivo).Elements("juego")
                select new Juego
                {
                    IdJuego = Convert.ToInt32(Convert.ToString(juego.Attribute("id").Value).Trim()),
                    NombreJuego = Convert.ToString(juego.Element("nombre").Value).Trim(),
                    GeneroJuego = Convert.ToString(juego.Element("genero").Value).Trim(),
                    PlataformaJuego = Convert.ToString(juego.Element("plataforma").Value).Trim(),
                    CompaniaCreadora = Convert.ToString(juego.Element("companiaCreadora").Value).Trim()
                };
            List<Juego> juegos = consulta.ToList<Juego>();
            return juegos;
        }

        public enum Genero : int
        {
            Acción = 1,
            Arcade = 2,
            Deportivo = 3,
            Estrategia = 4,
            Simulación = 5
        }

        void CargarCombobox()
        {
            GenerosCombobox.DataSource = Enum.GetValues(typeof(Genero));
        }


        /*
         * Claro, estos métodos están separados cuando podrían estar en el mismo
         * bloque del evento (botón) que los llama. Pero, pensándolo bien, es lo
         * mejor: cuando se haga la separación en capas, esto debe hacerse.
         */
        //---------------------------------------------------------------- ALTAS

        private void AgregarNodo(object sender, EventArgs e)
        {
            Guardar();
            CargarGrilla();
        }

        private void Guardar()
        {
            xmlDoc = XDocument.Load(archivo);

            // En XDocument, agrego tal como está estructurado en el XML.
            xmlDoc.Element("juegos").Add(
                new XElement("juego",
                new XAttribute("id", this.txtid.Text.Trim()),
                new XElement("nombre", txtNom.Text.Trim()),
                new XElement("genero", GenerosCombobox.Text.Trim()),
                new XElement("plataforma", txtPlataforma.Text.Trim()),
                new XElement("companiaCreadora", txtempresa.Text.Trim())));

            xmlDoc.Save(archivo);
            ListarTodo();
        }

        //------------------------------------------------------- MODIFICACIONES

        private void ModificarNodo(object sender, EventArgs e)
        {
            if (ConsultasDGV.SelectedRows.Count > 0)
            {
                Actualizar(txtid.Text);
                CargarGrilla();
            }
            else { MessageBox.Show("Seleccione el nodo a modificar"); }
        }

        public void Actualizar(string ID)
        {
            //cargo el XML
            //XDocument doc = XDocument.Load("Juegos.XML");
            xmlDoc = XDocument.Load(archivo);

            //consulto por algun campo en este caso por el atribnuto ID
            //puedo consultar por elemento también
            var consulta = from juego in xmlDoc.Descendants("juego")
                           where juego.Attribute("id").Value == ID
                           select juego;

            //recorro la consulta y modifico el elemento de la consulta
            foreach (XElement EModifcar in consulta)
            {
                //recorro y le paso los nuevos valores 
                EModifcar.Element("nombre").Value = txtNom.Text.Trim();
                EModifcar.Element("genero").Value = GenerosCombobox.Text.Trim();
                EModifcar.Element("plataforma").Value = txtPlataforma.Text.Trim();
                EModifcar.Element("companiaCreadora").Value = txtempresa.Text.Trim();
            }

            //despues de modificar , guardo el archivo XML para que impacte el cambio
            xmlDoc.Save(archivo);
        }

        //---------------------------------------------------------------- BAJAS

        private void BorrarNodo(object sender, EventArgs e)
        {
            if (ConsultasDGV.SelectedRows.Count > 0)
            {
                Eliminar(txtid.Text);
                CargarGrilla();
            }
            else { MessageBox.Show("Seleccione el Nodo a eliminar"); }
        }

        public void Eliminar(string ID)
        {
            //cargo el XML
            //XDocument doc = XDocument.Load("Juegos.XML");
            xmlDoc = XDocument.Load(archivo);

            //consulto por algun campo en este caso por el atribnuto ID
            //puedo consultar por elemento también
            var consulta = from juego in xmlDoc.Descendants("juego")
                           where juego.Attribute("id").Value == ID
                           select juego;
            //metodo remove borro todo el nodo
            consulta.Remove();

            //despues del borrado , guardo el archivo XML para que impacte el cambio
            xmlDoc.Save(archivo);
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

        private void MostrarXml(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void Limpiar(object sender, EventArgs e)
        {
            txtid.Text = string.Empty;
            txtNom.Text = string.Empty;
            txtPlataforma.Text = string.Empty;
            GenerosCombobox.Text = string.Empty;
            txtempresa.Text = string.Empty;
        }

        private void DesdeGridHaciaTextboxes(object sender, DataGridViewCellEventArgs e)
        {
            if (ConsultasDGV.CurrentRow != null)
            {
                //Juego oJuego = new Juego();

                // ESTO NO FUNCIONA COMO SE ESPERA: DESFASA LOS DATOS.
                //oJuego = (Juego)ConsultasDGV.CurrentRow.DataBoundItem;
                Juego oJuego = (Juego)ConsultasDGV.Rows[e.RowIndex].DataBoundItem;

                txtid.Text = oJuego.IdJuego.ToString().Trim();
                txtNom.Text = oJuego.NombreJuego.Trim();
                txtPlataforma.Text = oJuego.PlataformaJuego.Trim();
                GenerosCombobox.Text = oJuego.GeneroJuego.Trim();
                txtempresa.Text = oJuego.CompaniaCreadora.Trim();
            }
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
