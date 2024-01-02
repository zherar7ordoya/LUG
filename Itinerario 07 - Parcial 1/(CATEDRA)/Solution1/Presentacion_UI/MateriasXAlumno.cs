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
using BE;

namespace Presentacion_UI
{
    public partial class MateriasXAlumno : Form
    {
        public MateriasXAlumno()
        {
            InitializeComponent();
            oBLLAlumno = new BLLAlumno();
            oBLLMateria = new BLLMateria();
            oBEAlumno = new BEAlumno();
            oBEMateria = new BEMateria();
        }

        private void MateriasXAlumno_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            CargarComboMateria();

        }

        BEAlumno oBEAlumno;
        BEMateria oBEMateria;
        BLLAlumno oBLLAlumno;
        BLLMateria oBLLMateria;
       
        void CargarGrilla()
        {
          
            this.dataGridView1.DataSource = null;
            //llamo al metodo cargar alumnos de la BLLAlumno que me devuelve una lista
            this.dataGridView1.DataSource = oBLLAlumno.ListarTodo();
            //propiedad de la grilla para autosize de columnas
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            //cambio color alternando las filas de la grilla
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            //oculto la columna de locaidad
            this.dataGridView1.Columns["oBELocalidad"].Visible = false;
        }

        void CargarComboMateria()
        {
            
            cmbMateria.DataSource = null;
            //llamo al metodo para cargar Materias de la BLL de materia
            cmbMateria.DataSource = oBLLMateria.ListarTodo();
            //aclaro cual es el valor y lo que se desea mostrar en el combo
            cmbMateria.ValueMember = "Codigo";
            //la variable publica de la clase
            cmbMateria.DisplayMember = "Materia";
            cmbMateria.Refresh();
        }

          private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {   //recupero los datos del objeto seleccionado

            oBEAlumno = (BEAlumno)dataGridView1.CurrentRow.DataBoundItem;

            //lleno el datagrid de materias con la propiedad lista de materias de Alumno
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = oBEAlumno.ListaMaterias;
            //propiedad de la grilla para autosize de columnas
            this.dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            label3.Text = "Nombre: " + oBEAlumno.Nombre + " Apellido: " + oBEAlumno.Apellido + " DNI: " + oBEAlumno.DNI;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
               
                oBEMateria = (BEMateria)cmbMateria.SelectedItem;

                if (oBEAlumno.ListaMaterias != null)
                {
                    //verifico que la materia no exista asociada con anterioridad
                    foreach (BEMateria mat in oBEAlumno.ListaMaterias)
                    {
                        if (mat.Codigo == oBEMateria.Codigo)
                        {
                            MessageBox.Show("La Materia ya se encuentra asociada al Alumno");
                            //si exite con el break sale del foreach
                            break;
                        }
                        else
                        {    //agrego la materia al alumno
                            oBLLAlumno.AgregarAlumno_Materia(oBEAlumno, oBEMateria);
                            break;
                        }

                    }
                }
                else
                {//si la lista esta vacia lo asigno
                    oBLLAlumno.AgregarAlumno_Materia(oBEAlumno, oBEMateria);
                }
                    //cargo nuevamente las grilla y combo con los datos actualizados
                    CargarGrilla();
                dataGridView2.DataSource = null;

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {//selecciono  al alumno y la materia para luego eliminarlo
                if (oBEAlumno.Codigo != 0 && oBEMateria.Codigo != 0)
                {
                    oBLLAlumno.QuitarAlumno_Materia(oBEAlumno, oBEMateria);

                }
                else
                {
                    MessageBox.Show("Selecciono un Alumno y Materia de las grillas"); 
                }
                //cargo nuevamente las grilla y combo con los datos actualizados
                CargarGrilla();
                dataGridView2.DataSource = null;
          

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

       
         private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            oBEMateria = (BEMateria)this.dataGridView2.CurrentRow.DataBoundItem;
        }
    }

 }

    
 
