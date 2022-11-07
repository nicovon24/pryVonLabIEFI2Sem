namespace pryVonIEFILabLog
{
    partial class frmConsultaDatosEstrategicos
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
            this.cbInput = new System.Windows.Forms.ComboBox();
            this.lblMSG = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.grdData = new System.Windows.Forms.DataGridView();
            this.colDato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.SuspendLayout();
            // 
            // cbInput
            // 
            this.cbInput.FormattingEnabled = true;
            this.cbInput.Items.AddRange(new object[] {
            "Barrio",
            "Sucursal",
            "Actividad",
            "Profesor",
            "Sexo"});
            this.cbInput.Location = new System.Drawing.Point(12, 88);
            this.cbInput.Name = "cbInput";
            this.cbInput.Size = new System.Drawing.Size(154, 21);
            this.cbInput.TabIndex = 0;
            this.cbInput.SelectedIndexChanged += new System.EventHandler(this.cbInput_SelectedIndexChanged);
            // 
            // lblMSG
            // 
            this.lblMSG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMSG.Location = new System.Drawing.Point(12, 19);
            this.lblMSG.Name = "lblMSG";
            this.lblMSG.Size = new System.Drawing.Size(358, 56);
            this.lblMSG.TabIndex = 1;
            this.lblMSG.Text = "Ingrese una opción para poder obtener los datos del campo que usted desea ver, ob" +
    "tendrá por ejemplo la cantidad de alumnos que hacen Crossfit";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(12, 314);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(0, 13);
            this.lblPromedio.TabIndex = 2;
            // 
            // grdData
            // 
            this.grdData.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDato,
            this.colValor});
            this.grdData.Location = new System.Drawing.Point(12, 139);
            this.grdData.Name = "grdData";
            this.grdData.Size = new System.Drawing.Size(358, 150);
            this.grdData.TabIndex = 41;
            // 
            // colDato
            // 
            this.colDato.HeaderText = "Dato";
            this.colDato.Name = "colDato";
            // 
            // colValor
            // 
            this.colValor.HeaderText = "Valor";
            this.colValor.Name = "colValor";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(294, 314);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(76, 35);
            this.btnMostrar.TabIndex = 40;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            this.btnMostrar.MouseHover += new System.EventHandler(this.btnMostrar_MouseHover);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 314);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(76, 35);
            this.btnVolver.TabIndex = 39;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmConsultaDatosEstrategicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 379);
            this.Controls.Add(this.grdData);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.lblMSG);
            this.Controls.Add(this.cbInput);
            this.Name = "frmConsultaDatosEstrategicos";
            this.Text = "v";
            this.Load += new System.EventHandler(this.frmConsultaDatosEstrategicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbInput;
        private System.Windows.Forms.Label lblMSG;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDato;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnVolver;
    }
}