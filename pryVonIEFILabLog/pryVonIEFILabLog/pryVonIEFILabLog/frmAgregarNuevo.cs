using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pryVonIEFILabLog
{
    public partial class frmAgregarNuevo : Form
    {
        frmMenu frmMenu = new frmMenu();
        public frmAgregarNuevo()
        {
            InitializeComponent();
        }
        //--------
        //PROGRAM
        private void frmAgregarNuevo_Load(object sender, EventArgs e)
        {
            //defining values to the combo boxes depending to the access files values
            frmMenu.functChangeCbValue("Barrios", "Detalle", cbBarrio);
            frmMenu.functChangeCbValue("Actividades", "Detalle", cbActividad);
            frmMenu.functChangeCbValue("Profesores", "Nombre", cbProfesor);
            frmMenu.functChangeCbValue("Sucursales", "Detalle", cbSucursal);
        }

        //nudAnadir click event
        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {
            //VER, we only want numbers in txtDNI
            if (System.Text.RegularExpressions.Regex.IsMatch(txtDNI.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtDNI.Text = txtDNI.Text.Remove(txtDNI.Text.Length - 1);
            }
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            try
            {
                //getting the ids from these columns
                int cod_barrio = frmMenu.functTransformStringToID("Barrios", "Cod_barrio", "Detalle", cbBarrio.Text);
                int cod_sucursal = frmMenu.functTransformStringToID("Sucursales", "Cod_sucursal", "Detalle", cbSucursal.Text);
                int cod_profesor = frmMenu.functTransformStringToID("Profesores", "Cod_profesor", "Nombre", cbProfesor.Text);
                int cod_actividad = frmMenu.functTransformStringToID("Actividades", "Cod_actividad", "Detalle", cbActividad.Text);


                //sqlSentence for the program
                string sqlTables = "Cod_cliente, [Nombre y apellido], DNI, Edad, Sexo, ID_barrio, ID_sucursal, ID_profesor, ID_actividad, Teléfono, Email, Deuda";
                string sqlCommand = nudCodigo.Text + " , " +
                "' " + txtNombre.Text + "', " +
                " " + txtDNI.Text + ", " +
                "" + nudEdad.Text + ", " +
                "'" + cbSexo.Text + "', " +
                cod_barrio + ", " +
                cod_sucursal + ", " +
                cod_profesor + ", " +
                cod_actividad + ", " +
                "'" + txtTel.Text + "'," +
                "'" + txtEmail.Text + "'," +
                nudDeuda.Text;


                //data base connection and sending data to the access db
                OleDbConnection dbConnection = new OleDbConnection(frmMenu.urlDB);
                dbConnection.Open();
                OleDbCommand comando = new OleDbCommand();
                comando.Connection = dbConnection;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO CLIENTES (" + sqlTables + ") VALUES(" + sqlCommand + ")";
                comando.ExecuteNonQuery();
                MessageBox.Show("Dato cargado");
                dbConnection.Close();
            }

            catch
            {
                MessageBox.Show("Error en el añadido de datos");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
        }
    }
}
