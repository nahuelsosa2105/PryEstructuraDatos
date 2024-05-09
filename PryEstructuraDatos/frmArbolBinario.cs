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
                Arbol.Recorrer(cmbCodigo);
                Arbol.Recorrer(trvMostrar);
                
                
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

        private void cmbCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbCodigo.SelectedIndex != -1)
            {
                btnEliminar.Enabled = true;
            }
            else
            {
                btnEliminar.Enabled = false;
            }
        }

        private void optInOrdenAsc_CheckedChanged(object sender, EventArgs e)
        {
            Arbol.Recorrer(dgvListado);
            Arbol.Recorrer(cmbCodigo);
        }

        private void optInOrdenDesc_CheckedChanged(object sender, EventArgs e)
        {
            Arbol.RecorrerDesc(dgvListado);
            Arbol.RecorrerArbolDesc(cmbCodigo);
        }

        private void optPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            Arbol.RecorrerPreOrden(dgvListado);
        }

        private void optPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            Arbol.RecorrerPostOrden(dgvListado);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(Arbol.Raiz != null)
            {
                Int32 x = Convert.ToInt32(cmbCodigo.Text);
                Arbol.Eliminar(x);
                Arbol.Recorrer(dgvListado);
                Arbol.Recorrer(cmbCodigo);
                Arbol.Recorrer(trvMostrar);
                
                optInOrdenDesc.Checked = false;
                optPostOrden.Checked = false;
                optPreOrden.Checked = false;
            }
            else
            {
                MessageBox.Show("El árbol se encuentra vacío");
            }
            cmbCodigo.Text = "";
            btnEliminar.Enabled = false;
        }

        private void btnEquilibrar_Click(object sender, EventArgs e)
        {
            Arbol.Equilibrar();
            Arbol.Recorrer(trvMostrar);
        }

        
    }
}
