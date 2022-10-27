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
    public partial class frmListaClientes : Form
    {
        public frmMenu frmMenu = new frmMenu();
        public frmListaClientes()
        {
            InitializeComponent();
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
                string strBarrio = frmMenu.functTransformIDIntoString("Barrios", "Cod_barrio", "Detalle", int.Parse(reader["ID_barrio"].ToString()));
                string strSucursal= frmMenu.functTransformIDIntoString("Sucursales", "Cod_sucursal", "Detalle", int.Parse(reader["ID_sucursal"].ToString()));
                string strProfesor = frmMenu.functTransformIDIntoString("Profesores", "Cod_profesor", "Nombre", int.Parse(reader["ID_profesor"].ToString()));
                string strActividad = frmMenu.functTransformIDIntoString("Actividades", "Cod_actividad", "Detalle", int.Parse(reader["ID_actividad"].ToString()));

                grdClientes.Rows.Add(reader["Cod_cliente"], reader["Nombre y apellido"], reader["DNI"], 
                reader["Edad"], reader["Sexo"], reader["Deuda"],  strBarrio, strSucursal,
                strProfesor, strActividad, reader["Teléfono"], reader["Email"]);
            }
        }

        private void frmListaClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
