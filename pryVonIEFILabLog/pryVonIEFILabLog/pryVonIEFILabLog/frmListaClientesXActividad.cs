using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Policy;
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
            if (cbActividad.Text!="")
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
            else
            {
                MessageBox.Show("Eliga alguna opción en el combo box, por favor");
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

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void prtDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            //showing only the clients from the activity
            if (cbActividad.Text != "")
            {
                try
                {
                    //seaching the activity id
                    int actividadID = 0;

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
                        actividadID = int.Parse(readerActividades["Cod_actividad"].ToString());
                    }

                    readerActividades.Close();

                    conexionDB = new OleDbConnection(frmMenu.urlDB);
                    conexionDB.Open();

                    OleDbCommand comandoClientes = new OleDbCommand();
                    comandoClientes.Connection = conexionDB;
                    comandoClientes.CommandType = CommandType.TableDirect;

                    comandoClientes.CommandText = "Clientes";
                    OleDbDataReader readerClientes = comandoClientes.ExecuteReader();

                    Font font_title = new Font("Arial", 12, FontStyle.Underline); //font of the report
                    Font font_headers = new Font("Arial", 10, FontStyle.Bold); //font of the report
                    Font font_normal = new Font("Arial", 10); //font of the report
                    int y = 100; //eje y position, each time the reader renders a data, we increase the y value so
                                 //data will be always below in the docs

                    //headers of each report´s column
                    e.Graphics.DrawString("Alumnos de " + cbActividad.Text, font_title, Brushes.Black, 50, y - 35);

                    e.Graphics.DrawString("DNI", font_headers, Brushes.Black, 50, y - 15);
                    e.Graphics.DrawString("Nombre y apellido", font_headers, Brushes.Black, 150, y - 15);

                    //report table´s content
                    while (readerClientes.Read())
                    {
                        if (int.Parse(readerClientes["ID_actividad"].ToString()) == actividadID)
                        {
                            e.Graphics.DrawString(readerClientes["DNI"].ToString(), font_normal, Brushes.Black, 50, y);
                            e.Graphics.DrawString(readerClientes["Nombre y apellido"].ToString(), font_normal, Brushes.Black, 150, y);
                            y += 15;
                        }
                    }
                    readerClientes.Close();
                    conexionDB.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                }
            }
            else
            {
                MessageBox.Show("Choose an option, please");
            }
        }

        //each time we presses this button, shows the print screen
        private void btnGenerar_Click(object sender, EventArgs e)
        {

            if (cbActividad.Text != "")
            {
                //prtVentana: window that appear when we click on btnPrint
                prtVentana.ShowDialog();

                //prtDocument: defines and styles the document we want to print
                prtDocument.PrinterSettings = new PrinterSettings(); //assingning printer to the document
                prtDocument.Print();
                MessageBox.Show("Document printed successfully!");
            }
            else
            {
                MessageBox.Show("Choose an option, please");
            }
        }
    }
}
