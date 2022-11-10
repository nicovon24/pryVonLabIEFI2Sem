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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.bienvenidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarListadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeTodosLosClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeClientesDeudoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeClientesEnxActividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarOConsultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarSaldoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeDatosEstratégicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevosClientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarDeudaDeClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pctFB = new System.Windows.Forms.PictureBox();
            this.pctCrossfit = new System.Windows.Forms.PictureBox();
            this.lnkInsta = new System.Windows.Forms.LinkLabel();
            this.menuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCrossfit)).BeginInit();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bienvenidoToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(641, 24);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // bienvenidoToolStripMenuItem
            // 
            this.bienvenidoToolStripMenuItem.Name = "bienvenidoToolStripMenuItem";
            this.bienvenidoToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.bienvenidoToolStripMenuItem.Text = "Bienvenido!";
            this.bienvenidoToolStripMenuItem.Click += new System.EventHandler(this.bienvenidoToolStripMenuItem_Click);
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
            this.mostrarListadosToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
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
            this.buscarSaldoClienteToolStripMenuItem,
            this.consultaDeDatosEstratégicosToolStripMenuItem});
            this.buscarOConsultarToolStripMenuItem.Name = "buscarOConsultarToolStripMenuItem";
            this.buscarOConsultarToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.buscarOConsultarToolStripMenuItem.Text = "Buscar o consultar";
            // 
            // buscarSaldoClienteToolStripMenuItem
            // 
            this.buscarSaldoClienteToolStripMenuItem.Name = "buscarSaldoClienteToolStripMenuItem";
            this.buscarSaldoClienteToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.buscarSaldoClienteToolStripMenuItem.Text = "Buscar saldo cliente";
            this.buscarSaldoClienteToolStripMenuItem.Click += new System.EventHandler(this.buscarSaldoClienteToolStripMenuItem_Click);
            // 
            // consultaDeDatosEstratégicosToolStripMenuItem
            // 
            this.consultaDeDatosEstratégicosToolStripMenuItem.Name = "consultaDeDatosEstratégicosToolStripMenuItem";
            this.consultaDeDatosEstratégicosToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.consultaDeDatosEstratégicosToolStripMenuItem.Text = "Consulta de datos estratégicos";
            this.consultaDeDatosEstratégicosToolStripMenuItem.Click += new System.EventHandler(this.consultaDeDatosEstratégicosToolStripMenuItem_Click);
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarNuevosClientesToolStripMenuItem1});
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
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
            this.actualizarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizarDeudaDeClienteToolStripMenuItem});
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.actualizarToolStripMenuItem.Text = "Actualizar";
            // 
            // actualizarDeudaDeClienteToolStripMenuItem
            // 
            this.actualizarDeudaDeClienteToolStripMenuItem.Name = "actualizarDeudaDeClienteToolStripMenuItem";
            this.actualizarDeudaDeClienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.actualizarDeudaDeClienteToolStripMenuItem.Text = "Actualizar datos";
            this.actualizarDeudaDeClienteToolStripMenuItem.Click += new System.EventHandler(this.actualizarDeudaDeClienteToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarClienteToolStripMenuItem});
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // eliminarClienteToolStripMenuItem
            // 
            this.eliminarClienteToolStripMenuItem.Name = "eliminarClienteToolStripMenuItem";
            this.eliminarClienteToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.eliminarClienteToolStripMenuItem.Text = "Eliminar cliente";
            this.eliminarClienteToolStripMenuItem.Click += new System.EventHandler(this.eliminarClienteToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // pctFB
            // 
            this.pctFB.Image = ((System.Drawing.Image)(resources.GetObject("pctFB.Image")));
            this.pctFB.Location = new System.Drawing.Point(112, 160);
            this.pctFB.Name = "pctFB";
            this.pctFB.Size = new System.Drawing.Size(171, 166);
            this.pctFB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctFB.TabIndex = 2;
            this.pctFB.TabStop = false;
            // 
            // pctCrossfit
            // 
            this.pctCrossfit.Image = ((System.Drawing.Image)(resources.GetObject("pctCrossfit.Image")));
            this.pctCrossfit.Location = new System.Drawing.Point(382, 160);
            this.pctCrossfit.Name = "pctCrossfit";
            this.pctCrossfit.Size = new System.Drawing.Size(171, 166);
            this.pctCrossfit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCrossfit.TabIndex = 3;
            this.pctCrossfit.TabStop = false;
            // 
            // lnkInsta
            // 
            this.lnkInsta.ActiveLinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.lnkInsta.AutoSize = true;
            this.lnkInsta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkInsta.LinkColor = System.Drawing.Color.Yellow;
            this.lnkInsta.Location = new System.Drawing.Point(109, 374);
            this.lnkInsta.Name = "lnkInsta";
            this.lnkInsta.Size = new System.Drawing.Size(121, 18);
            this.lnkInsta.TabIndex = 4;
            this.lnkInsta.TabStop = true;
            this.lnkInsta.Text = "Link to Instagram";
            this.lnkInsta.VisitedLinkColor = System.Drawing.SystemColors.ActiveCaption;
            this.lnkInsta.Click += new System.EventHandler(this.linkLabel1_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(641, 477);
            this.Controls.Add(this.lnkInsta);
            this.Controls.Add(this.pctCrossfit);
            this.Controls.Add(this.pctFB);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCrossfit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarListadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeTodosLosClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeClientesDeudoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem buscarOConsultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevosClientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeClientesEnxActividadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeDatosEstratégicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarSaldoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarDeudaDeClienteToolStripMenuItem;
        private System.Windows.Forms.PictureBox pctFB;
        private System.Windows.Forms.PictureBox pctCrossfit;
        private System.Windows.Forms.ToolStripMenuItem bienvenidoToolStripMenuItem;
        private System.Windows.Forms.LinkLabel lnkInsta;
    }
}