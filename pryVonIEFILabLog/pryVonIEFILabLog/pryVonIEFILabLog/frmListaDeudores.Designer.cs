namespace pryVonIEFILabLog
{
    partial class frmListaDeudores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaDeudores));
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.grdListaDeudores = new System.Windows.Forms.DataGridView();
            this.colDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCantClientesRes = new System.Windows.Forms.Label();
            this.lblPromDeudaRes = new System.Windows.Forms.Label();
            this.lblTotalDeudaRes = new System.Windows.Forms.Label();
            this.lblCantClientes = new System.Windows.Forms.Label();
            this.lblPromDeuda = new System.Windows.Forms.Label();
            this.lblTotalDeuda = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.prtVentana = new System.Windows.Forms.PrintDialog();
            this.prtDocument = new System.Drawing.Printing.PrintDocument();
            this.pctFB = new System.Windows.Forms.PictureBox();
            this.pctCrossfit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdListaDeudores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCrossfit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBorrar
            // 
            this.btnBorrar.ForeColor = System.Drawing.Color.Black;
            this.btnBorrar.Location = new System.Drawing.Point(341, 358);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(86, 45);
            this.btnBorrar.TabIndex = 42;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.ForeColor = System.Drawing.Color.Black;
            this.btnVolver.Location = new System.Drawing.Point(341, 422);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(86, 45);
            this.btnVolver.TabIndex = 41;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.ForeColor = System.Drawing.Color.Black;
            this.btnMostrar.Location = new System.Drawing.Point(455, 358);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(86, 45);
            this.btnMostrar.TabIndex = 40;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // grdListaDeudores
            // 
            this.grdListaDeudores.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grdListaDeudores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListaDeudores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDNI,
            this.colNombre,
            this.colDeuda});
            this.grdListaDeudores.Location = new System.Drawing.Point(12, 96);
            this.grdListaDeudores.Name = "grdListaDeudores";
            this.grdListaDeudores.Size = new System.Drawing.Size(529, 245);
            this.grdListaDeudores.TabIndex = 39;
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
            // lblCantClientesRes
            // 
            this.lblCantClientesRes.BackColor = System.Drawing.Color.White;
            this.lblCantClientesRes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantClientesRes.ForeColor = System.Drawing.Color.Black;
            this.lblCantClientesRes.Location = new System.Drawing.Point(151, 400);
            this.lblCantClientesRes.Name = "lblCantClientesRes";
            this.lblCantClientesRes.Size = new System.Drawing.Size(141, 21);
            this.lblCantClientesRes.TabIndex = 49;
            this.lblCantClientesRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPromDeudaRes
            // 
            this.lblPromDeudaRes.BackColor = System.Drawing.Color.White;
            this.lblPromDeudaRes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromDeudaRes.ForeColor = System.Drawing.Color.Black;
            this.lblPromDeudaRes.Location = new System.Drawing.Point(151, 448);
            this.lblPromDeudaRes.Name = "lblPromDeudaRes";
            this.lblPromDeudaRes.Size = new System.Drawing.Size(141, 21);
            this.lblPromDeudaRes.TabIndex = 48;
            this.lblPromDeudaRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalDeudaRes
            // 
            this.lblTotalDeudaRes.BackColor = System.Drawing.Color.White;
            this.lblTotalDeudaRes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalDeudaRes.ForeColor = System.Drawing.Color.Black;
            this.lblTotalDeudaRes.Location = new System.Drawing.Point(151, 359);
            this.lblTotalDeudaRes.Name = "lblTotalDeudaRes";
            this.lblTotalDeudaRes.Size = new System.Drawing.Size(141, 21);
            this.lblTotalDeudaRes.TabIndex = 47;
            this.lblTotalDeudaRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCantClientes
            // 
            this.lblCantClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantClientes.ForeColor = System.Drawing.Color.White;
            this.lblCantClientes.Location = new System.Drawing.Point(7, 400);
            this.lblCantClientes.Name = "lblCantClientes";
            this.lblCantClientes.Size = new System.Drawing.Size(129, 37);
            this.lblCantClientes.TabIndex = 45;
            this.lblCantClientes.Text = "Cantidad de clientes deudores\r\n";
            // 
            // lblPromDeuda
            // 
            this.lblPromDeuda.AutoSize = true;
            this.lblPromDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromDeuda.ForeColor = System.Drawing.Color.White;
            this.lblPromDeuda.Location = new System.Drawing.Point(9, 451);
            this.lblPromDeuda.Name = "lblPromDeuda";
            this.lblPromDeuda.Size = new System.Drawing.Size(116, 15);
            this.lblPromDeuda.TabIndex = 46;
            this.lblPromDeuda.Text = "Promedio de deuda";
            // 
            // lblTotalDeuda
            // 
            this.lblTotalDeuda.AutoSize = true;
            this.lblTotalDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDeuda.ForeColor = System.Drawing.Color.White;
            this.lblTotalDeuda.Location = new System.Drawing.Point(9, 362);
            this.lblTotalDeuda.Name = "lblTotalDeuda";
            this.lblTotalDeuda.Size = new System.Drawing.Size(89, 15);
            this.lblTotalDeuda.TabIndex = 44;
            this.lblTotalDeuda.Text = "Total de deuda";
            // 
            // btnGenerar
            // 
            this.btnGenerar.ForeColor = System.Drawing.Color.Black;
            this.btnGenerar.Location = new System.Drawing.Point(455, 426);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(86, 45);
            this.btnGenerar.TabIndex = 50;
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
            // pctFB
            // 
            this.pctFB.Image = ((System.Drawing.Image)(resources.GetObject("pctFB.Image")));
            this.pctFB.Location = new System.Drawing.Point(12, 14);
            this.pctFB.Name = "pctFB";
            this.pctFB.Size = new System.Drawing.Size(95, 74);
            this.pctFB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctFB.TabIndex = 51;
            this.pctFB.TabStop = false;
            // 
            // pctCrossfit
            // 
            this.pctCrossfit.Image = ((System.Drawing.Image)(resources.GetObject("pctCrossfit.Image")));
            this.pctCrossfit.Location = new System.Drawing.Point(132, 12);
            this.pctCrossfit.Name = "pctCrossfit";
            this.pctCrossfit.Size = new System.Drawing.Size(92, 76);
            this.pctCrossfit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCrossfit.TabIndex = 52;
            this.pctCrossfit.TabStop = false;
            // 
            // frmListaDeudores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(571, 496);
            this.Controls.Add(this.pctCrossfit);
            this.Controls.Add(this.pctFB);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblCantClientesRes);
            this.Controls.Add(this.lblPromDeudaRes);
            this.Controls.Add(this.lblTotalDeudaRes);
            this.Controls.Add(this.lblCantClientes);
            this.Controls.Add(this.lblPromDeuda);
            this.Controls.Add(this.lblTotalDeuda);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.grdListaDeudores);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmListaDeudores";
            this.Text = "Lista de deudores";
            this.Load += new System.EventHandler(this.frmListaDeudores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdListaDeudores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCrossfit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.DataGridView grdListaDeudores;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeuda;
        private System.Windows.Forms.Label lblCantClientesRes;
        private System.Windows.Forms.Label lblPromDeudaRes;
        private System.Windows.Forms.Label lblTotalDeudaRes;
        private System.Windows.Forms.Label lblCantClientes;
        private System.Windows.Forms.Label lblPromDeuda;
        private System.Windows.Forms.Label lblTotalDeuda;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.PrintDialog prtVentana;
        private System.Drawing.Printing.PrintDocument prtDocument;
        private System.Windows.Forms.PictureBox pctFB;
        private System.Windows.Forms.PictureBox pctCrossfit;
    }
}