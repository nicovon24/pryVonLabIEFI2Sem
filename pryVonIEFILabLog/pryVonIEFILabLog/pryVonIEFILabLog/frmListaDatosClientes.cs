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
        public int totalDeuda = 0;
        public int counterClientes = 0;

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
                totalDeuda = 0;
                counterClientes = 0;
                grdClientes.Rows.Clear();

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
                    string strCiudad = frmMenu.functTransformIDIntoString("Ciudades", "Cod_ciudad", "Detalle", int.Parse(reader["ID_ciudad"].ToString()));
                    string strBarrio = frmMenu.functTransformIDIntoString("Barrios", "Cod_barrio", "Detalle", int.Parse(reader["ID_barrio"].ToString()));
                    string strSucursal = frmMenu.functTransformIDIntoString("Sucursales", "Cod_sucursal", "Detalle", int.Parse(reader["ID_sucursal"].ToString()));
                    string strProfesor = frmMenu.functTransformIDIntoString("Profesores", "Cod_profesor", "Nombre", int.Parse(reader["ID_profesor"].ToString()));
                    string strActividad = frmMenu.functTransformIDIntoString("Actividades", "Cod_actividad", "Detalle", int.Parse(reader["ID_actividad"].ToString()));

                    grdClientes.Rows.Add(reader["DNI"], reader["Nombre y apellido"], "$" + reader["Deuda"], reader["Sexo"], strCiudad, strBarrio, strSucursal,
                    strProfesor, strActividad, reader["Teléfono"], reader["Email"]);

                    totalDeuda += int.Parse(reader["Deuda"].ToString());
                    counterClientes++;
                }

                conexionDB.Close();

                int promedio = totalDeuda / counterClientes;

                lblTotalDeudaRes.Text = "$" + totalDeuda;
                lblCantClientesRes.Text = counterClientes + " clientes";
                lblPromDeudaRes.Text = "$" + promedio;
                btnMostrar.Enabled = false;
                btnBorrar.Enabled = true;

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
            lblCantClientesRes.Text = "";
            lblTotalDeudaRes.Text = "";
            lblPromDeudaRes.Text = "";
        }
    }
}
