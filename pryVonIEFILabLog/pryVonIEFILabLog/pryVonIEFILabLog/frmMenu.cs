using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryVonIEFILabLog
{
    public partial class frmMenu : Form
    {
        //--------
        //public url
        public string urlDB = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=BD_Clientes.accdb";

        //--------
        //funciones

        //function for frmAgregarNuevo
        //we use it to change the values from the combo boxes linking them with the respective tables
        public void functChangeCbValue(string table, string column, System.Windows.Forms.ComboBox comboBox)
        {
            try
            {
                OleDbConnection conexionDB;

                conexionDB = new OleDbConnection(urlDB);
                conexionDB.Open();

                OleDbCommand command = new OleDbCommand();

                command.Connection = conexionDB;
                command.CommandType = CommandType.TableDirect;
                command.CommandText = "SELECT * FROM " + table;

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBox.Items.Add(reader[column].ToString());
                }
            }
            catch
            {
                MessageBox.Show("Error en la function functChangeCbValue!");
            }
        }

        //function for frmAgregarNuevo
        //function we use it int order to transform the profesor, sucursal, barrio, etc combo
        //boxes into id bcs we want to add the codes to the db
        public int functTransformStringToID(string table, string column_id, string column_detalle, string input)
        {
            int id = 0;

            try
            {
                OleDbConnection conexionDB;

                conexionDB = new OleDbConnection(urlDB);
                conexionDB.Open();

                OleDbCommand command = new OleDbCommand();

                command.Connection = conexionDB;
                command.CommandType = CommandType.TableDirect;
                command.CommandText = "SELECT * FROM " + table;

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader[column_detalle].ToString() == input)
                    {
                        id = int.Parse(reader[column_id].ToString());
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error en la función functGetNumOfID!");
            }

            return id; //we return the id and store it in new variables
        }

        //function for frmListaClientes
        //we use it int order to transform the profesor, sucursal, barrio, etc IDs
        //into strings bcs we want to add them to the grid table
        public string functTransformIDIntoString(string table, string column_id, string column_detalle, int inputID)
        {
            string detalleResultado = "";

            try { 
                OleDbConnection conexionDB;

                conexionDB = new OleDbConnection(urlDB);
                conexionDB.Open();

                OleDbCommand command = new OleDbCommand();

                command.Connection = conexionDB;
                command.CommandType = CommandType.TableDirect;
                command.CommandText = "SELECT * FROM " + table;

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (int.Parse(reader[column_id].ToString()) == inputID)
                    {
                        detalleResultado = reader[column_detalle].ToString();
                    }
                }

                conexionDB.Close();
            }
            catch
            {
                MessageBox.Show("Error en la función functTransformIdIntoString!");
            }

            return detalleResultado; //we return the id and store it in new variables
        }

        public frmMenu()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void agregarNuevosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAgregarNuevo frmNew = new frmAgregarNuevo();
            frmNew.Show();
        }

        private void listadoDeTodosLosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void listadoDeTodosLosClientesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            frmListaDatosClientes frmNew = new frmListaDatosClientes();
            frmNew.Show();
        }

        private void listadoDeClientesDeudoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void listadoDeClientesDeUnaCiudadToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void listadoDeClientesEnxActividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmListaActividad frmNew = new frmListaActividad();
            frmNew.Show();
        }
    }
}
