using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pryVonIEFILabLog
{
    public partial class frmListaDatosClientes : Form
    {
        public frmMenu frmMenu = new frmMenu();

        public frmListaDatosClientes()
        {
            InitializeComponent();
            btnBorrar.Enabled = false;
            btnGenerar.Enabled = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
        }

        //==============================================================================================================
        //mostrar datos de tabla cliente en grilla
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                int totalClients = 0;
                grdClientes.Rows.Clear();

                OleDbConnection conexionDB;

                conexionDB = new OleDbConnection(frmMenu.urlDB);
                conexionDB.Open();

                OleDbCommand comando = new OleDbCommand();

                comando.Connection = conexionDB;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "SELECT * FROM Clientes ORDER BY Dni";
                OleDbDataReader reader = comando.ExecuteReader();

                //transformo los id_profesor, id_barrio en strings en la grilla
                while (reader.Read())
                {
                    string strBarrio = frmMenu.functTransformIDIntoString("Barrios", "Cod_barrio", "Detalle", int.Parse(reader["ID_barrio"].ToString()));
                    string strSucursal = frmMenu.functTransformIDIntoString("Sucursales", "Cod_sucursal", "Detalle", int.Parse(reader["ID_sucursal"].ToString()));
                    string strActividad = frmMenu.functTransformIDIntoString("Actividades", "Cod_actividad", "Detalle", int.Parse(reader["ID_actividad"].ToString()));

                    grdClientes.Rows.Add(reader["DNI"], reader["Nombre y apellido"], "$" + reader["Deuda"], strBarrio, strSucursal,
                     strActividad);

                    totalClients++;
                }

                reader.Close();
                conexionDB.Close();

                btnMostrar.Enabled = false;
                btnBorrar.Enabled = true;
                btnGenerar.Enabled = true;

                lblTotalClientesRes.Text = totalClients.ToString();

            }
            catch
            {
                MessageBox.Show("Error en la lista de los datos de los clientes");
            }
        }

        private void frmListaClientes_Load(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            grdClientes.Rows.Clear();
            btnMostrar.Enabled = true;
            btnBorrar.Enabled = false;
            btnGenerar.Enabled = false;
            lblTotalClientesRes.Text = "";
        }

        //==============================================================================================================
        //each time we presses this button, shows the print screen
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (grdClientes.Rows.Count > 0)
            {
                //prtVentana: window that appear when we click on btnPrint
                prtVentana.ShowDialog();

                //prtDocument: defines and styles the document we want to print
                prtDocument.PrinterSettings = new PrinterSettings(); //assingning printer to the document
                prtDocument.Print();
                MessageBox.Show("Document printed successfully!");
            }
        }

        private void prtDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (grdClientes.Rows.Count > 0)
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

                    comandoClientes.CommandText = "SELECT * FROM Clientes ORDER BY Dni";
                    OleDbDataReader readerClientes = comandoClientes.ExecuteReader();

                    Font font_title = new Font("Arial", 12, FontStyle.Underline); //font of the report
                    Font font_headers = new Font("Arial", 10, FontStyle.Bold); //font of the report
                    Font font_normal = new Font("Arial", 10); //font of the report
                    int y = 100; //eje y position, each time the reader renders a data, we increase the y value so
                                 //data will be always below in the docs

                    //headers of each report´s column
                    e.Graphics.DrawString("Clientes", font_title, Brushes.Black, 50, y - 35);
                    e.Graphics.DrawString("DNI", font_headers, Brushes.Black, 50, y - 15);
                    e.Graphics.DrawString("Nombre y apellido", font_headers, Brushes.Black, 120, y - 15);
                    e.Graphics.DrawString("Deuda", font_headers, Brushes.Black, 270, y - 15);
                    e.Graphics.DrawString("Sucursales", font_headers, Brushes.Black, 350, y - 15);
                    e.Graphics.DrawString("Actividades", font_headers, Brushes.Black, 450, y - 15);

                    //report table´s content
                    //we do not add barrios, bcs it is not so important
                    while (readerClientes.Read())
                    {

                        string strSucursal = frmMenu.functTransformIDIntoString("Sucursales", "Cod_sucursal", "Detalle", int.Parse(readerClientes["ID_sucursal"].ToString()));
                        string strActividad = frmMenu.functTransformIDIntoString("Actividades", "Cod_actividad", "Detalle", int.Parse(readerClientes["ID_actividad"].ToString()));
                        
                        //adding data: content, font, color, position in eje x, position in eje y
                        e.Graphics.DrawString(readerClientes["DNI"].ToString(), font_normal, Brushes.Black, 50, y);
                        e.Graphics.DrawString(readerClientes["Nombre y apellido"].ToString(), font_normal, Brushes.Black, 120, y);
                        e.Graphics.DrawString("$" + readerClientes["Deuda"].ToString(), font_normal, Brushes.Black, 270, y);
                        e.Graphics.DrawString(strSucursal, font_normal, Brushes.Black, 350, y);
                        e.Graphics.DrawString(strActividad, font_normal, Brushes.Black, 450, y);
                        y += 15;
                    }
                    readerClientes.Close();
                    conexionDB.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show("Error en la generación del reporte.");
                }
            }
        }
    }
}
