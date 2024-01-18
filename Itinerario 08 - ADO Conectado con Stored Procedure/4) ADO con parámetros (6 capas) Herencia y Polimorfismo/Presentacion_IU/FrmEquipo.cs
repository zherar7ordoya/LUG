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
        BLLTecnico oBLLTecnico;
        BLLEquipo oBLLEquipo;
        BLLPrincipiante oBLLPrin;
        BLLProfesional oBLLProf;
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

            CargarEquipos();
        }

        private void FrmEquipo_Load(object sender, EventArgs e)
        {
            CargarTecnicos();
            CargarEquipos();
            InfoLabel.Text = string.Empty;
        }

        public void CargarTecnicos()
        {
            TecnicosCombobox.DataSource = null;
            TecnicosCombobox.DataSource = oBLLTecnico.ListarTodo();
            TecnicosCombobox.ValueMember = "DNI";
            TecnicosCombobox.DisplayMember = "Apellido";
            TecnicosCombobox.Refresh();
        }


        //cargo el datagrid con la lista
        public void CargarEquipos()
        {
            this.dataGridEquipo.DataSource = null;
            // lo limpio paraque me actualice cuando agrego valores a la lista
            this.dataGridEquipo.DataSource = oBLLEquipo.ListarTodo();
            //propiedad de la grilla para autosize de columnas
            this.dataGridEquipo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            //cambio color alternando las filas de la grilla
            this.dataGridEquipo.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGreen;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //instancio el objeto equipo en el bloque
            oBEEquipo = new BEEquipo();
            //asigno los valores en el bloque para el Objeto Equipo
            oBEEquipo.Nombre = this.TxtNombreEquipo.Text;
            oBEEquipo.Color = this.TxtColoresEquipo.Text;
            oBEEquipo.Tecnico = (BETecnico)TecnicosCombobox.SelectedItem;

            //llama a la BLL y cargo al equipo

            if(oBLLEquipo.Guardar(oBEEquipo))
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

        private void Button2_Click(object sender, EventArgs e)
        {

            if (dataGridEquipo.SelectedRows.Count > 0)
            {
                oBEEquipo = (BEEquipo)dataGridEquipo.CurrentRow.DataBoundItem;
               
                //depende el tipo de jugador instancio una clase u otra
                if (comboBox2.Text == "Profesional")
                {
                    oJugadorPro = new BEProfesional();
                    //asigno los valores al objeto
                    oJugadorPro.Nombre = TextBox1.Text;
                    oJugadorPro.Apellido = textBox5.Text;
                    oJugadorPro.DNI = Convert.ToInt32(textBox6.Text);
                    oJugadorPro.CantidadAmarillas = Convert.ToInt32(TextBox3.Text);
                    oJugadorPro.CantidadRojas = Convert.ToInt32(TextBox2.Text);
                    oJugadorPro.GolesRealizados = Convert.ToInt32(TextBox4.Text);

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
                    oJugadorprin.Apellido = textBox5.Text;
                    oJugadorprin.DNI = Convert.ToInt32(textBox6.Text);
                    oJugadorprin.CantidadAmarillas = Convert.ToInt32(TextBox3.Text);
                    oJugadorprin.CantidadRojas = Convert.ToInt32(TextBox2.Text);
                    oJugadorprin.GolesRealizados = Convert.ToInt32(TextBox4.Text);
                    
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
            else 
            
            {MessageBox.Show("Debe seleccionar un equipo para agregar al jugador"); }
        }

        void Limpiar()
        {
            TextBox1.Text = string.Empty;
            TextBox2.Text = string.Empty;
            TextBox3.Text = string.Empty;
            TextBox4.Text = string.Empty;


        }

        private void dataGridEquipo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Haya o no haya jugadores en el equipo, tengo que limpiar la grilla.
            dataGridJugadores.DataSource = null;
            oBEEquipo = (BEEquipo)this.dataGridEquipo.CurrentRow.DataBoundItem;
            List<BEJugador> jugadores = oBEEquipo.ListaJugadores;

            if (jugadores != null)
            {
                //como el objeto Equipo tiene ya su lista de jugadores, la muestro
                //dataGridJugadores.DataSource = oBEEquipo.ListaJugadores;
                dataGridJugadores.DataSource = jugadores;
                //propiedad de la grilla para autosize de columnas
                dataGridJugadores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                //cambio color alternando las filas de la grilla
                dataGridJugadores.AlternatingRowsDefaultCellStyle.BackColor = Color.GreenYellow;
                dataGridJugadores.Columns["CantidadAmarillas"].HeaderText = "T.Amarillas";
                dataGridJugadores.Columns["CantidadRojas"].HeaderText = "T.Rojas";
                dataGridJugadores.Columns["GolesRealizados"].HeaderText = "Goles";
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int MaxPtje = 0;
            string MaxNomb = string.Empty;

            BLLEquipo oBLLEquipo = new BLLEquipo();

            LBEEquipo = oBLLEquipo.ListarTodo();

            foreach (BEEquipo oBEEquipo in LBEEquipo)
            {
                if (oBEEquipo.ListaJugadores != null)
                {
                    if (oBLLEquipo.ObtenerPuntajeEquipo(oBEEquipo) > MaxPtje)
                    {
                        MaxNomb = oBEEquipo.Nombre;
                        MaxPtje = oBLLEquipo.ObtenerPuntajeEquipo(oBEEquipo);
                    }
                }
            }
            InfoLabel.Text = "El puntaje Maximo fue del equipo " + MaxNomb + " : " + Convert.ToString(MaxPtje);
        }
    }
}
