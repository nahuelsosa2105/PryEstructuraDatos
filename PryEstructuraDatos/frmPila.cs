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
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }

        clsPila Pila = new clsPila();

        private void frmPila_FormClosed(object sender, FormClosedEventArgs e)
        {
            //frmVentanaPrincipal volverInicio = new frmVentanaPrincipal();
            //volverInicio.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            ObjNodo.Nombre = txtNombre.Text;
            ObjNodo.Tramite = txtTramite.Text;
            Pila.Agregar(ObjNodo);
            Pila.Recorrer(dgvListado);
            Pila.Recorrer(lstCola);
            Pila.Recorrer();
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Pila.Primero != null)
            {
                lblMostrarCod.Text = Pila.Primero.Codigo.ToString();
                lblMostrarNombre.Text = Pila.Primero.Nombre;
                lblMostrarTramite.Text = Pila.Primero.Tramite;
                Pila.Eliminar();
                Pila.Recorrer(dgvListado);
                Pila.Recorrer(lstCola);
                Pila.Recorrer();
            }
            else
            {
                lblMostrarCod.Text = "";
                lblMostrarNombre.Text = "";
                lblMostrarTramite.Text = "";
            }
        }
    }
}
