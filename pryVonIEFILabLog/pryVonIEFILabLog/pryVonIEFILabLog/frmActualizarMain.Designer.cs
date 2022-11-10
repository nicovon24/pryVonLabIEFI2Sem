namespace pryVonIEFILabLog
{
    partial class frmActualizarMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActualizarMain));
            this.gbPregunta = new System.Windows.Forms.GroupBox();
            this.chkProfesor = new System.Windows.Forms.CheckBox();
            this.chkSucursal = new System.Windows.Forms.CheckBox();
            this.chkActividad = new System.Windows.Forms.CheckBox();
            this.chkBarrio = new System.Windows.Forms.CheckBox();
            this.chkDeuda = new System.Windows.Forms.CheckBox();
            this.pctCrossfit = new System.Windows.Forms.PictureBox();
            this.pctFB = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gbPregunta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCrossfit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFB)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPregunta
            // 
            this.gbPregunta.BackColor = System.Drawing.Color.Black;
            this.gbPregunta.Controls.Add(this.chkProfesor);
            this.gbPregunta.Controls.Add(this.chkSucursal);
            this.gbPregunta.Controls.Add(this.chkActividad);
            this.gbPregunta.Controls.Add(this.chkBarrio);
            this.gbPregunta.Controls.Add(this.chkDeuda);
            this.gbPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPregunta.ForeColor = System.Drawing.Color.White;
            this.gbPregunta.Location = new System.Drawing.Point(23, 114);
            this.gbPregunta.Name = "gbPregunta";
            this.gbPregunta.Size = new System.Drawing.Size(362, 141);
            this.gbPregunta.TabIndex = 89;
            this.gbPregunta.TabStop = false;
            this.gbPregunta.Text = "¿Qué desea actualizar?";
            // 
            // chkProfesor
            // 
            this.chkProfesor.AutoSize = true;
            this.chkProfesor.Location = new System.Drawing.Point(264, 38);
            this.chkProfesor.Name = "chkProfesor";
            this.chkProfesor.Size = new System.Drawing.Size(77, 20);
            this.chkProfesor.TabIndex = 4;
            this.chkProfesor.Text = "Profesor";
            this.chkProfesor.UseVisualStyleBackColor = true;
            // 
            // chkSucursal
            // 
            this.chkSucursal.AutoSize = true;
            this.chkSucursal.Location = new System.Drawing.Point(138, 90);
            this.chkSucursal.Name = "chkSucursal";
            this.chkSucursal.Size = new System.Drawing.Size(78, 20);
            this.chkSucursal.TabIndex = 3;
            this.chkSucursal.Text = "Sucursal";
            this.chkSucursal.UseVisualStyleBackColor = true;
            // 
            // chkActividad
            // 
            this.chkActividad.AutoSize = true;
            this.chkActividad.Location = new System.Drawing.Point(138, 38);
            this.chkActividad.Name = "chkActividad";
            this.chkActividad.Size = new System.Drawing.Size(82, 20);
            this.chkActividad.TabIndex = 2;
            this.chkActividad.Text = "Actividad";
            this.chkActividad.UseVisualStyleBackColor = true;
            // 
            // chkBarrio
            // 
            this.chkBarrio.AutoSize = true;
            this.chkBarrio.Location = new System.Drawing.Point(17, 90);
            this.chkBarrio.Name = "chkBarrio";
            this.chkBarrio.Size = new System.Drawing.Size(62, 20);
            this.chkBarrio.TabIndex = 1;
            this.chkBarrio.Text = "Barrio";
            this.chkBarrio.UseVisualStyleBackColor = true;
            // 
            // chkDeuda
            // 
            this.chkDeuda.AutoSize = true;
            this.chkDeuda.Location = new System.Drawing.Point(18, 38);
            this.chkDeuda.Name = "chkDeuda";
            this.chkDeuda.Size = new System.Drawing.Size(67, 20);
            this.chkDeuda.TabIndex = 0;
            this.chkDeuda.Text = "Deuda";
            this.chkDeuda.UseVisualStyleBackColor = true;
            // 
            // pctCrossfit
            // 
            this.pctCrossfit.Image = ((System.Drawing.Image)(resources.GetObject("pctCrossfit.Image")));
            this.pctCrossfit.Location = new System.Drawing.Point(293, 10);
            this.pctCrossfit.Name = "pctCrossfit";
            this.pctCrossfit.Size = new System.Drawing.Size(92, 76);
            this.pctCrossfit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCrossfit.TabIndex = 80;
            this.pctCrossfit.TabStop = false;
            // 
            // pctFB
            // 
            this.pctFB.Image = ((System.Drawing.Image)(resources.GetObject("pctFB.Image")));
            this.pctFB.Location = new System.Drawing.Point(23, 12);
            this.pctFB.Name = "pctFB";
            this.pctFB.Size = new System.Drawing.Size(95, 74);
            this.pctFB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctFB.TabIndex = 79;
            this.pctFB.TabStop = false;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(24, 302);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(94, 48);
            this.btnVolver.TabIndex = 74;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(296, 302);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(89, 48);
            this.btnAceptar.TabIndex = 73;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmActualizarMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(412, 374);
            this.Controls.Add(this.gbPregunta);
            this.Controls.Add(this.pctCrossfit);
            this.Controls.Add(this.pctFB);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAceptar);
            this.Name = "frmActualizarMain";
            this.Text = "frmActualizarMain";
            this.gbPregunta.ResumeLayout(false);
            this.gbPregunta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctCrossfit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPregunta;
        private System.Windows.Forms.CheckBox chkSucursal;
        private System.Windows.Forms.CheckBox chkActividad;
        private System.Windows.Forms.CheckBox chkBarrio;
        private System.Windows.Forms.CheckBox chkDeuda;
        private System.Windows.Forms.PictureBox pctCrossfit;
        private System.Windows.Forms.PictureBox pctFB;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.CheckBox chkProfesor;
    }
}