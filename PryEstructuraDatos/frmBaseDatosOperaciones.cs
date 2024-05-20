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
    public partial class frmBaseDatosOperaciones : Form
    {
        public frmBaseDatosOperaciones()
        {
            InitializeComponent();
        }

        clsBaseDatos objBaseDatos = new clsBaseDatos();

        private void btnProySimple_Click(object sender, EventArgs e)
        {
            string varSQL = "SELECT TITULO " + "FROM LIBRO " + "ORDER BY 1 DESC";
            objBaseDatos.Listar(dgvBaseDatos, varSQL);
        }

        private void btnProyMulti_Click(object sender, EventArgs e)
        {
            string varSQL = "SELECT TITULO, AÑO " + "FROM LIBRO " + "ORDER BY 1 DESC";
            objBaseDatos.Listar(dgvBaseDatos, varSQL);
        }

        private void btnJuntar_Click(object sender, EventArgs e)
        {
            string varSQL = "SELECT * FROM LIBRO, PAIS  " + "WHERE Libro.IdPais = pais.Idpais";
            objBaseDatos.Listar(dgvBaseDatos, varSQL);
        }

        private void btnSelSimple_Click(object sender, EventArgs e)
        {
            string varSQL = "SELECT PRECIO " + "FROM LIBRO " + "WHERE PRECIO < 1985 " + "ORDER BY 1 DESC";
            objBaseDatos.Listar(dgvBaseDatos, varSQL);
        }

        private void btnSelMulti_Click(object sender, EventArgs e)
        {
            string varSQL = "SELECT TITULO, AÑO, PRECIO " + "FROM LIBRO " + "WHERE PRECIO < 985 " + "ORDER BY 1 DESC";
            objBaseDatos.Listar(dgvBaseDatos, varSQL);
        }

        private void btnSelConvolucion_Click(object sender, EventArgs e)
        {
            string varSQL = "SELECT * FROM(SELECT NOMBRE FROM PAIS WHERE IDPAIS > 10)  AS T1";
            objBaseDatos.Listar(dgvBaseDatos, varSQL);
        }
    }
}
