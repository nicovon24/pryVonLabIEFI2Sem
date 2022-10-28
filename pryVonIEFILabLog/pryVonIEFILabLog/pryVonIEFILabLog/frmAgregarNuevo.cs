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

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        //nudAnadir click event
        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            if (cbActividad.Text != "" && cbBarrio.Text != "" && cbProfesor.Text != "" && cbSexo.Text != "" && cbSucursal.Text != ""
            && txtDNI.Text != "" && txtEmail.Text != "" && txtNombre.Text != "" && txtTel.Text != "" && nudDeuda.Value != 0)
            {
                if (txtEmail.Text.Contains("@gmail.com") == true || txtEmail.Text.Contains("@outlook.com")==true
                || txtEmail.Text.Contains("@hotmail.com") == true)
                {


                    try
                    {
                        //getting the ids from these columns
                        int cod_barrio = frmMenu.functTransformStringToID("Barrios", "Cod_barrio", "Detalle", cbBarrio.Text);
                        int cod_sucursal = frmMenu.functTransformStringToID("Sucursales", "Cod_sucursal", "Detalle", cbSucursal.Text);
                        int cod_profesor = frmMenu.functTransformStringToID("Profesores", "Cod_profesor", "Nombre", cbProfesor.Text);
                        int cod_actividad = frmMenu.functTransformStringToID("Actividades", "Cod_actividad", "Detalle", cbActividad.Text);


                        //sqlSentence for the program
                        string sqlTables = "DNI, [Nombre y apellido], Sexo, ID_barrio, ID_sucursal, ID_profesor, ID_actividad, Teléfono, Email, Deuda";
                        string sqlCommand = " " + txtDNI.Text + ", " +
                        "' " + txtNombre.Text + "', " +
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
                        comando.CommandText = "INSERT INTO Clientes (" + sqlTables + ") VALUES(" + sqlCommand + ")";
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Dato cargado");
                        dbConnection.Close();
                    }

                    catch
                    {
                        MessageBox.Show("Error en el agregado de nuevos clientes");
                    }
                }
                else
                {
                    MessageBox.Show("Email input has to have a @gmail/hotmail/outlook.com extension");
                }
            }
            else
            {
                MessageBox.Show("Faltan datos para agregar, completelos para poder realizar el agregado");
            }
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
        }

        //in txtDNI and txtTel we want only numbers
        private void txtDNI_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
