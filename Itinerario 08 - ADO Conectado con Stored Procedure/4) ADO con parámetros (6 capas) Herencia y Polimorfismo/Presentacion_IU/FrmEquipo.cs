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

                    JugadoresDGV.Columns["CantidadAmarillas"].HeaderText = "T.Amarillas";
                    JugadoresDGV.Columns["CantidadRojas"].HeaderText = "T.Rojas";
                    JugadoresDGV.Columns["GolesRealizados"].HeaderText = "Goles";
                }
            }
        }


        // Botón 1
        private void AgregarEquipo(object sender, EventArgs e)
        {
            //instancio el objeto equipo en el bloque
            oBEEquipo = new BEEquipo();
            //asigno los valores en el bloque para el Objeto Equipo
            oBEEquipo.Nombre = TxtNombreEquipo.Text;
            oBEEquipo.Color = TxtColoresEquipo.Text;
            oBEEquipo.Tecnico = (BETecnico)TecnicosCombobox.SelectedItem;

            //llama a la BLL y cargo al equipo

            if (oBLLEquipo.Guardar(oBEEquipo))
            {
                //si se guarda OK Equipo, entonces actualizo el estado del tecnico para que no aparezca en el combo
                //y asi no pueda estar asginado a otro equipo

                oBLLTecnico.Guardar(oBEEquipo.Tecnico);

            }
            //actualizo el combo de tecnicos
            CargarTecnicos();

            //lo muestro en la grilla de equipos
            CargarEquipos();

            //limpio los txt de equipo
            TxtNombreEquipo.Text = string.Empty;
            TxtColoresEquipo.Text = string.Empty;
        }


        // Botón 2
        private void AgregarJugador(object sender, EventArgs e)
        {
            if (EquiposDGV.SelectedRows.Count > 0)
            {
                oBEEquipo = (BEEquipo)EquiposDGV.CurrentRow.DataBoundItem;

                //depende el tipo de jugador instancio una clase u otra
                if (comboBox2.Text == "Profesional")
                {
                    oJugadorPro = new BEProfesional();
                    //asigno los valores al objeto
                    oJugadorPro.Nombre = TextBox1.Text;
                    oJugadorPro.Apellido = TextBox2.Text;
                    oJugadorPro.DNI = Convert.ToInt32(TextBox3.Text);
                    oJugadorPro.CantidadAmarillas = Convert.ToInt32(TextBox5.Text);
                    oJugadorPro.CantidadRojas = Convert.ToInt32(TextBox4.Text);
                    oJugadorPro.GolesRealizados = Convert.ToInt32(TextBox6.Text);

                    //paso los datos a la BLL para Ingresar el jugador en la BD
                    if (oBLLProf.Guardar(oJugadorPro))
                    //si el jugador se graba en la BD llamo a otro método para grabar en la tabla intermedia
                    // por eso paso el equipo y el jugador
                    { oBLLProf.Guardar_JugadorXEquipo(oJugadorPro, oBEEquipo); }

                    //cargo la lista de equipos, asi actualizo y puedo ver los jugadores asociados al equipo
                    CargarEquipos();
                    Limpiar();
                }
                else
                {
                    oJugadorprin = new BEPrincipiante();
                    //asigno los valores al objeto
                    oJugadorprin.Rapado = true;
                    oJugadorprin.Nombre = TextBox1.Text;
                    oJugadorprin.Apellido = TextBox2.Text;
                    oJugadorprin.DNI = Convert.ToInt32(TextBox3.Text);
                    oJugadorprin.CantidadAmarillas = Convert.ToInt32(TextBox5.Text);
                    oJugadorprin.CantidadRojas = Convert.ToInt32(TextBox4.Text);
                    oJugadorprin.GolesRealizados = Convert.ToInt32(TextBox6.Text);

                    //paso los datos a la BLL para Ingresar el jugador en la BD
                    if (oBLLPrin.Guardar(oJugadorprin))
                    //si el jugador se graba en la BD llamo a otro método para grabar en la tabla intermedia
                    // por eso paso el equipo y el jugador
                    { oBLLPrin.Guardar_JugadorXEquipo(oJugadorprin, oBEEquipo); }

                    //cargo la lista de equipos, asi actualizo y puedo ver los jugadores asociados al equipo
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
