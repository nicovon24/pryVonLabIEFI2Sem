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
    public partial class frmBuscarSaldoCliente : Form
    {
        public frmMenu frmMenu = new frmMenu();
        public frmBuscarSaldoCliente()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }

        private void frmBuscarSaldoCliente_Load(object sender, EventArgs e)
        {
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lblDeudaRes.Text = "No se ha encontrado todavía al sujeto";

            if (txtDNI.Text != "")
            {
                int codigoCliente = int.Parse(txtDNI.Text);

                try
                {
                    OleDbConnection conexionDB;
                    conexionDB = new OleDbConnection(frmMenu.urlDB);
                    conexionDB.Open();

                    OleDbCommand comandoCliente = new OleDbCommand();
                    comandoCliente.Connection = conexionDB;
                    comandoCliente.CommandType = CommandType.TableDirect;
                    comandoCliente.CommandText = "SELECT * FROM Clientes WHERE DNI=" + codigoCliente;
                    OleDbDataReader readerCliente = comandoCliente.ExecuteReader();

                    while (readerCliente.Read())
                    {
                        lblDeudaRes.Text = "$" + readerCliente["Deuda"].ToString();
                    }
                }

                catch
                {
                    MessageBox.Show("Error en el mostrado de saldo del client");
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            lblDeudaRes.Text = "Datos borrados";
        }
    }
}
