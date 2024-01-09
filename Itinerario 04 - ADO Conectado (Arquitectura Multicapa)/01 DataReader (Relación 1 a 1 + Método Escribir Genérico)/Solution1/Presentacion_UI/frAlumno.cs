﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Presentacion_UI
{
    public partial class frAlumno : Form
    {
        public frAlumno()
        {
            InitializeComponent();
            //instancio el objeto de la BLL en el constructor del formulario
           oAlu = new BLLAlumno();
           oLoc= new BLLLocalidad();
        }

        BLLAlumno oAlu;
        BLLLocalidad oLoc;
        private void frAlumno_Load(object sender, EventArgs e)
        {
            CargarComboLocalidad();
            CargarGrilla();
        }


        //cargo el combo localidad
        void CargarComboLocalidad()
        {
             comboBox1.DataSource = null;
            //llamo al metodo para cargar Localidades que me devuleve una lista
            comboBox1.DataSource = oLoc.CargarListaLocalidades();
            //aclaro cual es el valor y lo que se desea mostrar en el combo
            comboBox1.ValueMember = "Codigo";
            //la variable publica de la clase
            comboBox1.DisplayMember = "Localidad";
            comboBox1.Refresh();
        }

        void CargarGrilla()
        {
           
            this.dataGridView1.DataSource = null;
            //llamo al metodo cargar alumnos de Alumno que me devuelve una lista
            this.dataGridView1.DataSource = oAlu.CargarAlumnos();
            //propiedad de la grilla para autosize de columnas
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            //cambio color alternando las filas de la grilla
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkSeaGreen;
            //cambio el nombre de la columna oLocalidad x Localidad
            this.dataGridView1.Columns["oLocalidad"].HeaderText = "Localidad";
        }
        //Asigno los valores al objeto
        void Asignar()
        {
            try
            {
                //instancio un objeto del tipo alumno y le asigno los datos
                oAlu.Codigo = Convert.ToInt32(textcod.Text); 
                oAlu.Nombre = textNombre.Text;
                oAlu.Apellido = textApe.Text;
                oAlu.DNI = Convert.ToInt32(txtDNI.Text);
                oAlu.FechaNac = this.dateTimePicker1.Value;
                oAlu.Edad = oAlu.Calcular_Edad();
                oAlu.oLocalidad = (BLLLocalidad)this.comboBox1.SelectedItem;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        // metodo limpiar
        void Limpiar()
        {
            textNombre.Text = null;
            textApe.Text = null;
            textEdad.Text = null;
            txtDNI.Text = null;
            textcod.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //creo un objeto de la clase acceso
            Acceso oAcceso = new Acceso();
            //uso el metodo testconnection que me dice el estado de la conexion., Y USO EL CONSTRUCTOR DE MessageBox
            MessageBox.Show(oAcceso.TestConnection(),"PROBANDO",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                oAlu.Nombre = textNombre.Text;
                oAlu.Apellido = textApe.Text;
                oAlu.DNI = Convert.ToInt32(txtDNI.Text);
                oAlu.FechaNac = this.dateTimePicker1.Value;
                oAlu.Edad = oAlu.Calcular_Edad();
                oAlu.oLocalidad = (BLLLocalidad)this.comboBox1.SelectedItem;
                oAlu.AltaAlumno(oAlu);
                CargarGrilla();
                Limpiar();

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            oAlu = (BLLAlumno)this.dataGridView1.CurrentRow.DataBoundItem;
            textcod.Text = oAlu.Codigo.ToString();
            textNombre.Text = oAlu.Nombre;
            textApe.Text = oAlu.Apellido;
            txtDNI.Text = oAlu.DNI.ToString();
            textEdad.Text = oAlu.Edad.ToString();
            comboBox1.Text = oAlu.oLocalidad.Localidad;
            this.dateTimePicker1.Value = oAlu.FechaNac;
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Asignar();
                oAlu.ModifAlumno(oAlu);
                CargarGrilla();
                Limpiar();

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void BtnELiminar_Click(object sender, EventArgs e)
        {
            try
            {
                Asignar();
                DialogResult Respuesta;
                Respuesta = MessageBox.Show("¿Confirma la eleminación del Alumno?", "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Respuesta == DialogResult.Yes)
                {
                    oAlu.BajaAlumno(oAlu);
                    CargarGrilla();
                    Limpiar();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
    }
}
