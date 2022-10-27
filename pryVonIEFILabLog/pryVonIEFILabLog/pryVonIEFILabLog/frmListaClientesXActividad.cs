﻿using System;
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
            //getting the id from actividad, bcs we want to search it then in clientes so we get the values dni and name
            grdListaClientes.Rows.Clear();

            int id = 0;

            OleDbConnection conexionDB;
            conexionDB = new OleDbConnection(frmMenu.urlDB);
            conexionDB.Open();

            OleDbCommand comandoActividades = new OleDbCommand();
            comandoActividades.Connection = conexionDB;
            comandoActividades.CommandType = CommandType.TableDirect;
            comandoActividades.CommandText = "SELECT * FROM ACTIVIDADES";
            OleDbDataReader readerActividades = comandoActividades.ExecuteReader();

            while (readerActividades.Read())
            {
                if (readerActividades["Detalle"].ToString() == cbActividad.Text)
                {
                    id = int.Parse(readerActividades["Cod_actividad"].ToString());
                }
            }

            //getting the data from the id actividad
            OleDbCommand comandoClientes= new OleDbCommand();
            comandoClientes.Connection = conexionDB;
            comandoClientes.CommandType = CommandType.TableDirect;
            comandoClientes.CommandText = "SELECT * FROM CLIENTES";
            OleDbDataReader readerClientes = comandoClientes.ExecuteReader();

            while (readerClientes.Read())
            {
                if (int.Parse(readerClientes["ID_actividad"].ToString()) == id)
                {
                    grdListaClientes.Rows.Add(readerClientes["DNI"], readerClientes["Nombre y apellido"]);
                }
            }

            readerClientes.Close();
            conexionDB.Close();

            btnBorrar.Enabled = true;
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
    }
}
