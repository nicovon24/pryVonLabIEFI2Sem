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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEliminarCliente));
            this.bntEliminar = new System.Windows.Forms.Button();
            this.lblDNI = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblMSG = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.pctCrossfit = new System.Windows.Forms.PictureBox();
            this.pctFB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctCrossfit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFB)).BeginInit();
            this.SuspendLayout();
            // 
            // bntEliminar
            // 
            this.bntEliminar.Location = new System.Drawing.Point(169, 246);
            this.bntEliminar.Name = "bntEliminar";
            this.bntEliminar.Size = new System.Drawing.Size(65, 32);
            this.bntEliminar.TabIndex = 59;
            this.bntEliminar.Text = "Eliminar";
            this.bntEliminar.UseVisualStyleBackColor = true;
            this.bntEliminar.Click += new System.EventHandler(this.bntEliminar_Click);
            // 
            // lblDNI
            // 
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.ForeColor = System.Drawing.Color.White;
            this.lblDNI.Location = new System.Drawing.Point(9, 202);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(86, 19);
            this.lblDNI.TabIndex = 61;
            this.lblDNI.Text = "DNI cliente\r\n";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 247);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(63, 31);
            this.btnVolver.TabIndex = 60;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblMSG
            // 
            this.lblMSG.BackColor = System.Drawing.Color.Black;
            this.lblMSG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMSG.ForeColor = System.Drawing.Color.White;
            this.lblMSG.Location = new System.Drawing.Point(12, 111);
            this.lblMSG.Name = "lblMSG";
            this.lblMSG.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMSG.Size = new System.Drawing.Size(222, 67);
            this.lblMSG.TabIndex = 63;
            this.lblMSG.Text = "Tipee el código de un cliente para actualizar su deuda, ejemplos de \r\nprueba: 444" +
    "4, y números entre el rango 10000 y 10011";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(101, 202);
            this.txtDNI.MaxLength = 8;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(133, 20);
            this.txtDNI.TabIndex = 64;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // pctCrossfit
            // 
            this.pctCrossfit.Image = ((System.Drawing.Image)(resources.GetObject("pctCrossfit.Image")));
            this.pctCrossfit.Location = new System.Drawing.Point(142, 12);
            this.pctCrossfit.Name = "pctCrossfit";
            this.pctCrossfit.Size = new System.Drawing.Size(92, 76);
            this.pctCrossfit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCrossfit.TabIndex = 66;
            this.pctCrossfit.TabStop = false;
            // 
            // pctFB
            // 
            this.pctFB.Image = ((System.Drawing.Image)(resources.GetObject("pctFB.Image")));
            this.pctFB.Location = new System.Drawing.Point(11, 14);
            this.pctFB.Name = "pctFB";
            this.pctFB.Size = new System.Drawing.Size(95, 74);
            this.pctFB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctFB.TabIndex = 65;
            this.pctFB.TabStop = false;
            // 
            // frmEliminarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(261, 297);
            this.Controls.Add(this.pctCrossfit);
            this.Controls.Add(this.pctFB);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.lblMSG);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.bntEliminar);
            this.Name = "frmEliminarCliente";
            this.Text = "Eliminar Cliente de la base de datos";
            ((System.ComponentModel.ISupportInitialize)(this.pctCrossfit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntEliminar;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblMSG;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.PictureBox pctCrossfit;
        private System.Windows.Forms.PictureBox pctFB;
    }
}