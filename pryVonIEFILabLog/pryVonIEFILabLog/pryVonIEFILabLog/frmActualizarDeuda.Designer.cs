namespace pryVonIEFILabLog
{
    partial class frmActualizarDeuda
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
            this.lblMSG = new System.Windows.Forms.Label();
            this.txtDeuda = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMSG
            // 
            this.lblMSG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMSG.Location = new System.Drawing.Point(15, 9);
            this.lblMSG.Name = "lblMSG";
            this.lblMSG.Size = new System.Drawing.Size(222, 42);
            this.lblMSG.TabIndex = 56;
            this.lblMSG.Text = "Tipee el código de un cliente para actualizar su deuda, ejemplos de prueba: 3333," +
    " 21332132";
            this.lblMSG.Click += new System.EventHandler(this.lblMSG_Click);
            // 
            // txtDeuda
            // 
            this.txtDeuda.Location = new System.Drawing.Point(104, 148);
            this.txtDeuda.MaxLength = 10;
            this.txtDeuda.Name = "txtDeuda";
            this.txtDeuda.Size = new System.Drawing.Size(133, 20);
            this.txtDeuda.TabIndex = 55;
            this.txtDeuda.TextChanged += new System.EventHandler(this.txtDeuda_TextChanged);
            this.txtDeuda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeuda_KeyPress);
            // 
            // lblDNI
            // 
            this.lblDNI.Location = new System.Drawing.Point(12, 88);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(86, 19);
            this.lblDNI.TabIndex = 54;
            this.lblDNI.Text = "DNI cliente\r\n";
            this.lblDNI.Click += new System.EventHandler(this.lblDNI_Click);
            // 
            // lblDeuda
            // 
            this.lblDeuda.AutoSize = true;
            this.lblDeuda.Location = new System.Drawing.Point(12, 151);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(39, 13);
            this.lblDeuda.TabIndex = 48;
            this.lblDeuda.Text = "Deuda";
            this.lblDeuda.Click += new System.EventHandler(this.lblDeuda_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(15, 223);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(63, 31);
            this.btnVolver.TabIndex = 51;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(172, 222);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(65, 32);
            this.btnActualizar.TabIndex = 50;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(104, 85);
            this.txtDNI.MaxLength = 8;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(133, 20);
            this.txtDNI.TabIndex = 57;
            this.txtDNI.TextChanged += new System.EventHandler(this.txtDNI_TextChanged);
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // frmActualizarDeuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 278);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.lblDeuda);
            this.Controls.Add(this.lblMSG);
            this.Controls.Add(this.txtDeuda);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.btnActualizar);
            this.Name = "frmActualizarDeuda";
            this.Text = "Actualizar deuda de cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMSG;
        private System.Windows.Forms.TextBox txtDeuda;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblDeuda;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txtDNI;
    }
}