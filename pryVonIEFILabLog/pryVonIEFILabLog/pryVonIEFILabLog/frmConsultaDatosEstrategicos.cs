using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace pryVonIEFILabLog
{
    public partial class frmConsultaDatosEstrategicos : Form
    {
        public frmMenu frmMenu = new frmMenu();
        public frmConsultaDatosEstrategicos()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            grdData.Rows.Clear();

            try
            {
                string cbOption = cbInput.Text;

                OleDbConnection conexionDB;
                conexionDB = new OleDbConnection(frmMenu.urlDB);
                conexionDB.Open();

                OleDbCommand comandoClientes = new OleDbCommand();
                comandoClientes.Connection = conexionDB;
                comandoClientes.CommandType = CommandType.TableDirect;

                //codigo monotono, no pude hacerlo en función
                //basicamente segun el campo elegido en el combo box cuenta los valores de cada campo y los muestra en grilla
                switch (cbOption)
                {
                    case "Barrio":
                        grdData.Columns[0].HeaderText = "Barrio"; //changing the header from the first column
                        grdData.Columns[1].HeaderText = "Número de clientes"; //changing the header from the first column

                        comandoClientes.CommandText = "SELECT ID_barrio, Count(ID_barrio) FROM CLIENTES " + //ordering the barrios depending on the counting
                            "GROUP BY ID_barrio ORDER BY Count(ID_barrio) DESC";
                        OleDbDataReader readerClientes = comandoClientes.ExecuteReader();
                        while (readerClientes.Read())
                        {
                            string barrio = "";
                            OleDbCommand comandoBarrios = new OleDbCommand();
                            comandoBarrios.Connection = conexionDB;
                            comandoBarrios.CommandType = CommandType.TableDirect;
                            comandoBarrios.CommandText = "Select * FROM Barrios";

                            OleDbDataReader readerBarrios = comandoBarrios.ExecuteReader();

                            while (readerBarrios.Read())
                            {

                                if (int.Parse(readerBarrios["Cod_barrio"].ToString()) == int.Parse(readerClientes["ID_barrio"].ToString()))
                                {
                                    barrio = readerBarrios["Detalle"].ToString();
                                }

                            }

                            grdData.Rows.Add(barrio, readerClientes[1]); //name of sucursal, counter
                        }
                        readerClientes.Close();
                        break;


                    case "Sucursal":

                        grdData.Columns[0].HeaderText = "Sucursal";
                        grdData.Columns[1].HeaderText = "Número de clientes";

                        comandoClientes.CommandText = "SELECT ID_sucursal, Count(ID_sucursal) FROM CLIENTES " + //counting the number of barrios
                            "GROUP BY ID_sucursal ORDER BY Count(ID_sucursal) DESC";
                        OleDbDataReader readerClientes2 = comandoClientes.ExecuteReader();

                        while (readerClientes2.Read())
                        {
                            string sucursal = "";
                            OleDbCommand comandoSucursales = new OleDbCommand();
                            comandoSucursales.Connection = conexionDB;
                            comandoSucursales.CommandType = CommandType.TableDirect;
                            comandoSucursales.CommandText = "Select * FROM Sucursales";

                            OleDbDataReader readerSucursales = comandoSucursales.ExecuteReader();

                            while (readerSucursales.Read())
                            {

                                if (int.Parse(readerSucursales["Cod_sucursal"].ToString()) == int.Parse(readerClientes2["ID_sucursal"].ToString()))
                                {
                                    sucursal = readerSucursales["Detalle"].ToString();
                                }

                            }

                            grdData.Rows.Add(sucursal, readerClientes2[1]); //name, counter

                            readerSucursales.Close();
                        }

                        readerClientes2.Close();
                        break;


                    case "Actividad":

                        grdData.Columns[0].HeaderText = "Actividad"; //changing the header from the first column
                        grdData.Columns[1].HeaderText = "Número de clientes"; //changing the header from the first column

                        comandoClientes.CommandText = "SELECT ID_actividad, Count(ID_actividad) FROM CLIENTES " + //counting the number of barrios
                            "GROUP BY ID_actividad ORDER BY Count(ID_actividad) DESC";
                        OleDbDataReader readerClientes3 = comandoClientes.ExecuteReader();

                        while (readerClientes3.Read())
                        {
                            string sucursal = "";
                            OleDbCommand comandoActividades = new OleDbCommand();
                            comandoActividades.Connection = conexionDB;
                            comandoActividades.CommandType = CommandType.TableDirect;
                            comandoActividades.CommandText = "Select * FROM Actividades";

                            OleDbDataReader readerActividades = comandoActividades.ExecuteReader();

                            while (readerActividades.Read())
                            {

                                if (int.Parse(readerActividades["Cod_actividad"].ToString()) == int.Parse(readerClientes3["ID_actividad"].ToString()))
                                {
                                    sucursal = readerActividades["Detalle"].ToString();
                                }

                            }

                            readerActividades.Close();

                            grdData.Rows.Add(sucursal, readerClientes3[1]); //name, counter
                        }

                        readerClientes3.Close();

                        break;
                }

                conexionDB.Close();
            }

            catch
            {
                MessageBox.Show("Error en el mostrado de datos estratégicos");
            }
        }

        private void cbInput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmConsultaDatosEstrategicos_Load(object sender, EventArgs e)
        {

        }
    }
}
