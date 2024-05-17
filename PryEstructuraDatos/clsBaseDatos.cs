using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PryEstructuraDatos
{
    internal class clsBaseDatos
    {
        OleDbConnection conexion = new OleDbConnection();
        OleDbCommand comando = new OleDbCommand();
        OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private string varCadenaConexion2 = "Provider=Microsoft.JET.OLEBD.4.0;DataSource=Libreria.accdb";
        private string varCadenaConexion1 = "Provider=Microsoft.ACE.OLEBD.12.0;DataSource=Libreria.accdb";

        public void Listar(DataGridView Grillita)
        {
            try
            {
                conexion.ConnectionString = varCadenaConexion1;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "LIBRO";

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, "libro");

                Grillita.DataSource = null;
                Grillita.DataSource = DS.Tables["libro"];

                conexion.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Listar(DataGridView Grillita, String ConsultaSQL)
        {
            try
            {
                conexion.ConnectionString = varCadenaConexion1;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = ConsultaSQL;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, "Tabla");

                Grillita.DataSource = null;
                Grillita.DataSource = DS.Tables["Tabla"];

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
