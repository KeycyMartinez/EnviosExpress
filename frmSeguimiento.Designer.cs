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
            this.label3 = new System.Windows.Forms.Label();
            this.txtSegGuia = new System.Windows.Forms.TextBox();
            this.btnSegBuscar = new System.Windows.Forms.Button();
            this.gbSegMovimiento = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboSegEstado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSegNota = new System.Windows.Forms.TextBox();
            this.lblSegRepartidor = new System.Windows.Forms.Label();
            this.cboSegRepartidor = new System.Windows.Forms.ComboBox();
            this.btnSegRegistrar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSeguimiento)).BeginInit();
            this.gbSegMovimiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSegResumen
            // 
            this.lblSegResumen.Location = new System.Drawing.Point(31, 82);
            this.lblSegResumen.Name = "lblSegResumen";
            this.lblSegResumen.Size = new System.Drawing.Size(218, 227);
            this.lblSegResumen.TabIndex = 0;
            this.lblSegResumen.Text = "Resumen de seguimiento";
            // 
            // dgvSeguimiento
            // 
            this.dgvSeguimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSeguimiento.Location = new System.Drawing.Point(423, 82);
            this.dgvSeguimiento.Name = "dgvSeguimiento";
            this.dgvSeguimiento.Size = new System.Drawing.Size(414, 274);
            this.dgvSeguimiento.TabIndex = 1;
            // 
            // lblSegEstado
            // 
            this.lblSegEstado.AutoSize = true;
            this.lblSegEstado.Location = new System.Drawing.Point(31, 343);
            this.lblSegEstado.Name = "lblSegEstado";
            this.lblSegEstado.Size = new System.Drawing.Size(114, 13);
            this.lblSegEstado.TabIndex = 2;
            this.lblSegEstado.Text = "Estado de seguimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Guía:";
            // 
            // txtSegGuia
            // 
            this.txtSegGuia.Location = new System.Drawing.Point(71, 38);
            this.txtSegGuia.Name = "txtSegGuia";
            this.txtSegGuia.Size = new System.Drawing.Size(178, 20);
            this.txtSegGuia.TabIndex = 4;
            // 
            // btnSegBuscar
            // 
            this.btnSegBuscar.Location = new System.Drawing.Point(259, 38);
            this.btnSegBuscar.Name = "btnSegBuscar";
            this.btnSegBuscar.Size = new System.Drawing.Size(75, 23);
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
            this.gbSegMovimiento.Controls.Add(this.label5);
            this.gbSegMovimiento.Controls.Add(this.cboSegEstado);
            this.gbSegMovimiento.Controls.Add(this.label4);
            this.gbSegMovimiento.Location = new System.Drawing.Point(34, 388);
            this.gbSegMovimiento.Name = "gbSegMovimiento";
            this.gbSegMovimiento.Size = new System.Drawing.Size(595, 100);
            this.gbSegMovimiento.TabIndex = 6;
            this.gbSegMovimiento.TabStop = false;
            this.gbSegMovimiento.Text = "Registrar movimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Historial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nuevo estado:";
            // 
            // cboSegEstado
            // 
            this.cboSegEstado.FormattingEnabled = true;
            this.cboSegEstado.Location = new System.Drawing.Point(94, 25);
            this.cboSegEstado.Name = "cboSegEstado";
            this.cboSegEstado.Size = new System.Drawing.Size(121, 21);
            this.cboSegEstado.TabIndex = 1;
            this.cboSegEstado.SelectedIndexChanged += new System.EventHandler(this.cboSegEstado_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nota:";
            // 
            // txtSegNota
            // 
            this.txtSegNota.Location = new System.Drawing.Point(94, 65);
            this.txtSegNota.Name = "txtSegNota";
            this.txtSegNota.Size = new System.Drawing.Size(206, 20);
            this.txtSegNota.TabIndex = 3;
            // 
            // lblSegRepartidor
            // 
            this.lblSegRepartidor.AutoSize = true;
            this.lblSegRepartidor.Location = new System.Drawing.Point(324, 28);
            this.lblSegRepartidor.Name = "lblSegRepartidor";
            this.lblSegRepartidor.Size = new System.Drawing.Size(59, 13);
            this.lblSegRepartidor.TabIndex = 4;
            this.lblSegRepartidor.Text = "Repartidor:";
            // 
            // cboSegRepartidor
            // 
            this.cboSegRepartidor.FormattingEnabled = true;
            this.cboSegRepartidor.Location = new System.Drawing.Point(389, 25);
            this.cboSegRepartidor.Name = "cboSegRepartidor";
            this.cboSegRepartidor.Size = new System.Drawing.Size(121, 21);
            this.cboSegRepartidor.TabIndex = 5;
            // 
            // btnSegRegistrar
            // 
            this.btnSegRegistrar.Location = new System.Drawing.Point(355, 63);
            this.btnSegRegistrar.Name = "btnSegRegistrar";
            this.btnSegRegistrar.Size = new System.Drawing.Size(155, 23);
            this.btnSegRegistrar.TabIndex = 6;
            this.btnSegRegistrar.Text = "Registrar movimiento";
            this.btnSegRegistrar.UseVisualStyleBackColor = true;
            this.btnSegRegistrar.Click += new System.EventHandler(this.btnSegRegistrar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(747, 511);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmSeguimiento
            // 
            this.AcceptButton = this.btnSegBuscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbSegMovimiento);
            this.Controls.Add(this.btnSegBuscar);
            this.Controls.Add(this.txtSegGuia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSegEstado);
            this.Controls.Add(this.dgvSeguimiento);
            this.Controls.Add(this.lblSegResumen);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSegGuia;
        private System.Windows.Forms.Button btnSegBuscar;
        private System.Windows.Forms.GroupBox gbSegMovimiento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSegNota;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboSegEstado;
        private System.Windows.Forms.ComboBox cboSegRepartidor;
        private System.Windows.Forms.Label lblSegRepartidor;
        private System.Windows.Forms.Button btnSegRegistrar;
        private System.Windows.Forms.Button btnVolver;
    }
}