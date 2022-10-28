using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
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

                string cbOption = cbInput.Text;

                OleDbConnection conexionDB;
                conexionDB = new OleDbConnection(frmMenu.urlDB);
                conexionDB.Open();

                OleDbCommand comandoClientes = new OleDbCommand();
                comandoClientes.Connection = conexionDB;
                comandoClientes.CommandType = CommandType.TableDirect;

                //basicamente segun el campo elegido en el combo box cuenta los valores de cada campo y los muestra en grilla
                switch (cbOption)
                {
                    case "Barrio":
                        string queryBarrio = "SELECT ID_barrio, Count(ID_barrio) FROM CLIENTES " + 
                        "GROUP BY ID_barrio ORDER BY Count(ID_barrio) DESC";

                        frmMenu.functGetStrategicData("Barrios", "Barrio", queryBarrio, "ID_barrio", "Cod_barrio", "Detalle", grdData);
                        break;


                    case "Sucursal":
                        string querySucursal = "SELECT ID_sucursal, Count(ID_sucursal) FROM CLIENTES " + 
                        "GROUP BY ID_sucursal ORDER BY Count(ID_sucursal) DESC";

                        frmMenu.functGetStrategicData("Sucursales", "Sucursal", querySucursal, "ID_sucursal", "Cod_sucursal", "Detalle", grdData);
                    break;


                    case "Actividad":
                        string queryActividad = "SELECT ID_actividad, Count(ID_actividad) FROM CLIENTES " +
                        "GROUP BY ID_actividad ORDER BY Count(ID_actividad) DESC";

                        frmMenu.functGetStrategicData("Actividades", "Actividad", queryActividad, "ID_actividad", "Cod_actividad", "Detalle", grdData);
                    break;


                    case "Profesor":
                        string queryProfesor = "SELECT ID_profesor, Count(ID_profesor) FROM CLIENTES " +
                            "GROUP BY ID_profesor ORDER BY Count(ID_profesor) DESC";

                        frmMenu.functGetStrategicData("Profesores", "Profesor", queryProfesor, "ID_profesor", "Cod_profesor", "Nombre", grdData);
                    break;


                    case "Sexo":
                        string querySexo = "SELECT Sexo, Count(Sexo) FROM CLIENTES " +
                        "GROUP BY Sexo ORDER BY Count(Sexo) DESC";
                        conexionDB = new OleDbConnection(frmMenu.urlDB);
                        conexionDB.Open();

                        OleDbCommand comandoSexo = new OleDbCommand();
                        comandoSexo.Connection = conexionDB;
                        comandoSexo.CommandType = CommandType.TableDirect;

                        grdData.Columns[0].HeaderText = "Sexo"; //changing the header from the first column
                        grdData.Columns[1].HeaderText = "Número de clientes"; //changing the header from the first column

                        comandoSexo.CommandText = querySexo;
                        OleDbDataReader readerClientes = comandoSexo.ExecuteReader();

                        while (readerClientes.Read())
                        {
                            grdData.Rows.Add(readerClientes[0].ToString(), readerClientes[1].ToString());
                        }
                        readerClientes.Close();
                     break;
            }

                conexionDB.Close();
        }

        private void cbInput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmConsultaDatosEstrategicos_Load(object sender, EventArgs e)
        {

        }
    }
}
