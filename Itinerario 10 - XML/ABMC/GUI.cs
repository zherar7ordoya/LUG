/**
 * => TENGO QUE ORDENAR ESTE CÓDIGO, POR DIOS...
 */


using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ABMC
{
    public partial class GUI : Form
    {
        Pelicula peliculaBEL = new Pelicula();
        readonly BLL peliculaBLL = new BLL();
        public GUI()
        {
            InitializeComponent();
            ConfigurarEventos();
        }


        // Interesante...
        private void ConfigurarEventos()
        {
            AltaButton.Click += (sender, e) => ManejarOperacion(Guardar);
            BajaButton.Click += (sender, e) => ManejarOperacion(Eliminar);
            ModificacionButton.Click += (sender, e) => ManejarOperacion(Actualizar);
            ConsultaButton.Click += Consultar;
            RestablecerButton.Click += (sender, e) => ManejarOperacion(Restablecer);
            PeliculasDGV.RowEnter += SincronizarControles;
        }

        private void ManejarOperacion(Action<object, EventArgs> operacion)
        {
            peliculaBEL = ArmarObjeto();
            operacion.Invoke(this, EventArgs.Empty);
            LimpiarControles();
            ListarPeliculas();
        }


        private void GUI_Load(object sender, EventArgs e)
        {
            ActoresDGV.Columns.Add("ColumnaNombre", "Nombre");
            ActoresDGV.Columns.Add("ColumnaPersonaje", "Personaje");
            ListarPeliculas();
        }


        private void Guardar(object sender, EventArgs e)
        {
            peliculaBEL = ArmarObjeto();
            peliculaBLL.Guardar(peliculaBEL);
            LimpiarControles();
            ListarPeliculas();
        }
        private void Eliminar(object sender, EventArgs e)
        {
            peliculaBEL = ArmarObjeto();
            peliculaBLL.Eliminar(peliculaBEL);
            LimpiarControles();
            ListarPeliculas();
        }
        private void Actualizar(object sender, EventArgs e)
        {
            peliculaBEL = ArmarObjeto();
            peliculaBLL.Actualizar(peliculaBEL);
            LimpiarControles();
            ListarPeliculas();
        }


        private CriterioBusqueda ObtenerCriterioBusquedaSeleccionado() //------*
        {
            if (TituloRadio.Checked)
            {
                return CriterioBusqueda.Titulo;
            }
            else if (AñoRadio.Checked)
            {
                return CriterioBusqueda.Año;
            }
            else if (ActorRadio.Checked)
            {
                return CriterioBusqueda.Actor;
            }
            else
            {
                return CriterioBusqueda.SinSeleccion;
            }
        }


        private void Consultar(object sender, EventArgs e)
        {
            if (ConsultaTextbox.Text == string.Empty)
            {
                MessageBox.Show("No ha ingresado ningún valor para realizar la búsqueda.");
                return;
            }

            switch (ObtenerCriterioBusquedaSeleccionado())
            {
                case CriterioBusqueda.Titulo:
                    ConsultarPorTitulo();
                    break;

                case CriterioBusqueda.Año:
                    ConsultarPorAño();
                    break;

                case CriterioBusqueda.Actor:
                    ConsultarPorActor();
                    break;

                default:
                    MessageBox.Show("No ha seleccionado ningún criterio de búsqueda.");
                    break;
            }
        }

        private void ConsultarPorTitulo()
        {
            PeliculasDGV.DataSource = null;
            PeliculasDGV.DataSource = peliculaBLL.ConsultarPorTitulo(ConsultaTextbox.Text);
        }

        private void ConsultarPorAño()
        {
            PeliculasDGV.DataSource = null;
            PeliculasDGV.DataSource = peliculaBLL.ConsultarPorAño(int.Parse(ConsultaTextbox.Text));
        }

        private void ConsultarPorActor()
        {
            PeliculasDGV.DataSource = null;
            PeliculasDGV.DataSource = peliculaBLL.ConsultarPorActor(ConsultaTextbox.Text);
        }

        private void SincronizarControles(object sender, DataGridViewCellEventArgs e)
        {
            ActoresDGV.Rows.Clear();

            if (PeliculasDGV.CurrentRow != null)
            {
                peliculaBEL = (Pelicula)PeliculasDGV.Rows[e.RowIndex].DataBoundItem;

                // Textboxes
                CodigoTextbox.Text = peliculaBEL.Codigo.ToString();
                TituloTextbox.Text = peliculaBEL.Titulo;
                AñoEstrenoTextbox.Text = peliculaBEL.Produccion.AñoEstreno.ToString();
                DistribuidoraTextbox.Text = peliculaBEL.Produccion.Distribuidora;

                // DataGridView
                List<Actor> actores = peliculaBEL.Actores;

                if (actores != null)
                {
                    foreach (Actor actor in actores)
                    {
                        // Agregar una nueva fila al DataGridView
                        int rowIndex = ActoresDGV.Rows.Add();
                        DataGridViewRow nuevaFila = ActoresDGV.Rows[rowIndex];

                        // Asignar los valores de la lista de actores a las celdas correspondientes
                        nuevaFila.Cells["ColumnaNombre"].Value = actor.Nombre;
                        nuevaFila.Cells["ColumnaPersonaje"].Value = actor.Personaje;
                    }
                }

                ActualizarTreeView(peliculaBEL.Titulo);

            }
        }


        private void ActualizarTreeView(string titulo) //----------------------*
        {
            DetalleTreeview.Nodes.Clear();

            // Obtener las películas con el mismo título
            List<Pelicula> peliculas = peliculaBLL.ConsultarPorTitulo(titulo);

            // Agregar nodos al TreeView
            foreach (Pelicula pelicula in peliculas)
            {
                TreeNode nodo = new TreeNode($"{pelicula.Titulo} (Código: {pelicula.Codigo})");

                // Nodo para información de producción
                TreeNode produccionNode = new TreeNode("Producción");
                produccionNode.Nodes.Add($"Año de estreno: {pelicula.Produccion.AñoEstreno}");
                produccionNode.Nodes.Add($"Distribuidora: {pelicula.Produccion.Distribuidora}");

                // Nodo para actores
                TreeNode actoresNode = new TreeNode("Actores");
                if (pelicula.Actores != null)
                {
                    foreach (Actor actor in pelicula.Actores)
                    {
                        TreeNode actorNode = new TreeNode(actor.Nombre);
                        actoresNode.Nodes.Add(actorNode);
                    }
                }

                // Agregar nodos de producción y actores al nodo principal
                nodo.Nodes.Add(produccionNode);
                nodo.Nodes.Add(actoresNode);

                DetalleTreeview.Nodes.Add(nodo);
            }
        }


        private void ListarPeliculas() //--------------------------------------*
        {
            // Limpiar el DataGridView
            PeliculasDGV.Columns.Clear();

            // Configurar el DataGridView
            PeliculasDGV.AutoGenerateColumns = false;

            // Configurar las columnas que deseas mostrar
            DataGridViewTextBoxColumn ColumnaCodigo = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Codigo",
                HeaderText = "Codigo"
            };

            DataGridViewTextBoxColumn ColumnaTitulo = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Titulo",
                HeaderText = "Titulo"
            };

            // Agregar las columnas al DataGridView
            PeliculasDGV.Columns.Add(ColumnaCodigo);
            PeliculasDGV.Columns.Add(ColumnaTitulo);
            PeliculasDGV.DataSource = peliculaBLL.ListarTodo();
        }


        private void Restablecer(object sender, EventArgs e) //----------------*
        {
            LimpiarControles();
            ListarPeliculas();
        }
        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||


        private Pelicula ArmarObjeto() //--------------------------------------*
        {
            Pelicula pelicula = new Pelicula
            {
                Codigo = Int32.Parse(CodigoTextbox.Text),
                Titulo = TituloTextbox.Text,
                Produccion = new Produccion
                {
                    AñoEstreno = int.Parse(AñoEstrenoTextbox.Text),
                    Distribuidora = DistribuidoraTextbox.Text
                },
                Actores = ListarActores()
            };
            return pelicula;
        }

        private List<Actor> ListarActores()
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
                        Nombre = celdas["ColumnaNombre"].Value.ToString(),
                        Personaje = celdas["ColumnaPersonaje"].Value.ToString()
                    };

                    // Agregar el objeto Actor a la lista
                    actores.Add(actor);
                }
            }
            return actores;
        }

        private void LimpiarControles()
        {
            PeliculasDGV.DataSource = null;
            ActoresDGV.DataSource = null;

            CodigoTextbox.Text = string.Empty;
            TituloTextbox.Text = string.Empty;
            AñoEstrenoTextbox.Text = string.Empty;
            DistribuidoraTextbox.Text = string.Empty;

            foreach (Control control in Controls)
            {
                if (control is GroupBox groupBox)
                {
                    foreach (Control c in groupBox.Controls)
                    {
                        if (c is TextBox textBox)
                        {
                            textBox.Text = string.Empty;
                        }
                        else if (c is RadioButton radioButton)
                        {
                            radioButton.Checked = false;
                        }
                    }
                }
            }
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
    }
}
