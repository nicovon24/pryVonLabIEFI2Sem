namespace pryVonIEFILabLog
{
    partial class frmEliminarCliente
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
            this.bntEliminar = new System.Windows.Forms.Button();
            this.lblDNI = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblMSG = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bntEliminar
            // 
            this.bntEliminar.Location = new System.Drawing.Point(169, 136);
            this.bntEliminar.Name = "bntEliminar";
            this.bntEliminar.Size = new System.Drawing.Size(65, 32);
            this.bntEliminar.TabIndex = 59;
            this.bntEliminar.Text = "Eliminar";
            this.bntEliminar.UseVisualStyleBackColor = true;
            this.bntEliminar.Click += new System.EventHandler(this.bntEliminar_Click);
            // 
            // lblDNI
            // 
            this.lblDNI.Location = new System.Drawing.Point(9, 88);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(86, 19);
            this.lblDNI.TabIndex = 61;
            this.lblDNI.Text = "DNI cliente\r\n";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 137);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(63, 31);
            this.btnVolver.TabIndex = 60;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblMSG
            // 
            this.lblMSG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMSG.Location = new System.Drawing.Point(12, 9);
            this.lblMSG.Name = "lblMSG";
            this.lblMSG.Size = new System.Drawing.Size(222, 73);
            this.lblMSG.TabIndex = 63;
            this.lblMSG.Text = "Tipee el código de un cliente para actualizar su deuda, ejemplos de \r\nprueba: 444" +
    "4, y números entre el rango 10000 y 10011";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(101, 85);
            this.txtDNI.MaxLength = 8;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(133, 20);
            this.txtDNI.TabIndex = 64;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // frmEliminarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 192);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.lblMSG);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.bntEliminar);
            this.Name = "frmEliminarCliente";
            this.Text = "Eliminar Cliente de la base de datos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntEliminar;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblMSG;
        private System.Windows.Forms.TextBox txtDNI;
    }
}