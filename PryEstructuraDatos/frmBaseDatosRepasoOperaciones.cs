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
                    lblListar.Text = cmbListar.Text + ": " + "Libros donde el idpais sea menor a 3";
                    VarSQL = " SELECT *  FROM libro WHERE idpais IN (SELECT DISTINCT  idpais FROM libro WHERE idpais < 3)";
                    break ;
                case 2:
                    lblListar.Text = cmbListar.Text + ": " + "Tabla de libro e Idioma";
                    VarSQL = "SELECT * " + "FROM Libro, Idioma " + "WHERE Libro.IdIdioma = Idioma.IdIdioma";
                    break ;
                case 3:
                    lblListar.Text = cmbListar.Text + ": " + "Libros cuyo IdAutor sea 18.";
                    VarSQL = "SELECT * " + "FROM Libro " + "WHERE IdAutor = 18";
                    break;
                case 4:
                    lblListar.Text = cmbListar.Text + ": Libros publicados con ID mayor a 5 y con cantidad mayor a 10 ";
                    VarSQL = "SELECT * FROM libro WHERE idlibro> 5 AND cantidad > 10 ";
                    break;
                case 5:
                    lblListar.Text = cmbListar.Text + ": " + "Libros cuyo precio sea mayor a 600.";
                    VarSQL = "SELECT * " + "FROM Libro " + "WHERE Precio " + "IN " + "(SELECT DISTINCT Precio " + "FROM Libro " + "WHERE Precio > 600)";
                    break;
                case 6:
                    lblListar.Text = cmbListar.Text + ": Libros ordenados por año ";
                    VarSQL = "SELECT * FROM libro ORDER BY año DESC";
                    break;
                case 7:
                    lblListar.Text = cmbListar.Text + ": Títulos de los libros ";
                    VarSQL = "SELECT titulo FROM libro";
                    break;
                case 8:
                    lblListar.Text = cmbListar.Text + ": " + "Paises que tienen libros.";
                    VarSQL = "SELECT * FROM Pais WHERE " + "IdPais IN (SELECT IdPais FROM Libro)";
                    break;
                case 9:
                    lblListar.Text = cmbListar.Text + ": " + "Tabla libro e idioma juntas.";
                    VarSQL = "SELECT * " + "FROM Libro, Idioma " + "WHERE Libro.IdIdioma = Idioma.IdIdioma";
                    break;
                case 10:
                    lblListar.Text = cmbListar.Text + ": Autores sin libros ";
                    VarSQL = "SELECT * FROM autor WHERE idautor NOT IN (SELECT idautor FROM libro)";
                    break;
                case 11:
                    lblListar.Text = cmbListar.Text + ": " + "Autores que hayan escrito algún libro del stock.";
                    VarSQL = "SELECT * " + "FROM Autor " + "WHERE IdAutor " + "IN (SELECT IdAutor FROM Libro)";
                    break;
                case 12:
                    lblListar.Text = cmbListar.Text + ": Países e Idiomas";
                    VarSQL = " SELECT * FROM pais UNION SELECT * FROM idioma";
                    break;
                case 13:
                    lblListar.Text = cmbListar.Text + ": " + "Libros cuyo IdIdioma sea 1.";
                    VarSQL = "SELECT * " + "FROM Libro " + "WHERE IdIdioma = 1";
                    break;
                case 14:
                    lblListar.Text = cmbListar.Text + ": Libros publicados antes del año 2000 y con precio mayor a 30 ";
                    VarSQL = "SELECT * FROM libro WHERE año < '2000' AND precio > 50";
                    break;
                case 15:
                    lblListar.Text = cmbListar.Text + ": Libros publicados antes del año 2000 o con precio mayor a 30";
                    VarSQL = "SELECT * FROM (SELECT * FROM libro WHERE año < '2000') WHERE precio > 30";
                    break;
                case 16:
                    lblListar.Text = cmbListar.Text + ": Libros ordenados por precio ascendente";
                    VarSQL = "SELECT* FROM libro ORDER BY precio ASC";
                    break;
                case 17:
                    lblListar.Text = cmbListar.Text + ": " + "Paises.";
                    VarSQL = "SELECT Nombre AS Paises " + "FROM Pais " + "ORDER BY 1 DESC";
                    break ;
                case 18:
                    lblListar.Text = cmbListar.Text + ": Nombres e IDs de los autores ";
                    VarSQL = "SELECT nombre, idautor FROM autor";
                    break;
                case 19:
                    lblListar.Text = cmbListar.Text + ": Libros y sus autores";
                    VarSQL = "SELECT libro.titulo, autor.nombre AS autor  FROM libro, autor WHERE libro.idautor = autor.idautor";
                    break;
                default:
                    lblListar.Text = "Seleccione alguna de las opciones disponibles y vuelva a intentarlo.";
                    MessageBox.Show("Seleccione alguna de las opciones disponibles y vuelva a intentarlo.");

                    break;

            }
            objBD.Listar(dgvBaseDatos,VarSQL);
        }
    }
}
