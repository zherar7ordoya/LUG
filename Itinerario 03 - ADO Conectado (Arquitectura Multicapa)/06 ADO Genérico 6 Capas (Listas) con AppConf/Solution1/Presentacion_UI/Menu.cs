﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion_UI
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frAlumno ofra = new frAlumno();
            ofra.MdiParent = this;
            ofra.Show();
        }

        private void localidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frLocalidad ofrLoc = new frLocalidad();
            ofrLoc.MdiParent = this;
            ofrLoc.Show();
        }

        
        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frMateria ofrMat = new frMateria();
            ofrMat.MdiParent = this;
            ofrMat.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void asignacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MateriasXAlumno ofmxa= new MateriasXAlumno();
            ofmxa.MdiParent = this;
            ofmxa.Show();
        }
    }
}
