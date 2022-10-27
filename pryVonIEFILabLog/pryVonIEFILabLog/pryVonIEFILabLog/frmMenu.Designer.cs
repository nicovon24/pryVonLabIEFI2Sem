namespace pryVonIEFILabLog
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarListadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeTodosLosClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeClientesDeudoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeClientesEnxActividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarOConsultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarClienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeUnClienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevosClientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.consultaDeDatosEstratégicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(358, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarListadosToolStripMenuItem,
            this.buscarOConsultarToolStripMenuItem,
            this.agregarToolStripMenuItem,
            this.actualizarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // mostrarListadosToolStripMenuItem
            // 
            this.mostrarListadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeTodosLosClientesToolStripMenuItem,
            this.listadoDeClientesDeudoresToolStripMenuItem1,
            this.listadoDeClientesEnxActividadToolStripMenuItem});
            this.mostrarListadosToolStripMenuItem.Name = "mostrarListadosToolStripMenuItem";
            this.mostrarListadosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mostrarListadosToolStripMenuItem.Text = "Mostrar listados";
            // 
            // listadoDeTodosLosClientesToolStripMenuItem
            // 
            this.listadoDeTodosLosClientesToolStripMenuItem.Name = "listadoDeTodosLosClientesToolStripMenuItem";
            this.listadoDeTodosLosClientesToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.listadoDeTodosLosClientesToolStripMenuItem.Text = "Listado de todos los clientes";
            this.listadoDeTodosLosClientesToolStripMenuItem.Click += new System.EventHandler(this.listadoDeTodosLosClientesToolStripMenuItem_Click_1);
            // 
            // listadoDeClientesDeudoresToolStripMenuItem1
            // 
            this.listadoDeClientesDeudoresToolStripMenuItem1.Name = "listadoDeClientesDeudoresToolStripMenuItem1";
            this.listadoDeClientesDeudoresToolStripMenuItem1.Size = new System.Drawing.Size(257, 22);
            this.listadoDeClientesDeudoresToolStripMenuItem1.Text = "Listado de clientes deudores";
            this.listadoDeClientesDeudoresToolStripMenuItem1.Click += new System.EventHandler(this.listadoDeClientesDeudoresToolStripMenuItem1_Click);
            // 
            // listadoDeClientesEnxActividadToolStripMenuItem
            // 
            this.listadoDeClientesEnxActividadToolStripMenuItem.Name = "listadoDeClientesEnxActividadToolStripMenuItem";
            this.listadoDeClientesEnxActividadToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.listadoDeClientesEnxActividadToolStripMenuItem.Text = "Listado de clientes en \"x\" actividad";
            this.listadoDeClientesEnxActividadToolStripMenuItem.Click += new System.EventHandler(this.listadoDeClientesEnxActividadToolStripMenuItem_Click);
            // 
            // buscarOConsultarToolStripMenuItem
            // 
            this.buscarOConsultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarClienteToolStripMenuItem1,
            this.consultaDeUnClienteToolStripMenuItem1,
            this.consultaDeDatosEstratégicosToolStripMenuItem});
            this.buscarOConsultarToolStripMenuItem.Name = "buscarOConsultarToolStripMenuItem";
            this.buscarOConsultarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.buscarOConsultarToolStripMenuItem.Text = "Buscar o consultar";
            // 
            // buscarClienteToolStripMenuItem1
            // 
            this.buscarClienteToolStripMenuItem1.Name = "buscarClienteToolStripMenuItem1";
            this.buscarClienteToolStripMenuItem1.Size = new System.Drawing.Size(235, 22);
            this.buscarClienteToolStripMenuItem1.Text = "Buscar cliente";
            // 
            // consultaDeUnClienteToolStripMenuItem1
            // 
            this.consultaDeUnClienteToolStripMenuItem1.Name = "consultaDeUnClienteToolStripMenuItem1";
            this.consultaDeUnClienteToolStripMenuItem1.Size = new System.Drawing.Size(235, 22);
            this.consultaDeUnClienteToolStripMenuItem1.Text = "Consulta de un cliente";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarNuevosClientesToolStripMenuItem1});
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            // 
            // agregarNuevosClientesToolStripMenuItem1
            // 
            this.agregarNuevosClientesToolStripMenuItem1.Name = "agregarNuevosClientesToolStripMenuItem1";
            this.agregarNuevosClientesToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.agregarNuevosClientesToolStripMenuItem1.Text = "Agregar Nuevos Clientes";
            this.agregarNuevosClientesToolStripMenuItem1.Click += new System.EventHandler(this.agregarNuevosClientesToolStripMenuItem1_Click);
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.actualizarToolStripMenuItem.Text = "Actualizar";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // consultaDeDatosEstratégicosToolStripMenuItem
            // 
            this.consultaDeDatosEstratégicosToolStripMenuItem.Name = "consultaDeDatosEstratégicosToolStripMenuItem";
            this.consultaDeDatosEstratégicosToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.consultaDeDatosEstratégicosToolStripMenuItem.Text = "Consulta de datos estratégicos";
            this.consultaDeDatosEstratégicosToolStripMenuItem.Click += new System.EventHandler(this.consultaDeDatosEstratégicosToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 191);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarListadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeTodosLosClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeClientesDeudoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem buscarOConsultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarClienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultaDeUnClienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevosClientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeClientesEnxActividadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeDatosEstratégicosToolStripMenuItem;
    }
}