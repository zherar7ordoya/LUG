﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud_WindowsForms_AdoNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarDGV();
        }

        private void ActualizarDGV()
        {
            PeopleDB oPeopleDB = new PeopleDB();
            dataGridView1.DataSource = oPeopleDB.Get();
        }

        private void RefrescarButton_Click(object sender, EventArgs e)
        {
            ActualizarDGV();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            FrmNuevo frm = new FrmNuevo();
            frm.ShowDialog();
            ActualizarDGV();
        }

        private void EditarButton_Click(object sender, EventArgs e)
        {
            int? Id = GetId();
            if (Id != null)
            {
                FrmNuevo frmEdit = new FrmNuevo(Id);
                frmEdit.ShowDialog();
                ActualizarDGV();
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int? Id = GetId();
            try
            {
                if (Id != null)
                {
                    PeopleDB oPeopleDB = new PeopleDB();
                    oPeopleDB.Delete((int)Id);
                    ActualizarDGV();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al eliminar: "+ex.Message);
            }
        }

        #region HELPER
        private int? GetId()
        {
            try
            {
                return int.Parse(dataGridView1
                    .Rows[dataGridView1.CurrentRow.Index]
                    .Cells[0]
                    .Value.ToString());
            }
            catch
            {
                return null;
            }
        }

        #endregion

       
    }
}
