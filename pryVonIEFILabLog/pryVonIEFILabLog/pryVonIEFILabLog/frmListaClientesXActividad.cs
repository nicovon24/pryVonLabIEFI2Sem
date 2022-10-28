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
    public partial class frmListaActividad : Form
    {
        public frmMenu frmMenu = new frmMenu();
        public frmListaActividad()
        {
            InitializeComponent();
            btnBorrar.Enabled = false;
        }

        private void frmListaClientesCiudad_Load(object sender, EventArgs e)
        {
            frmMenu.functChangeCbValue("Actividades", "Detalle", cbActividad);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                //getting the id from actividad, bcs we want to search it then in clientes so we get the values dni and name
                grdListaClientes.Rows.Clear();

                int id = 0;

                OleDbConnection conexionDB;
                conexionDB = new OleDbConnection(frmMenu.urlDB);
                conexionDB.Open();

                OleDbCommand comandoActividades = new OleDbCommand();
                comandoActividades.Connection = conexionDB;
                comandoActividades.CommandType = CommandType.TableDirect;
                comandoActividades.CommandText = "SELECT * FROM ACTIVIDADES WHERE Detalle='" + cbActividad.Text + "'";
                OleDbDataReader readerActividades = comandoActividades.ExecuteReader();

                while (readerActividades.Read())
                {
                    id = int.Parse(readerActividades["Cod_actividad"].ToString());
                }

                //getting the data from the id actividad
                OleDbCommand comandoClientes = new OleDbCommand();
                comandoClientes.Connection = conexionDB;
                comandoClientes.CommandType = CommandType.TableDirect;
                comandoClientes.CommandText = "SELECT * FROM Clientes WHERE ID_actividad=" + id;
                OleDbDataReader readerClientes = comandoClientes.ExecuteReader();

                //getting the clients which practice that activity
                while (readerClientes.Read())
                {
                    grdListaClientes.Rows.Add(readerClientes["DNI"], readerClientes["Nombre y apellido"]);
                }

                readerClientes.Close();
                conexionDB.Close();

                btnBorrar.Enabled = true;
            }

            catch
            {
                MessageBox.Show("Error en la muestra de las actividades en la grilla");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            grdListaClientes.Rows.Clear();
            btnBorrar.Enabled = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
        }
    }
}
