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
    public partial class frmEliminarCliente : Form
    {
        public frmMenu frmMenu = new frmMenu();
        public frmEliminarCliente()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
        }

        private void bntEliminar_Click(object sender, EventArgs e)
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
                    using (System.Data.OleDb.OleDbCommand commandDelete = new System.Data.OleDb.OleDbCommand(
                        "DELETE FROM Clientes WHERE DNI=@codigoCliente", conexionDB))
                    {
                        commandDelete.Parameters.Add(new System.Data.OleDb.OleDbParameter("@cliente", codigoCliente));
                        commandDelete.ExecuteNonQuery();
                    }

                    conexionDB.Close();
                    MessageBox.Show(" Cliente eliminado");
                    txtDNI.Text = "";
                }
                else
                {
                    MessageBox.Show("La persona no se encuentra en la base de datos");
                }
            }
            catch
            {
                MessageBox.Show("Error en el eliminado de cliente");
            }
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
