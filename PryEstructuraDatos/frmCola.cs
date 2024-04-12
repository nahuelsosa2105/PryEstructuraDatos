using System;
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
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }

        clsCola FilaDePersonas = new clsCola();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            ObjNodo.Nombre = txtNombre.Text;
            ObjNodo.Tramite = txtTramite.Text;
            FilaDePersonas.Agregar(ObjNodo);
            FilaDePersonas.Recorrer(dgvListado);
            FilaDePersonas.Recorrer(lstCola);
            FilaDePersonas.Recorrer();
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(FilaDePersonas.Primero != null)
            {
                lblMostrarCod.Text = FilaDePersonas.Primero.Codigo.ToString();
                lblMostrarNombre.Text = FilaDePersonas.Primero.Nombre;
                lblMostrarTramite.Text = FilaDePersonas.Primero.Tramite;
                FilaDePersonas.Eliminar();
                FilaDePersonas.Recorrer(dgvListado);
                FilaDePersonas.Recorrer(lstCola);
                FilaDePersonas.Recorrer();
            }
            else
            {
                lblMostrarCod.Text = "";
                lblMostrarNombre.Text = "";
                lblMostrarTramite.Text = "";
            }
        }

        private void frmCola_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmVentanaPrincipal volverInicio = new frmVentanaPrincipal();
            volverInicio.ShowDialog();
        }
    }


}
