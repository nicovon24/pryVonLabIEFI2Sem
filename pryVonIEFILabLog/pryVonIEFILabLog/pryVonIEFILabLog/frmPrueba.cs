using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace pryVonIEFILabLog
{
    public partial class frmPrueba : Form
    {
        public frmPrueba()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            OleDbConnection conexionDB;
            string cadenaOLEDB = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=BD_Clientes.accdb";

            conexionDB = new OleDbConnection(cadenaOLEDB);
            conexionDB.Open();

            OleDbCommand bringFromDB = new OleDbCommand();

            bringFromDB.Connection = conexionDB;
            bringFromDB.CommandType = CommandType.TableDirect;
            bringFromDB.CommandText = "SELECT * FROM Clientes";

            Console.WriteLine(bringFromDB);

            conexionDB.Close();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
