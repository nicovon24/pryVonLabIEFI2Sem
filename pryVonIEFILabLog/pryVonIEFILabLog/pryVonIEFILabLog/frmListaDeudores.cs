using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryVonIEFILabLog
{
    public partial class frmListaDeudores : Form
    {
        public frmMenu frmMenu = new frmMenu();
        public int totalDeuda = 0;
        public int counterClientes = 0;
        public int promedio = 0;
        public frmListaDeudores()
        {
            InitializeComponent();
            btnBorrar.Enabled = false;
            btnGenerar.Enabled = false;
        }

        private void frmListaDeudores_Load(object sender, EventArgs e)
        {
        }

        //==============================================================================================================
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                grdListaDeudores.Rows.Clear();

                int id = 0;

                OleDbConnection conexionDB;
                conexionDB = new OleDbConnection(frmMenu.urlDB);
                conexionDB.Open();

                OleDbCommand comando = new OleDbCommand();
                comando.Connection = conexionDB;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "SELECT * FROM Clientes WHERE Deuda>0 ORDER BY Dni";
                OleDbDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    string deudaCliente = reader["Deuda"].ToString();
                    int dniCliente = int.Parse(reader["DNI"].ToString());
                    string nombreCliente = reader["Nombre y apellido"].ToString();
                    grdListaDeudores.Rows.Add(dniCliente, nombreCliente, "$" + deudaCliente);
                    totalDeuda += int.Parse(deudaCliente);
                    counterClientes++;
                }

                reader.Close();
                conexionDB.Close();

                promedio = totalDeuda / counterClientes;

                lblTotalDeudaRes.Text = "$" + totalDeuda;
                lblCantClientesRes.Text = counterClientes + " clientes";
                lblPromDeudaRes.Text = "$" + promedio;

                btnBorrar.Enabled  = true;
                btnGenerar.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Error en el mostrado de los deudores");
            }
        }

        //==============================================================================================================
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            btnBorrar.Enabled = false;
            grdListaDeudores.Rows.Clear();
            lblCantClientesRes.Text = "";
            lblTotalDeudaRes.Text = "";
            lblPromDeudaRes.Text = "";
            btnGenerar.Enabled = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            //prtVentana: window that appear when we click on btnPrint
            prtVentana.ShowDialog();

            //prtDocument: defines and styles the document we want to print
            prtDocument.PrinterSettings = new PrinterSettings(); //assingning printer to the document
            prtDocument.Print();
            MessageBox.Show("Document printed successfully!");
        }

        private void prtDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                //seaching the activity id
                OleDbConnection conexionDB;
                conexionDB = new OleDbConnection(frmMenu.urlDB);
                conexionDB.Open();

                OleDbCommand comandoClientes = new OleDbCommand();
                comandoClientes.Connection = conexionDB;
                comandoClientes.CommandType = CommandType.TableDirect;

                comandoClientes.CommandText = "SELECT * FROM Clientes WHERE DEUDA>0 ORDER BY Dni";
                OleDbDataReader readerClientes = comandoClientes.ExecuteReader();

                Font font_title = new Font("Arial", 12, FontStyle.Underline); //font of the report
                Font font_headers = new Font("Arial", 10, FontStyle.Bold); //font of the report
                Font font_normal = new Font("Arial", 10); //font of the report
                Font font_final_msg = new Font("Arial", 12, FontStyle.Italic); //font of the report
                int y = 100; //eje y position, each time the reader renders a data, we increase the y value so
                             //data will be always below in the docs

                //headers of each report´s column
                e.Graphics.DrawString("Clientes", font_title, Brushes.Black, 50, y - 35);
                e.Graphics.DrawString("DNI", font_headers, Brushes.Black, 50, y - 15);
                e.Graphics.DrawString("Nombre y apellido", font_headers, Brushes.Black, 120, y - 15);
                e.Graphics.DrawString("Deuda", font_headers, Brushes.Black, 270, y - 15);

                //report table´s content
                //we do not add barrios, bcs it is not so important
                while (readerClientes.Read())
                {
                    //adding data: content, font, color, position in eje x, position in eje y
                    e.Graphics.DrawString(readerClientes["DNI"].ToString(), font_normal, Brushes.Black, 50, y);
                    e.Graphics.DrawString(readerClientes["Nombre y apellido"].ToString(), font_normal, Brushes.Black, 120, y);
                    e.Graphics.DrawString("$" + readerClientes["Deuda"].ToString(), font_normal, Brushes.Black, 270, y);
                    y += 15;
                }
                readerClientes.Close();
                conexionDB.Close();
                string msg = "Deuda de $" + totalDeuda + ". " + counterClientes + " deudores. " + "Deuda promedio de $" + promedio + ".";
                e.Graphics.DrawString(msg, font_normal, Brushes.Blue, 50, y+10);
            }
            catch (Exception err)
            {
                MessageBox.Show("Error en la generación del reporte.");
            }
        }
    }
}
