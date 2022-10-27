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
    public partial class frmListaDeudores : Form
    {
        public frmMenu frmMenu = new frmMenu();
        public int totalDeuda = 0;
        public int counterClientes = 0;
        public frmListaDeudores()
        {
            InitializeComponent();
            btnBorrar.Enabled = false;
        }

        private void frmListaDeudores_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            grdListaDeudores.Rows.Clear();
            totalDeuda = 0;
            counterClientes = 0;

            int id = 0;

            OleDbConnection conexionDB;
            conexionDB = new OleDbConnection(frmMenu.urlDB);
            conexionDB.Open();

            OleDbCommand comando = new OleDbCommand();
            comando.Connection = conexionDB;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "SELECT * FROM CLIENTES";
            OleDbDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                string deudaCliente = reader["Deuda"].ToString();
                int dniCliente = int.Parse(reader["DNI"].ToString());
                string nombreCliente = reader["Nombre y apellido"].ToString();
                if (int.Parse(deudaCliente) > 0){
                    grdListaDeudores.Rows.Add(dniCliente, nombreCliente, "$" + deudaCliente);
                    totalDeuda += int.Parse(deudaCliente);
                    counterClientes++;
                }
            }

            reader.Close();
            conexionDB.Close();

            int promedio = totalDeuda / counterClientes;

            lblTotalDeudaRes.Text = "$" + totalDeuda;
            lblCantClientesRes.Text = counterClientes + " clientes";
            lblPromDeudaRes.Text = "$" + promedio;


            btnBorrar.Enabled = true;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            btnBorrar.Enabled = false;
            grdListaDeudores.Rows.Clear();
            lblCantClientesRes.Text = "";
            lblTotalDeudaRes.Text = "";
            lblPromDeudaRes.Text = "";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
        }
    }
}
