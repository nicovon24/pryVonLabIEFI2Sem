namespace pryVonIEFILabLog
{
    partial class frmListaDatosClientes
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
            this.grdClientes = new System.Windows.Forms.DataGridView();
            this.colDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBarrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.lblTotalClientesRes = new System.Windows.Forms.Label();
            this.lblTotalClientes = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.prtVentana = new System.Windows.Forms.PrintDialog();
            this.prtDocument = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // grdClientes
            // 
            this.grdClientes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grdClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDNI,
            this.colNombre,
            this.colDeuda,
            this.colBarrio,
            this.colSucursal,
            this.colActividad});
            this.grdClientes.Location = new System.Drawing.Point(12, 12);
            this.grdClientes.Name = "grdClientes";
            this.grdClientes.Size = new System.Drawing.Size(648, 287);
            this.grdClientes.TabIndex = 0;
            // 
            // colDNI
            // 
            this.colDNI.HeaderText = "DNI";
            this.colDNI.Name = "colDNI";
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            // 
            // colDeuda
            // 
            this.colDeuda.HeaderText = "Deuda";
            this.colDeuda.Name = "colDeuda";
            // 
            // colBarrio
            // 
            this.colBarrio.HeaderText = "Barrio";
            this.colBarrio.Name = "colBarrio";
            // 
            // colSucursal
            // 
            this.colSucursal.HeaderText = "Sucursal";
            this.colSucursal.Name = "colSucursal";
            // 
            // colActividad
            // 
            this.colActividad.HeaderText = "Actividad";
            this.colActividad.Name = "colActividad";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(321, 328);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(84, 42);
            this.btnVolver.TabIndex = 36;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(576, 328);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(84, 42);
            this.btnMostrar.TabIndex = 37;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(449, 328);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(84, 42);
            this.btnBorrar.TabIndex = 38;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // lblTotalClientesRes
            // 
            this.lblTotalClientesRes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalClientesRes.Location = new System.Drawing.Point(21, 347);
            this.lblTotalClientesRes.Name = "lblTotalClientesRes";
            this.lblTotalClientesRes.Size = new System.Drawing.Size(202, 23);
            this.lblTotalClientesRes.TabIndex = 39;
            this.lblTotalClientesRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalClientes
            // 
            this.lblTotalClientes.AutoSize = true;
            this.lblTotalClientes.Location = new System.Drawing.Point(76, 328);
            this.lblTotalClientes.Name = "lblTotalClientes";
            this.lblTotalClientes.Size = new System.Drawing.Size(85, 13);
            this.lblTotalClientes.TabIndex = 40;
            this.lblTotalClientes.Text = "Total de clientes";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(576, 398);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(86, 45);
            this.btnGenerar.TabIndex = 41;
            this.btnGenerar.Text = "Generar reporte";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // prtVentana
            // 
            this.prtVentana.UseEXDialog = true;
            // 
            // prtDocument
            // 
            this.prtDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.prtDocument_PrintPage);
            // 
            // frmListaDatosClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 467);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblTotalClientes);
            this.Controls.Add(this.lblTotalClientesRes);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.grdClientes);
            this.Name = "frmListaDatosClientes";
            this.Text = "Mostrar todos los clientes";
            this.Load += new System.EventHandler(this.frmListaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdClientes;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBarrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActividad;
        private System.Windows.Forms.Label lblTotalClientesRes;
        private System.Windows.Forms.Label lblTotalClientes;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.PrintDialog prtVentana;
        private System.Drawing.Printing.PrintDocument prtDocument;
    }
}