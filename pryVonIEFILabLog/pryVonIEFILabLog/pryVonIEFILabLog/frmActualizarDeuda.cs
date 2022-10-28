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
    public partial class frmActualizarDeuda : Form
    {
        public frmMenu frmMenu = new frmMenu();

        public frmActualizarDeuda()
        {
            InitializeComponent();
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
            try
            {
                int codigoCliente = int.Parse(txtDNI.Text);
                bool flagDniIsInDB = false;

                OleDbConnection conexionDB;
                conexionDB = new OleDbConnection(frmMenu.urlDB);
                conexionDB.Open();

                //checking if the person is in the db, if he is we can update his debt
                OleDbCommand commandFlag = new OleDbCommand();
                commandFlag.Connection = conexionDB;
                commandFlag.CommandType = CommandType.TableDirect;
                commandFlag.CommandText = "SELECT * FROM Clientes";
                OleDbDataReader reader = commandFlag.ExecuteReader();
                while (reader.Read())
                {
                    if (int.Parse(reader["DNI"].ToString()) == codigoCliente)
                    {
                        Console.WriteLine("La persona está en la base de datos, podemos seguir con el programa"); 
                        flagDniIsInDB = true;
                    }
                }

                //only if he/she is in the db, we can update his debt
                if (flagDniIsInDB == true)
                {
                    //I found this in internet, bcs i couldn't make it work out the other way
                    //defines the query, the conection and the parameters in the command, 
                    using (System.Data.OleDb.OleDbCommand commandUpdate = new System.Data.OleDb.OleDbCommand(
                        "UPDATE Clientes SET Deuda=@deuda WHERE DNI=@cliente", conexionDB))
                    {
                        commandUpdate.Parameters.Add(new System.Data.OleDb.OleDbParameter("@deuda", txtDeuda.Text));
                        commandUpdate.Parameters.Add(new System.Data.OleDb.OleDbParameter("@cliente", codigoCliente));
                        commandUpdate.ExecuteNonQuery();
                    }

                    conexionDB.Close();
                    MessageBox.Show("Dato actualizado");
                }
                else
                {
                    MessageBox.Show("La persona no se encuentra en la base de datos");
                }
            }
            catch(Exception err)
            {
                MessageBox.Show("Error: " + err);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu frmMenu = new frmMenu();
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
    }
}
