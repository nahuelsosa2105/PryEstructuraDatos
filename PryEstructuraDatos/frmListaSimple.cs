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
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }

        clsListaSimple Lista = new clsListaSimple();

        private void frmListaSimple_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmVentanaPrincipal volverInicio = new frmVentanaPrincipal();
            volverInicio.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //if (txtCodigo.Text != null || txtNombre.Text != null || txtTramite.Text !=null)
            //{
                clsNodo ObjNodo = new clsNodo();
                ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
                ObjNodo.Nombre = txtNombre.Text;
                ObjNodo.Tramite = txtTramite.Text;
                Lista.Agregar(ObjNodo);
                Lista.Recorrer(dgvListado);
                Lista.Recorrer(lstCola);
                Lista.Recorrer(cmbCodigo);
                Lista.Recorrer();
                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtTramite.Text = "";
                
            //}
            //else
            //{
                btnAgregar.Enabled = false;
                MessageBox.Show("Algun campo vacio");

                
            //}
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //if (Lista.Primero != null)
            //{
            //    lblMostrarCod.Text = Pila.Primero.Codigo.ToString();
            //    lblMostrarNombre.Text = Pila.Primero.Nombre;
            //    lblMostrarTramite.Text = Pila.Primero.Tramite;
            //    Lista.Eliminar();
            //    Lista.Recorrer(dgvListado);
            //    Lista.Recorrer(lstCola);
            //    Lista.Recorrer();
            //}
            //else
            //{
            //    lblMostrarCod.Text = "";
            //    lblMostrarNombre.Text = "";
            //    lblMostrarTramite.Text = "";
            //}
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if(txtCodigo.Text == "")
            {
                btnAgregar.Enabled = false;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if(txtNombre.Text == "")
            {
                btnAgregar.Enabled = false;
            }
        }

        private void txtTramite_TextChanged(object sender, EventArgs e)
        {
            if (txtTramite.Text == "")
            {
                btnAgregar.Enabled = false;
            }
        }
    }
}
