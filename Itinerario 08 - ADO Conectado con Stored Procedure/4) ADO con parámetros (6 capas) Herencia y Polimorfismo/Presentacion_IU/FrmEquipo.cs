using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Negocio_BLL;
using BE;

namespace Presentacion_IU
{
    public partial class FrmEquipo : Form
    {
        readonly BLLTecnico oBLLTecnico;
        readonly BLLEquipo oBLLEquipo;
        readonly BLLPrincipiante oBLLPrin;
        readonly BLLProfesional oBLLProf;
        BEEquipo oBEEquipo;
        BEProfesional oJugadorPro;
        BEPrincipiante oJugadorprin;
        List<BEEquipo> LBEEquipo;

        public FrmEquipo()
        {
            InitializeComponent();

            oBLLTecnico = new BLLTecnico();
            oBLLEquipo = new BLLEquipo();
            oBLLPrin = new BLLPrincipiante();
            oBLLProf = new BLLProfesional();
        }

        //|||||||||||||||||||||||||||||||||||||||| OPERACIONES DE CARGA DEL FORM

        private void FrmEquipo_Load(object sender, EventArgs e)
        {
            CargarTecnicos();
            CargarEquipos();
            InfoLabel.Text = string.Empty;
            AgregarEquipoButton.Click += AgregarEquipo;
            AgregarJugadorButton.Click += AgregarJugador;
            BuscarPuntajeButton.Click += MayorPuntaje;
            EquiposDGV.RowEnter += ListarJugadores;
        }


        // ComboBox
        public void CargarTecnicos()
        {
            TecnicosCombobox.DataSource = null;
            TecnicosCombobox.DataSource = oBLLTecnico.ListarTodo();
            // La siguiente línea, en este contexto, no es necesaria. ValueMember,
            // lo que hace es devolver el valor de una propiedad del objeto, la
            // propiedad que yo elija. Pero en este caso, se recuperará el objeto
            // completo y no una propiedad en particular (que, de todas maneras,
            // tendría que haber sido el Código de Técnico, y no el DNI).
            //TecnicosCombobox.ValueMember = "DNI";
            TecnicosCombobox.DisplayMember = "Apellido";
            TecnicosCombobox.Refresh();
        }


        // DataGridView 1
        public void CargarEquipos()
        {
            // Es necesario limpiar la grilla para que no se dupliquen los datos
            // cuando se agrega un nuevo equipo.
            EquiposDGV.DataSource = null;
            EquiposDGV.DataSource = oBLLEquipo.ListarTodo();
        }


        // DataGridView 2
        private void ListarJugadores(object sender, DataGridViewCellEventArgs e)
        {
            // Es necesario limpiar la grilla para que no se dupliquen los datos
            // cuando se agrega un nuevo jugador (o cuando listo otro equipo).
            JugadoresDGV.DataSource = null;

            if (EquiposDGV.CurrentRow != null)
            {
                // Reemplazo la siguiente línea porque no funciona cuando se
                // selecciona una nueva fila en la grilla de equipos (tira un
                // resultado desfasado, lista los jugadores del equipo anterior).
                //oBEEquipo = (BEEquipo)EquiposDGV.CurrentRow.DataBoundItem;
                oBEEquipo = (BEEquipo)EquiposDGV.Rows[e.RowIndex].DataBoundItem;
                List<BEJugador> jugadores = oBEEquipo.ListaJugadores;

                if (jugadores != null)
                {
                    //como el objeto Equipo tiene ya su lista de jugadores, la muestro
                    //dataGridJugadores.DataSource = oBEEquipo.ListaJugadores;
                    JugadoresDGV.DataSource = jugadores;

                    JugadoresDGV.Columns["CantidadAmarillas"].HeaderText = "T. Amarillas";
                    JugadoresDGV.Columns["CantidadRojas"].HeaderText = "T. Rojas";
                    JugadoresDGV.Columns["GolesRealizados"].HeaderText = "Goles";
                }
            }
        }


        // Botón 1
        private void AgregarEquipo(object sender, EventArgs e)
        {
            oBEEquipo = new BEEquipo
            {
                Nombre = TxtNombreEquipo.Text,
                Color = TxtColoresEquipo.Text,
                Tecnico = (BETecnico)TecnicosCombobox.SelectedItem
            };

            // Llama a la BLL y cargo al equipo.
            if (oBLLEquipo.Guardar(oBEEquipo))
            {
                // Si guardar equipo da OK, entonces actualizo el estado del técnico
                // para que no figure en el combo y no pueda ser asginado a otro equipo.
                oBLLTecnico.Guardar(oBEEquipo.Tecnico);
            }
            CargarTecnicos();
            CargarEquipos();
            Limpiar();
        }


        // Botón 2
        private void AgregarJugador(object sender, EventArgs e)
        {
            if (EquiposDGV.SelectedRows.Count > 0)
            {
                oBEEquipo = (BEEquipo)EquiposDGV.CurrentRow.DataBoundItem;

                // Depende el tipo de jugador, instancio una clase o la otra.
                if (comboBox2.Text == "Profesional")
                {
                    oJugadorPro = new BEProfesional
                    {
                        Nombre = TextBox1.Text,
                        Apellido = TextBox2.Text,
                        DNI = Convert.ToInt32(TextBox3.Text),
                        CantidadAmarillas = Convert.ToInt32(TextBox5.Text),
                        CantidadRojas = Convert.ToInt32(TextBox4.Text),
                        GolesRealizados = Convert.ToInt32(TextBox6.Text)
                    };

                    // Paso los datos a la BLL para Ingresar el jugador en la BD.
                    if (oBLLProf.Guardar(oJugadorPro))
                    {
                        // Si el jugador se graba OK, llamo a otro método para
                        // grabar en la tabla intermedia. Para eso, paso el equipo
                        // y el jugador.
                        oBLLProf.Guardar_JugadorXEquipo(oJugadorPro, oBEEquipo); 
                    }
                    CargarEquipos();
                    Limpiar();
                }
                else
                {
                    oJugadorprin = new BEPrincipiante
                    {
                        Rapado = true,
                        Nombre = TextBox1.Text,
                        Apellido = TextBox2.Text,
                        DNI = Convert.ToInt32(TextBox3.Text),
                        CantidadAmarillas = Convert.ToInt32(TextBox5.Text),
                        CantidadRojas = Convert.ToInt32(TextBox4.Text),
                        GolesRealizados = Convert.ToInt32(TextBox6.Text)
                    };

                    if (oBLLPrin.Guardar(oJugadorprin))
                    {
                        oBLLPrin.Guardar_JugadorXEquipo(oJugadorprin, oBEEquipo);
                    }
                    CargarEquipos();
                    Limpiar();
                }
            }
            else { MessageBox.Show("Debe seleccionar un equipo para agregar al jugador"); }
        }


        // Botón 3
        private void MayorPuntaje(object sender, EventArgs e)
        {
            int maxPuntaje = 0;
            string maxEquipo = string.Empty;

            BLLEquipo oBLLEquipo = new BLLEquipo();

            LBEEquipo = oBLLEquipo.ListarTodo();

            foreach (BEEquipo oBEEquipo in LBEEquipo)
            {
                if (oBEEquipo.ListaJugadores != null)
                {
                    if (oBLLEquipo.ObtenerPuntajeEquipo(oBEEquipo) > maxPuntaje)
                    {
                        maxEquipo = oBEEquipo.Nombre;
                        maxPuntaje = oBLLEquipo.ObtenerPuntajeEquipo(oBEEquipo);
                    }
                }
            }
            InfoLabel.Text = $"El puntaje máximo es del equipo {maxEquipo}: {Convert.ToString(maxPuntaje)}";
        }

        //|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||| HELPERS

        void Limpiar()
        {
            TxtNombreEquipo.Text = string.Empty;
            TxtColoresEquipo.Text = string.Empty;
            TextBox1.Text = string.Empty;
            TextBox2.Text = string.Empty;
            TextBox3.Text = string.Empty;
            TextBox4.Text = string.Empty;
            TextBox5.Text = string.Empty;
            TextBox6.Text = string.Empty;
        }

        //||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

    }
}
