namespace pryVonIEFILabLog
{
    partial class frmAgregarNuevo
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.nudDeuda = new System.Windows.Forms.NumericUpDown();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.cbBarrio = new System.Windows.Forms.ComboBox();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.cbActividad = new System.Windows.Forms.ComboBox();
            this.lblActividad = new System.Windows.Forms.Label();
            this.cbSucursal = new System.Windows.Forms.ComboBox();
            this.lblSucursal = new System.Windows.Forms.Label();
            this.cbProfesor = new System.Windows.Forms.ComboBox();
            this.lblProfesor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudDeuda)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(14, 67);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(91, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre y apellido";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(15, 25);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(29, 13);
            this.lblDNI.TabIndex = 2;
            this.lblDNI.Text = " DNI";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(131, 64);
            this.txtNombre.MaxLength = 30;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(120, 20);
            this.txtNombre.TabIndex = 7;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // nudDeuda
            // 
            this.nudDeuda.Location = new System.Drawing.Point(133, 194);
            this.nudDeuda.Maximum = new decimal(new int[] {
            400000,
            0,
            0,
            0});
            this.nudDeuda.Name = "nudDeuda";
            this.nudDeuda.Size = new System.Drawing.Size(77, 20);
            this.nudDeuda.TabIndex = 13;
            this.nudDeuda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(402, 201);
            this.txtEmail.MaxLength = 40;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(120, 20);
            this.txtEmail.TabIndex = 15;
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Location = new System.Drawing.Point(16, 151);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(34, 13);
            this.lblBarrio.TabIndex = 18;
            this.lblBarrio.Text = "Barrio";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(15, 112);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 17;
            this.lblSexo.Text = "Sexo";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(319, 159);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 24;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblDeuda
            // 
            this.lblDeuda.AutoSize = true;
            this.lblDeuda.Location = new System.Drawing.Point(16, 196);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(39, 13);
            this.lblDeuda.TabIndex = 23;
            this.lblDeuda.Text = "Deuda";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(324, 204);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 26;
            this.lblEmail.Text = "Email";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(402, 153);
            this.txtTel.MaxLength = 13;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(120, 20);
            this.txtTel.TabIndex = 27;
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(133, 22);
            this.txtDNI.MaxLength = 8;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(120, 20);
            this.txtDNI.TabIndex = 28;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress_1);
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "M",
            "F",
            "NS"});
            this.cbSexo.Location = new System.Drawing.Point(131, 109);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(121, 21);
            this.cbSexo.TabIndex = 29;
            // 
            // cbBarrio
            // 
            this.cbBarrio.FormattingEnabled = true;
            this.cbBarrio.Location = new System.Drawing.Point(133, 151);
            this.cbBarrio.Name = "cbBarrio";
            this.cbBarrio.Size = new System.Drawing.Size(121, 21);
            this.cbBarrio.TabIndex = 30;
            // 
            // btnAnadir
            // 
            this.btnAnadir.Location = new System.Drawing.Point(436, 256);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(86, 45);
            this.btnAnadir.TabIndex = 34;
            this.btnAnadir.Text = "Añadir nuevo";
            this.btnAnadir.UseVisualStyleBackColor = true;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(18, 256);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(91, 45);
            this.btnVolver.TabIndex = 35;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // cbActividad
            // 
            this.cbActividad.FormattingEnabled = true;
            this.cbActividad.Location = new System.Drawing.Point(401, 22);
            this.cbActividad.Name = "cbActividad";
            this.cbActividad.Size = new System.Drawing.Size(121, 21);
            this.cbActividad.TabIndex = 45;
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Location = new System.Drawing.Point(319, 25);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(51, 13);
            this.lblActividad.TabIndex = 44;
            this.lblActividad.Text = "Actividad";
            // 
            // cbSucursal
            // 
            this.cbSucursal.FormattingEnabled = true;
            this.cbSucursal.Location = new System.Drawing.Point(401, 110);
            this.cbSucursal.Name = "cbSucursal";
            this.cbSucursal.Size = new System.Drawing.Size(121, 21);
            this.cbSucursal.TabIndex = 49;
            // 
            // lblSucursal
            // 
            this.lblSucursal.AutoSize = true;
            this.lblSucursal.Location = new System.Drawing.Point(319, 112);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(48, 13);
            this.lblSucursal.TabIndex = 48;
            this.lblSucursal.Text = "Sucursal";
            // 
            // cbProfesor
            // 
            this.cbProfesor.FormattingEnabled = true;
            this.cbProfesor.Location = new System.Drawing.Point(401, 66);
            this.cbProfesor.Name = "cbProfesor";
            this.cbProfesor.Size = new System.Drawing.Size(121, 21);
            this.cbProfesor.TabIndex = 51;
            // 
            // lblProfesor
            // 
            this.lblProfesor.AutoSize = true;
            this.lblProfesor.Location = new System.Drawing.Point(319, 69);
            this.lblProfesor.Name = "lblProfesor";
            this.lblProfesor.Size = new System.Drawing.Size(46, 13);
            this.lblProfesor.TabIndex = 50;
            this.lblProfesor.Text = "Profesor";
            // 
            // frmAgregarNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 330);
            this.Controls.Add(this.cbProfesor);
            this.Controls.Add(this.lblProfesor);
            this.Controls.Add(this.cbSucursal);
            this.Controls.Add(this.lblSucursal);
            this.Controls.Add(this.cbActividad);
            this.Controls.Add(this.lblActividad);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAnadir);
            this.Controls.Add(this.cbBarrio);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblDeuda);
            this.Controls.Add(this.lblBarrio);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.nudDeuda);
            this.Controls.Add(this.txtNombre);
            this.Name = "frmAgregarNuevo";
            this.Text = "Agregar nuevo cliente";
            this.Load += new System.EventHandler(this.frmAgregarNuevo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDeuda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.NumericUpDown nudDeuda;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDeuda;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.ComboBox cbBarrio;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ComboBox cbActividad;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.ComboBox cbSucursal;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.ComboBox cbProfesor;
        private System.Windows.Forms.Label lblProfesor;
    }
}