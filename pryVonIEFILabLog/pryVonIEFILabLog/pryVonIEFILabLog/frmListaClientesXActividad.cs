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
            grdListaClientes.Rows.Clear();

            int id = 0;

            OleDbConnection conexionDB;
            conexionDB = new OleDbConnection(frmMenu.urlDB);
            conexionDB.Open();

            OleDbCommand comando = new OleDbCommand();
            comando.Connection = conexionDB;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "SELECT * FROM ACTIVIDADES";
            OleDbDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                if (reader["Detalle"].ToString()==cbActividad.Text)
                {
                    id = int.Parse(reader["Cod_actividad"].ToString());
                }
            }


            OleDbCommand comando2 = new OleDbCommand();
            comando2.Connection = conexionDB;
            comando2.CommandType = CommandType.TableDirect;
            comando2.CommandText = "SELECT * FROM CLIENTES";
            OleDbDataReader reader2 = comando2.ExecuteReader();

            while (reader.Read())
            {
                if (int.Parse(reader["ID_actividad"].ToString()) == id)
                {
                    grdListaClientes.Rows.Add(reader["DNI"], reader["Nombre y apellido"]);
                }
            }



            conexionDB.Close();

            btnBorrar.Enabled = true;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            btnBorrar.Enabled = false;
        }
    }
}
