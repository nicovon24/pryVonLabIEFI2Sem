using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pryVonIEFILabLog
{
    public partial class frmListaDatosClientes : Form
    {
        public frmMenu frmMenu = new frmMenu();

        public frmListaDatosClientes()
        {
            InitializeComponent();
            btnBorrar.Enabled = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
        }

        //mostrar datos de tabla cliente en grilla
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                int totalClients = 0;
                grdClientes.Rows.Clear();

                OleDbConnection conexionDB;

                conexionDB = new OleDbConnection(frmMenu.urlDB);
                conexionDB.Open();

                OleDbCommand comando = new OleDbCommand();

                comando.Connection = conexionDB;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "SELECT * FROM Clientes ORDER BY Dni";
                OleDbDataReader reader = comando.ExecuteReader();

                //transformo los id_profesor, id_barrio en strings en la grilla
                while (reader.Read())
                {
                    string strBarrio = frmMenu.functTransformIDIntoString("Barrios", "Cod_barrio", "Detalle", int.Parse(reader["ID_barrio"].ToString()));
                    string strSucursal = frmMenu.functTransformIDIntoString("Sucursales", "Cod_sucursal", "Detalle", int.Parse(reader["ID_sucursal"].ToString()));
                    string strActividad = frmMenu.functTransformIDIntoString("Actividades", "Cod_actividad", "Detalle", int.Parse(reader["ID_actividad"].ToString()));

                    grdClientes.Rows.Add(reader["DNI"], reader["Nombre y apellido"], "$" + reader["Deuda"], strBarrio, strSucursal,
                     strActividad);

                    totalClients++;
                }

                reader.Close();
                conexionDB.Close();

                btnMostrar.Enabled = false;
                btnBorrar.Enabled = true;

                lblTotalClientesRes.Text = totalClients.ToString();

            }
            catch
            {
                MessageBox.Show("Error en la lista de los datos de los clientes");
            }
        }

        private void frmListaClientes_Load(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            grdClientes.Rows.Clear();
            btnMostrar.Enabled = true;
            btnBorrar.Enabled = false;
            lblTotalClientesRes.Text = "";
        }
    }
}
