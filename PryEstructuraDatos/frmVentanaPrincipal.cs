﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryEstructuraDatos
{
    public partial class frmVentanaPrincipal : Form
    {
        public frmVentanaPrincipal()
        {
            InitializeComponent();
        }

        private void datosDelDesarrolladorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDatosDesarrollador frmDatosDesarrollador = new frmDatosDesarrollador();
            frmDatosDesarrollador.ShowDialog();
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPila pasarPila = new frmPila();
            pasarPila.ShowDialog();
        }

        private void listaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmListaSimple pasarListaSimple = new frmListaSimple();
            pasarListaSimple.ShowDialog();
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCola pasarCola = new frmCola();
            pasarCola.ShowDialog();
        }
    }
}
