using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pryVonIEFILabLog
{
    public partial class frmActualizar : Form
    {
        public frmMenu frmMenu = new frmMenu();
        public int idBarrio = 1, idActividad = 1, idProfesor = 1, idSucursal = 1;
        public int deuda = 0;

        public frmActualizar(bool deudaIsChecked, bool barrioIsChecked, bool actividadIsChecked, bool sucursalIsChecked, bool profesorIsChecked)
        {
            InitializeComponent();
            //defining values to the combo boxes depending to the access files values
            frmMenu.functChangeCbValue("Barrios", "Detalle", cbBarrio);
            frmMenu.functChangeCbValue("Actividades", "Detalle", cbActividad);
            frmMenu.functChangeCbValue("Profesores", "Nombre", cbProfesor);
            frmMenu.functChangeCbValue("Sucursales", "Detalle", cbSucursal);

            //enabling the combo boxed depending on the marked checkboxes in update main
            //can not change the colors when they are disabled...
            if (deudaIsChecked == true)
            {
                txtDeuda.Enabled = true;
            }

            if (barrioIsChecked == true)
            {
                cbBarrio.Enabled = true;
            }


            if (actividadIsChecked == true)
            {
                cbActividad.Enabled = true;
            }
            if (sucursalIsChecked == true)
            {
                cbSucursal.Enabled = true;
            }


            if (profesorIsChecked == true)
            {
                cbProfesor.Enabled = true;
            }
        }

        private void txtDeuda_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int codigoCliente = int.Parse(txtDNI.Text);
            bool flagDniIsInDB = false;

            OleDbConnection conexionDB;
            conexionDB = new OleDbConnection(frmMenu.urlDB);
            conexionDB.Open();

            //checking if the person is in the db, if he is we can update his data
            OleDbCommand commandFlag = new OleDbCommand();
            commandFlag.Connection = conexionDB;
            commandFlag.CommandType = CommandType.TableDirect;
            commandFlag.CommandText = "SELECT * FROM Clientes";
            OleDbDataReader readerClientes = commandFlag.ExecuteReader();
            while (readerClientes.Read())
            {
                //we have found the guy
                if (int.Parse(readerClientes["DNI"].ToString()) == codigoCliente)
                {
                    //if the cb is enabled, we update the value, otherwise the client does not want to update it and we keep the previous value 
                    flagDniIsInDB = true;
                    if (cbBarrio.Enabled == true) //if the cb is enabled..
                    {
                        idBarrio = frmMenu.functTransformStringToID("Barrios", "Cod_barrio", "Detalle", cbBarrio.Text); //getting the new value
                    }
                    else
                    {
                        idBarrio = int.Parse(readerClientes["ID_barrio"].ToString()); //otherwise, the value is the same
                    }


                    if (cbActividad.Enabled == true) //if the cb is enabled..
                    {
                        idActividad = frmMenu.functTransformStringToID("Actividades", "Cod_actividad", "Detalle", cbActividad.Text);
                    }
                    else
                    {
                        idActividad = int.Parse(readerClientes["ID_actividad"].ToString());
                    }


                    if (cbSucursal.Enabled == true) //if the cb is enabled..
                    {
                        idSucursal = frmMenu.functTransformStringToID("Sucursales", "Cod_sucursal", "Detalle", cbSucursal.Text);
                    }
                    else
                    {
                        idSucursal = int.Parse(readerClientes["ID_sucursal"].ToString());
                    }


                    if (cbProfesor.Enabled == true) //if the cb is enabled..
                    {
                        idProfesor = frmMenu.functTransformStringToID("Profesores", "Cod_profesor", "Nombre", cbProfesor.Text);
                    }
                    else
                    {
                        idProfesor = int.Parse(readerClientes["ID_profesor"].ToString());
                    }

                    if (txtDeuda.Text != "")
                    {
                        deuda = int.Parse(txtDeuda.Text); //si no está habilitado el txtDeuda, dejamos el valor tal cual estaba
                    }
                    else
                    {
                        deuda = int.Parse(readerClientes["DNI"].ToString());
                    }
                }
            }
            readerClientes.Close();

            //only if he/she is in the db, we can update his debt
            if (flagDniIsInDB == true)
            {
                //I found this in internet, bcs i couldn't make it work out the other way
                //defines the query, the conection and the parameters in the command
                //HACER LA CARGA DE LOS PARAMETROS EN ORDEN, NO LOS LEE SINO
                using (System.Data.OleDb.OleDbCommand commandUpdate = new System.Data.OleDb.OleDbCommand(
                    "UPDATE Clientes SET [Deuda]=@deuda,[ID_barrio]=@barrio, [ID_actividad]=@actividad, [ID_sucursal]=@sucursal, [ID_profesor]=@profesor" +
                    " WHERE DNI=@dni", conexionDB))
                {
                    commandUpdate.Parameters.Add(new System.Data.OleDb.OleDbParameter("@deuda", deuda));
                    commandUpdate.Parameters.Add(new System.Data.OleDb.OleDbParameter("@barrio", idBarrio));
                    commandUpdate.Parameters.Add(new System.Data.OleDb.OleDbParameter("@actividad", idActividad));
                    commandUpdate.Parameters.Add(new System.Data.OleDb.OleDbParameter("@sucursal", idSucursal));
                    commandUpdate.Parameters.Add(new System.Data.OleDb.OleDbParameter("@profesor", idProfesor));
                    commandUpdate.Parameters.Add(new System.Data.OleDb.OleDbParameter("@dni", codigoCliente));
                    commandUpdate.ExecuteNonQuery();
                }
                conexionDB.Close();


                txtDNI.Text = "";
                txtDeuda.Text = "";
                cbActividad.Text = "";
                cbBarrio.Text = "";
                cbProfesor.Text = "";
                cbSucursal.Text = "";
                txtDNI.Focus();
                MessageBox.Show("Dato actualizado");
            }
            else
            {
                MessageBox.Show("La persona no se encuentra en la base de datos");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmActualizarMain frmMenu = new frmActualizarMain();
            frmMenu.Show();
        }

        private void lblDeuda_Click(object sender, EventArgs e)
        {

        }

        private void lblMSG_Click(object sender, EventArgs e)
        {

        }

        private void txtDeuda_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDNI_Click(object sender, EventArgs e)
        {

        }

        private void frmActualizar_Load(object sender, EventArgs e)
        {

        }
    }
}
