using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;
using System.Collections;

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
                command.CommandText = "SELECT * FROM " + table + " ORDER BY " + column;

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBox.Items.Add(reader[column].ToString());
                }
                conexionDB.Close();
                reader.Close();
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
                conexionDB.Close();
                reader.Close();
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
                reader.Close();
            }
            catch
            {
                MessageBox.Show("Error en la función functTransformIdIntoString!");
            }

            return detalleResultado; //we return the id and store it in new variables
        }

        public void functGetStrategicData(string table, string title, string query, string col_id, string col_cod, string col_detalle, DataGridView grd)
        {
            OleDbConnection conexionDB;
            conexionDB = new OleDbConnection(urlDB);
            conexionDB.Open();

            OleDbCommand comandoClientes = new OleDbCommand();
            comandoClientes.Connection = conexionDB;
            comandoClientes.CommandType = CommandType.TableDirect;

            grd.Columns[0].HeaderText = title; //changing the header from the first column
            grd.Columns[1].HeaderText = "Número de clientes"; //changing the header from the first column

            comandoClientes.CommandText = query;
            OleDbDataReader readerClientes = comandoClientes.ExecuteReader();
            while (readerClientes.Read())
            {
                string dataColCero = "";
                OleDbCommand comandoBarrios = new OleDbCommand();
                comandoBarrios.Connection = conexionDB;
                comandoBarrios.CommandType = CommandType.TableDirect;
                comandoBarrios.CommandText = "SELECT * FROM " + table;

                OleDbDataReader reader = comandoBarrios.ExecuteReader();

                while (reader.Read())
                {

                    if (int.Parse(reader[col_cod].ToString()) == int.Parse(readerClientes[col_id].ToString()))
                    {
                        dataColCero = reader[col_detalle].ToString();
                    }

                }

                grd.Rows.Add(dataColCero, readerClientes[1]); //name of sucursal, counter
            }
            readerClientes.Close();
            conexionDB.Close();
        }

        public void Imprimir(PrintPageEventArgs reporte, string table, string col_1, string col_2, string col_3, string cb)
        {
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
            this.Hide();
            frmListaDeudores frmNew = new frmListaDeudores();
            frmNew.Show();
        }

        private void listadoDeClientesEnxActividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmListaActividad frmNew = new frmListaActividad();
            frmNew.Show();
        }

        private void agregarNuevosClientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmAgregarNuevo frmNew = new frmAgregarNuevo();
            frmNew.Show();
        }

        private void consultaDeDatosEstratégicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConsultaDatosEstrategicos frmNew = new frmConsultaDatosEstrategicos();
            frmNew.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("See you!");
        }

        private void buscarSaldoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBuscarSaldoCliente frmNew = new frmBuscarSaldoCliente();
            frmNew.Show();
        }

        private void actualizarDeudaDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmActualizarDeuda frmNew = new frmActualizarDeuda();
            frmNew.Show();
        }

        private void eliminarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEliminarCliente frmNew = new frmEliminarCliente();
            frmNew.Show();
        }
    }
}
