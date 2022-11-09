namespace pryVonIEFILabLog
{
    partial class frmBuscarSaldoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarSaldoCliente));
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.lblDeudaRes = new System.Windows.Forms.Label();
            this.lblDeudad = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pctCrossfit = new System.Windows.Forms.PictureBox();
            this.pctFB = new System.Windows.Forms.PictureBox();
            this.gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCrossfit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFB)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(111, 325);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(63, 31);
            this.btnVolver.TabIndex = 44;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(211, 324);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(65, 32);
            this.btnMostrar.TabIndex = 43;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(12, 324);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(63, 32);
            this.btnBorrar.TabIndex = 45;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // gbDatos
            // 
            this.gbDatos.BackColor = System.Drawing.Color.Black;
            this.gbDatos.Controls.Add(this.lblDeudaRes);
            this.gbDatos.Controls.Add(this.lblDeudad);
            this.gbDatos.ForeColor = System.Drawing.Color.White;
            this.gbDatos.Location = new System.Drawing.Point(12, 197);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(264, 108);
            this.gbDatos.TabIndex = 46;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos cliente";
            // 
            // lblDeudaRes
            // 
            this.lblDeudaRes.BackColor = System.Drawing.Color.White;
            this.lblDeudaRes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDeudaRes.ForeColor = System.Drawing.Color.Black;
            this.lblDeudaRes.Location = new System.Drawing.Point(27, 58);
            this.lblDeudaRes.Name = "lblDeudaRes";
            this.lblDeudaRes.Size = new System.Drawing.Size(217, 29);
            this.lblDeudaRes.TabIndex = 49;
            this.lblDeudaRes.Text = "Inserte el dni que quiere buscar";
            this.lblDeudaRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeudad
            // 
            this.lblDeudad.AutoSize = true;
            this.lblDeudad.Location = new System.Drawing.Point(24, 34);
            this.lblDeudad.Name = "lblDeudad";
            this.lblDeudad.Size = new System.Drawing.Size(39, 13);
            this.lblDeudad.TabIndex = 48;
            this.lblDeudad.Text = "Deuda";
            // 
            // lblDNI
            // 
            this.lblDNI.ForeColor = System.Drawing.Color.White;
            this.lblDNI.Location = new System.Drawing.Point(12, 112);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(86, 19);
            this.lblDNI.TabIndex = 47;
            this.lblDNI.Text = "DNI cliente\r\n";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(12, 134);
            this.txtDNI.MaxLength = 8;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(110, 20);
            this.txtDNI.TabIndex = 48;
            this.txtDNI.TextChanged += new System.EventHandler(this.txtDNI_TextChanged);
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(190, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 42);
            this.label1.TabIndex = 49;
            this.label1.Text = "Ejemplos de \r\nprueba: 5555, 21332132";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pctCrossfit
            // 
            this.pctCrossfit.Image = ((System.Drawing.Image)(resources.GetObject("pctCrossfit.Image")));
            this.pctCrossfit.Location = new System.Drawing.Point(184, 12);
            this.pctCrossfit.Name = "pctCrossfit";
            this.pctCrossfit.Size = new System.Drawing.Size(92, 76);
            this.pctCrossfit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCrossfit.TabIndex = 58;
            this.pctCrossfit.TabStop = false;
            // 
            // pctFB
            // 
            this.pctFB.Image = ((System.Drawing.Image)(resources.GetObject("pctFB.Image")));
            this.pctFB.Location = new System.Drawing.Point(8, 14);
            this.pctFB.Name = "pctFB";
            this.pctFB.Size = new System.Drawing.Size(95, 74);
            this.pctFB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctFB.TabIndex = 57;
            this.pctFB.TabStop = false;
            // 
            // frmBuscarSaldoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(314, 382);
            this.Controls.Add(this.pctCrossfit);
            this.Controls.Add(this.pctFB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnMostrar);
            this.Name = "frmBuscarSaldoCliente";
            this.Text = "Buscar Saldo Cliente";
            this.Load += new System.EventHandler(this.frmBuscarSaldoCliente_Load);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCrossfit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblDeudaRes;
        private System.Windows.Forms.Label lblDeudad;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pctCrossfit;
        private System.Windows.Forms.PictureBox pctFB;
    }
}