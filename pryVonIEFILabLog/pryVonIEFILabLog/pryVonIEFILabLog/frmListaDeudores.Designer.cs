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
            ((System.ComponentModel.ISupportInitialize)(this.grdListaDeudores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(341, 283);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(86, 45);
            this.btnBorrar.TabIndex = 42;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(341, 347);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(86, 45);
            this.btnVolver.TabIndex = 41;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(455, 283);
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
            this.grdListaDeudores.Location = new System.Drawing.Point(12, 21);
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
            this.lblCantClientesRes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantClientesRes.Location = new System.Drawing.Point(151, 323);
            this.lblCantClientesRes.Name = "lblCantClientesRes";
            this.lblCantClientesRes.Size = new System.Drawing.Size(143, 21);
            this.lblCantClientesRes.TabIndex = 49;
            this.lblCantClientesRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPromDeudaRes
            // 
            this.lblPromDeudaRes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromDeudaRes.Location = new System.Drawing.Point(151, 373);
            this.lblPromDeudaRes.Name = "lblPromDeudaRes";
            this.lblPromDeudaRes.Size = new System.Drawing.Size(141, 23);
            this.lblPromDeudaRes.TabIndex = 48;
            this.lblPromDeudaRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalDeudaRes
            // 
            this.lblTotalDeudaRes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalDeudaRes.Location = new System.Drawing.Point(151, 284);
            this.lblTotalDeudaRes.Name = "lblTotalDeudaRes";
            this.lblTotalDeudaRes.Size = new System.Drawing.Size(141, 23);
            this.lblTotalDeudaRes.TabIndex = 47;
            this.lblTotalDeudaRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCantClientes
            // 
            this.lblCantClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantClientes.Location = new System.Drawing.Point(7, 325);
            this.lblCantClientes.Name = "lblCantClientes";
            this.lblCantClientes.Size = new System.Drawing.Size(129, 37);
            this.lblCantClientes.TabIndex = 45;
            this.lblCantClientes.Text = "Cantidad de clientes deudores\r\n";
            // 
            // lblPromDeuda
            // 
            this.lblPromDeuda.AutoSize = true;
            this.lblPromDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromDeuda.Location = new System.Drawing.Point(9, 376);
            this.lblPromDeuda.Name = "lblPromDeuda";
            this.lblPromDeuda.Size = new System.Drawing.Size(116, 15);
            this.lblPromDeuda.TabIndex = 46;
            this.lblPromDeuda.Text = "Promedio de deuda";
            // 
            // lblTotalDeuda
            // 
            this.lblTotalDeuda.AutoSize = true;
            this.lblTotalDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDeuda.Location = new System.Drawing.Point(9, 287);
            this.lblTotalDeuda.Name = "lblTotalDeuda";
            this.lblTotalDeuda.Size = new System.Drawing.Size(89, 15);
            this.lblTotalDeuda.TabIndex = 44;
            this.lblTotalDeuda.Text = "Total de deuda";
            // 
            // frmListaDeudores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 421);
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
            this.Name = "frmListaDeudores";
            this.Text = "Lista de deudores";
            this.Load += new System.EventHandler(this.frmListaDeudores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdListaDeudores)).EndInit();
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
    }
}