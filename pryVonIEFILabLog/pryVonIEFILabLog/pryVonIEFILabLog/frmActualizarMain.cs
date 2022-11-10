using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryVonIEFILabLog
{
    public partial class frmActualizarMain : Form
    {
        public frmActualizarMain()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(chkDeuda.Checked == true || chkBarrio.Checked == true || chkActividad.Checked == true || chkSucursal.Checked == true || chkProfesor.Checked == true)
            {
                this.Hide();
                frmActualizar frmNew = new frmActualizar(chkDeuda.Checked, chkBarrio.Checked, chkActividad.Checked, chkSucursal.Checked, chkProfesor.Checked);
                frmNew.Show();
            }
            else
            {
                MessageBox.Show("No ha seleccionado ninguna opción, si no quiere actualizar ningún dato vuelva atrás y cierre el programa.");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu frmNew = new frmMenu();
            frmNew.Show();
        }
    }
}
