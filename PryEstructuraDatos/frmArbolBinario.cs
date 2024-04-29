using System;
using System.Collections;
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
    public partial class frmArbolBinario : Form
    {
        public frmArbolBinario()
        {
            InitializeComponent();
        }

        clsArbolBinario Arbol = new clsArbolBinario();
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
                Arbol.Agregar(ObjNodo);
                Arbol.Recorrer(dgvListado);
                Arbol.Recorrer(trvMostrar);
                //Arbol.Recorrer(cmbCodigo);
                
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
    }
}
