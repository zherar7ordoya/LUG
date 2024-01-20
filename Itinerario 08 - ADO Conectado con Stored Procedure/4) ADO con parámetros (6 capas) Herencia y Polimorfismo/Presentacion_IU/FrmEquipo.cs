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

            List<BETecnico> listaTecnicos = oBLLTecnico.ListarTodo();

            // ES UNA BUENA IDEA MANEJAR CASOS COMO ESTOS EN LA GUI Y NO EN LA BLL.
            // EN EL TRABAJO FINAL, UN COMPAÑERO MANEJÓ ASÍ LA AUSENCIA DE USUARIO
            // O CONTRASEÑA EN EL LOGIN, Y NO LO COMPLICÓ EN LAS CAPAS DE NEGOCIO.
            if (listaTecnicos.Count == 0)
            {
                AgregarEquipoButton.Enabled = false; // * A ESTO ME REFIERO * //
                MessageBox.Show("No hay técnicos disponibles");
                return;
            }
            else
            {
                AgregarEquipoButton.Enabled = true;  // * A ESTO ME REFIERO * //
                TecnicosCombobox.DataSource = listaTecnicos;

                #region ¿Por qué no es necesario ValueMember en este caso?
                // La siguiente línea, en este contexto, no es necesaria. ValueMember,
                // lo que hace es devolver el valor de una propiedad del objeto, la
                // propiedad que yo elija. Pero en este caso, se recuperará el objeto
                // completo y no una propiedad en particular (que, de todas maneras,
                // tendría que haber sido el Código de Técnico, y no el DNI).
                //TecnicosCombobox.ValueMember = "DNI";
                #endregion
                TecnicosCombobox.DisplayMember = "Apellido";
                TecnicosCombobox.Refresh();
            }
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
            if (EquiposDGV.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un equipo para agregar al jugador");
                return;
            }

            var equipoSeleccionado = (BEEquipo)EquiposDGV.CurrentRow.DataBoundItem;

            BEJugador nuevoJugador;

            switch ((TipoJugador)comboBox2.SelectedIndex)
            {
                case TipoJugador.Profesional:
                    nuevoJugador = new BEProfesional();
                    break;

                case TipoJugador.Principiante:
                    nuevoJugador = new BEPrincipiante { Rapado = true };
                    break;

                default:
                    MessageBox.Show("Tipo de jugador no reconocido");
                    return;
            }

            nuevoJugador.Nombre = TextBox1.Text;
            nuevoJugador.Apellido = TextBox2.Text;
            nuevoJugador.DNI = Convert.ToInt32(TextBox3.Text);
            nuevoJugador.CantidadAmarillas = Convert.ToInt32(TextBox5.Text);
            nuevoJugador.CantidadRojas = Convert.ToInt32(TextBox4.Text);
            nuevoJugador.GolesRealizados = Convert.ToInt32(TextBox6.Text);

            // Guardar jugador y asociarlo al equipo
            if (GuardarAsociar(nuevoJugador, equipoSeleccionado))
            {
                CargarEquipos();
                Limpiar();
            }
        }

        // Método asociado al botón 2.
        private bool GuardarAsociar(BEJugador jugador, BEEquipo equipo)
        {
            try
            {
                if (jugador is BEProfesional profesional)
                {
                    // Si el jugador se graba OK, llamo a otro método para grabar
                    // en la tabla intermedia. Para eso, paso el equipo y el jugador.
                    if (oBLLProf.Guardar(profesional))
                    {
                        oBLLProf.Guardar_JugadorXEquipo(profesional, equipo);
                        return true;
                    }
                }
                else if (jugador is BEPrincipiante principiante)
                {
                    if (oBLLPrin.Guardar(principiante))
                    {
                        oBLLPrin.Guardar_JugadorXEquipo(principiante, equipo);
                        return true;
                    }
                }

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar jugador: {ex.Message}");
                return false;
            }
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
