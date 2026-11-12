namespace EnviosExpress
{
    partial class frmSeguimiento
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
            this.lblSegResumen = new System.Windows.Forms.Label();
            this.dgvSeguimiento = new System.Windows.Forms.DataGridView();
            this.lblSegEstado = new System.Windows.Forms.Label();
            this.lblSegGuia = new System.Windows.Forms.Label();
            this.txtSegGuia = new System.Windows.Forms.TextBox();
            this.btnSegBuscar = new System.Windows.Forms.Button();
            this.gbSegMovimiento = new System.Windows.Forms.GroupBox();
            this.btnSegRegistrar = new System.Windows.Forms.Button();
            this.cboSegRepartidor = new System.Windows.Forms.ComboBox();
            this.lblSegRepartidor = new System.Windows.Forms.Label();
            this.txtSegNota = new System.Windows.Forms.TextBox();
            this.lblSegNota = new System.Windows.Forms.Label();
            this.cboSegEstado = new System.Windows.Forms.ComboBox();
            this.lblSegNuevoEstado = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblSegTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeguimiento)).BeginInit();
            this.gbSegMovimiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSegResumen
            // 
            this.lblSegResumen.Location = new System.Drawing.Point(23, 124);
            this.lblSegResumen.Name = "lblSegResumen";
            this.lblSegResumen.Size = new System.Drawing.Size(218, 227);
            this.lblSegResumen.TabIndex = 0;
            this.lblSegResumen.Text = "Resumen de seguimiento";
            // 
            // dgvSeguimiento
            // 
            this.dgvSeguimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeguimiento.Location = new System.Drawing.Point(423, 111);
            this.dgvSeguimiento.Name = "dgvSeguimiento";
            this.dgvSeguimiento.Size = new System.Drawing.Size(414, 274);
            this.dgvSeguimiento.TabIndex = 1;
            // 
            // lblSegEstado
            // 
            this.lblSegEstado.AutoSize = true;
            this.lblSegEstado.Location = new System.Drawing.Point(25, 360);
            this.lblSegEstado.Name = "lblSegEstado";
            this.lblSegEstado.Size = new System.Drawing.Size(148, 19);
            this.lblSegEstado.TabIndex = 2;
            this.lblSegEstado.Text = "Estado de seguimiento";
            // 
            // lblSegGuia
            // 
            this.lblSegGuia.AutoSize = true;
            this.lblSegGuia.Location = new System.Drawing.Point(23, 80);
            this.lblSegGuia.Name = "lblSegGuia";
            this.lblSegGuia.Size = new System.Drawing.Size(40, 19);
            this.lblSegGuia.TabIndex = 3;
            this.lblSegGuia.Text = "Guía:";
            // 
            // txtSegGuia
            // 
            this.txtSegGuia.Location = new System.Drawing.Point(63, 80);
            this.txtSegGuia.Name = "txtSegGuia";
            this.txtSegGuia.Size = new System.Drawing.Size(178, 25);
            this.txtSegGuia.TabIndex = 4;
            // 
            // btnSegBuscar
            // 
            this.btnSegBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.btnSegBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSegBuscar.ForeColor = System.Drawing.Color.White;
            this.btnSegBuscar.Location = new System.Drawing.Point(251, 79);
            this.btnSegBuscar.Name = "btnSegBuscar";
            this.btnSegBuscar.Size = new System.Drawing.Size(75, 34);
            this.btnSegBuscar.TabIndex = 5;
            this.btnSegBuscar.Text = "Buscar";
            this.btnSegBuscar.UseVisualStyleBackColor = true;
            this.btnSegBuscar.Click += new System.EventHandler(this.btnSegBuscar_Click);
            // 
            // gbSegMovimiento
            // 
            this.gbSegMovimiento.Controls.Add(this.btnSegRegistrar);
            this.gbSegMovimiento.Controls.Add(this.cboSegRepartidor);
            this.gbSegMovimiento.Controls.Add(this.lblSegRepartidor);
            this.gbSegMovimiento.Controls.Add(this.txtSegNota);
            this.gbSegMovimiento.Controls.Add(this.lblSegNota);
            this.gbSegMovimiento.Controls.Add(this.cboSegEstado);
            this.gbSegMovimiento.Controls.Add(this.lblSegNuevoEstado);
            this.gbSegMovimiento.Location = new System.Drawing.Point(27, 402);
            this.gbSegMovimiento.Name = "gbSegMovimiento";
            this.gbSegMovimiento.Size = new System.Drawing.Size(519, 121);
            this.gbSegMovimiento.TabIndex = 6;
            this.gbSegMovimiento.TabStop = false;
            this.gbSegMovimiento.Text = "Registrar movimiento";
            // 
            // btnSegRegistrar
            // 
            this.btnSegRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnSegRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSegRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnSegRegistrar.Location = new System.Drawing.Point(340, 66);
            this.btnSegRegistrar.Name = "btnSegRegistrar";
            this.btnSegRegistrar.Size = new System.Drawing.Size(155, 36);
            this.btnSegRegistrar.TabIndex = 6;
            this.btnSegRegistrar.Text = "Registrar movimiento";
            this.btnSegRegistrar.UseVisualStyleBackColor = true;
            this.btnSegRegistrar.Click += new System.EventHandler(this.btnSegRegistrar_Click);
            // 
            // cboSegRepartidor
            // 
            this.cboSegRepartidor.FormattingEnabled = true;
            this.cboSegRepartidor.Location = new System.Drawing.Point(374, 25);
            this.cboSegRepartidor.Name = "cboSegRepartidor";
            this.cboSegRepartidor.Size = new System.Drawing.Size(121, 25);
            this.cboSegRepartidor.TabIndex = 5;
            // 
            // lblSegRepartidor
            // 
            this.lblSegRepartidor.AutoSize = true;
            this.lblSegRepartidor.Location = new System.Drawing.Point(292, 28);
            this.lblSegRepartidor.Name = "lblSegRepartidor";
            this.lblSegRepartidor.Size = new System.Drawing.Size(76, 19);
            this.lblSegRepartidor.TabIndex = 4;
            this.lblSegRepartidor.Text = "Repartidor:";
            // 
            // txtSegNota
            // 
            this.txtSegNota.Location = new System.Drawing.Point(64, 63);
            this.txtSegNota.Name = "txtSegNota";
            this.txtSegNota.Size = new System.Drawing.Size(206, 25);
            this.txtSegNota.TabIndex = 3;
            // 
            // lblSegNota
            // 
            this.lblSegNota.AutoSize = true;
            this.lblSegNota.Location = new System.Drawing.Point(16, 66);
            this.lblSegNota.Name = "lblSegNota";
            this.lblSegNota.Size = new System.Drawing.Size(42, 19);
            this.lblSegNota.TabIndex = 2;
            this.lblSegNota.Text = "Nota:";
            // 
            // cboSegEstado
            // 
            this.cboSegEstado.FormattingEnabled = true;
            this.cboSegEstado.Location = new System.Drawing.Point(109, 25);
            this.cboSegEstado.Name = "cboSegEstado";
            this.cboSegEstado.Size = new System.Drawing.Size(121, 25);
            this.cboSegEstado.TabIndex = 1;
            this.cboSegEstado.SelectedIndexChanged += new System.EventHandler(this.cboSegEstado_SelectedIndexChanged);
            // 
            // lblSegNuevoEstado
            // 
            this.lblSegNuevoEstado.AutoSize = true;
            this.lblSegNuevoEstado.Location = new System.Drawing.Point(6, 25);
            this.lblSegNuevoEstado.Name = "lblSegNuevoEstado";
            this.lblSegNuevoEstado.Size = new System.Drawing.Size(97, 19);
            this.lblSegNuevoEstado.TabIndex = 0;
            this.lblSegNuevoEstado.Text = "Nuevo estado:";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Location = new System.Drawing.Point(747, 500);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(90, 38);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblSegTitulo
            // 
            this.lblSegTitulo.AutoSize = true;
            this.lblSegTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblSegTitulo.Name = "lblSegTitulo";
            this.lblSegTitulo.Size = new System.Drawing.Size(388, 32);
            this.lblSegTitulo.TabIndex = 9;
            this.lblSegTitulo.Text = "Gestión y Seguimiento de Envíos";
            // 
            // frmSeguimiento
            // 
            this.AcceptButton = this.btnSegBuscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.lblSegTitulo);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblSegResumen);
            this.Controls.Add(this.gbSegMovimiento);
            this.Controls.Add(this.btnSegBuscar);
            this.Controls.Add(this.txtSegGuia);
            this.Controls.Add(this.lblSegGuia);
            this.Controls.Add(this.lblSegEstado);
            this.Controls.Add(this.dgvSeguimiento);
            this.Controls.Add(this.lblSegResumen);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmSeguimiento";
            this.Text = "frmSeguimiento";
            this.Load += new System.EventHandler(this.frmSeguimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeguimiento)).EndInit();
            this.gbSegMovimiento.ResumeLayout(false);
            this.gbSegMovimiento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSegResumen;
        private System.Windows.Forms.DataGridView dgvSeguimiento;
        private System.Windows.Forms.Label lblSegEstado;
        private System.Windows.Forms.Label lblSegGuia;
        private System.Windows.Forms.TextBox txtSegGuia;
        private System.Windows.Forms.Button btnSegBuscar;
        private System.Windows.Forms.GroupBox gbSegMovimiento;
        private System.Windows.Forms.Label lblSegNuevoEstado;
        private System.Windows.Forms.TextBox txtSegNota;
        private System.Windows.Forms.Label lblSegNota;
        private System.Windows.Forms.ComboBox cboSegEstado;
        private System.Windows.Forms.ComboBox cboSegRepartidor;
        private System.Windows.Forms.Label lblSegRepartidor;
        private System.Windows.Forms.Button btnSegRegistrar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblSegTitulo;
    }
}