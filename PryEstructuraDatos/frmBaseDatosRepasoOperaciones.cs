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
    public partial class frmBaseDatosRepasoOperaciones : Form
    {
        public frmBaseDatosRepasoOperaciones()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            clsBaseDatos objBD = new clsBaseDatos();
            string VarSQL = "SELECT * FROM LIBRO";
            switch(cmbListar.SelectedIndex)
            {
                case 0:
                    lblListar.Text = cmbListar.Text + ": " + "Paises que no tienen libros";
                    VarSQL = " select * from pais where idpais not in (select idpais from libro )";
                    break;
                case 1:
                    lblListar.Text = cmbListar.Text + ": " + "Autores con dos libros";
                    break ;
            }
            objBD.Listar(dgvBaseDatos,VarSQL);
        }
    }
}
