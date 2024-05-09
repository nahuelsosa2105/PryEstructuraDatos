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
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
        }

        clsListaDoble Lista = new clsListaDoble();
        bool cajaCod = false;
        bool cajaNombre = false;
        bool cajaTramite = false;

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cajaCod == true && cajaNombre == true && cajaTramite == true)
            {
                clsNodo ObjNodo = new clsNodo();
                ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
                ObjNodo.Nombre = txtNombre.Text;
                ObjNodo.Tramite = txtTramite.Text;
                Lista.Agregar(ObjNodo);
                Lista.Recorrer(dgvListado);
                Lista.Recorrer(lstListaDoble);
                Lista.Recorrer(cmbCodigo);
                Lista.Recorrer();
                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtTramite.Text = "";

            }
            else
            {
                //btnAgregar.Enabled = false;
                MessageBox.Show("Algun campo vacio");

            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                cajaCod = false;
            }
            else
            {
                cajaCod = true;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                cajaNombre = false;
            }
            else
            {
                cajaNombre = true;
            }
        }

        private void txtTramite_TextChanged(object sender, EventArgs e)
        {
            if (txtTramite.Text == "")
            {
                cajaTramite = false;
            }
            else
            {
                cajaTramite = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Lista.Primero != null)
            {
                Int32 x = Convert.ToInt32(cmbCodigo.Text);
                Lista.Eliminar(x);
                Lista.Recorrer(dgvListado);
                Lista.Recorrer(lstListaDoble);
                Lista.Recorrer(cmbCodigo);
                Lista.Recorrer();
            }
            else
            {
                MessageBox.Show("La Lista está vacía");
            }
        }

        private void rdbAscendente_CheckedChanged(object sender, EventArgs e)
        {
            Lista.Recorrer(dgvListado);
            Lista.Recorrer(lstListaDoble);
            Lista.Recorrer(cmbCodigo);
        }

        private void rdbDescendente_CheckedChanged(object sender, EventArgs e)
        {
            
            Lista.RecorrerDesc(dgvListado);
            Lista.RecorrerDesc(lstListaDoble);
            Lista.RecorrerDesc(cmbCodigo);
            
        }

        private void frmListaDoble_Load(object sender, EventArgs e)
        {

        }
    }
}
