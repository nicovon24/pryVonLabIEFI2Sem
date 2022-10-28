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
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblDeudad = new System.Windows.Forms.Label();
            this.lblDeudaRes = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(111, 222);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(63, 31);
            this.btnVolver.TabIndex = 44;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(211, 221);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(65, 32);
            this.btnMostrar.TabIndex = 43;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(12, 221);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(63, 32);
            this.btnBorrar.TabIndex = 45;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.lblDeudaRes);
            this.gbDatos.Controls.Add(this.lblDeudad);
            this.gbDatos.Location = new System.Drawing.Point(12, 94);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(264, 108);
            this.gbDatos.TabIndex = 46;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos cliente";
            // 
            // lblDNI
            // 
            this.lblDNI.Location = new System.Drawing.Point(12, 9);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(86, 19);
            this.lblDNI.TabIndex = 47;
            this.lblDNI.Text = "Código cliente\r\n";
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
            // lblDeudaRes
            // 
            this.lblDeudaRes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDeudaRes.Location = new System.Drawing.Point(27, 58);
            this.lblDeudaRes.Name = "lblDeudaRes";
            this.lblDeudaRes.Size = new System.Drawing.Size(217, 29);
            this.lblDeudaRes.TabIndex = 49;
            this.lblDeudaRes.Text = "No se ha encontrado todavía al sujeto";
            this.lblDeudaRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(12, 31);
            this.txtDNI.MaxLength = 8;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(110, 20);
            this.txtDNI.TabIndex = 48;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(190, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 42);
            this.label1.TabIndex = 49;
            this.label1.Text = "Ejemplos de \r\nprueba 3333, 21332132";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmBuscarSaldoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 268);
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
    }
}