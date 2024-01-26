using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABMC
{
    public partial class GUI : Form
    {
        Pelicula peliculaBEL = new Pelicula();
        BLL peliculaBLL = new BLL();
        public GUI()
        {
            InitializeComponent();
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            AltaButton.Click += Guardar;
            BajaButton.Click += Eliminar;
            ModificacionButton.Click += Actualizar;
            ConsultaButton.Click += Consultar;
            ActoresDGV.RowEnter += SincronizarControles;
            ListarPeliculas();
        }


        private void Guardar(object sender, EventArgs e)
        {
            LimpiarControles();
        }
        private void Eliminar(object sender, EventArgs e)
        {
            LimpiarControles();
        }
        private void Actualizar(object sender, EventArgs e)
        {
            LimpiarControles();
        }
        private void Consultar(object sender, EventArgs e)
        {

        }

        private void SincronizarControles(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListarPeliculas()
        {

        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||


        private Pelicula ArmarObjeto()
        {
            Pelicula pelicula = new Pelicula
            {
                Titulo = TituloTextbox.Text,
                Produccion = new Produccion
                {
                    AñoEstreno = int.Parse(AñoEstrenoTextbox.Text),
                    Distribuidora = DistribuidoraTextbox.Text
                },
                Actores = RecuperarActores()
            };
            return pelicula;
        }

        private List<Actor> RecuperarActores()
        {
            List<Actor> actores = new List<Actor>();
            foreach (DataGridViewRow fila in ActoresDGV.Rows)
            {
                // Verificar si la fila no es la fila de nuevos datos
                if (!fila.IsNewRow)
                {
                    // Acceder a las celdas de la fila
                    DataGridViewCellCollection celdas = fila.Cells;

                    // Crear un nuevo objeto Actor y asignar valores
                    Actor actor = new Actor
                    {
                        Nombre = celdas["Nombre"].Value.ToString(),
                        Personaje = celdas["Personaje"].Value.ToString()
                    };

                    // Agregar el objeto Actor a la lista
                    actores.Add(actor);
                }
            }
            return actores;
        }

        private void LimpiarControles()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox) control.Text = string.Empty;
                if (control is RadioButton) ((RadioButton)control).Checked = false;
                if (control is DataGridView) ((DataGridView)control).DataSource = null;
                if (control is TreeView) ((TreeView)control).Nodes.Clear();
            }
            ListarPeliculas();
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
