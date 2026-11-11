namespace EnviosExpress
{
    partial class frmEnvios
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvEnvios = new System.Windows.Forms.DataGridView();
            this.btnCancelarEnvio = new System.Windows.Forms.Button();
            this.txtEnvBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.tabEnvios = new System.Windows.Forms.TabControl();
            this.tabNuevoEnvio = new System.Windows.Forms.TabPage();
            this.btnGuardarEnvio = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPaqQuitar = new System.Windows.Forms.Button();
            this.dgvPaquetes = new System.Windows.Forms.DataGridView();
            this.btnPaqAgregar = new System.Windows.Forms.Button();
            this.chkPaqFragil = new System.Windows.Forms.CheckBox();
            this.nudPaqValor = new System.Windows.Forms.NumericUpDown();
            this.nudPaqPeso = new System.Windows.Forms.NumericUpDown();
            this.txtPaqDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpiarEnvio = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblCostoEnvio = new System.Windows.Forms.Label();
            this.lblPesoTotal = new System.Windows.Forms.Label();
            this.cboEnvSucOrigen = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEnvObservaciones = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.nudEnvContraEntrega = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.cboEnvServicio = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cboEnvSucDestino = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cboEnvDestinatario = new System.Windows.Forms.ComboBox();
            this.cboEnvRemitente = new System.Windows.Forms.ComboBox();
            this.tabEnviosRegistrados = new System.Windows.Forms.TabPage();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnvios)).BeginInit();
            this.tabEnvios.SuspendLayout();
            this.tabNuevoEnvio.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaquetes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaqValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaqPeso)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnvContraEntrega)).BeginInit();
            this.tabEnviosRegistrados.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvEnvios);
            this.groupBox2.Controls.Add(this.btnCancelarEnvio);
            this.groupBox2.Controls.Add(this.txtEnvBuscar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(28, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(740, 373);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Envíos registrados";
            // 
            // dgvEnvios
            // 
            this.dgvEnvios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnvios.Location = new System.Drawing.Point(23, 77);
            this.dgvEnvios.Name = "dgvEnvios";
            this.dgvEnvios.Size = new System.Drawing.Size(376, 276);
            this.dgvEnvios.TabIndex = 3;
            this.dgvEnvios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEnvios_CellClick);
            // 
            // btnCancelarEnvio
            // 
            this.btnCancelarEnvio.Location = new System.Drawing.Point(294, 34);
            this.btnCancelarEnvio.Name = "btnCancelarEnvio";
            this.btnCancelarEnvio.Size = new System.Drawing.Size(105, 25);
            this.btnCancelarEnvio.TabIndex = 2;
            this.btnCancelarEnvio.Text = "Cancelar envío";
            this.btnCancelarEnvio.UseVisualStyleBackColor = true;
            this.btnCancelarEnvio.Click += new System.EventHandler(this.btnCancelarEnvio_Click);
            // 
            // txtEnvBuscar
            // 
            this.txtEnvBuscar.Location = new System.Drawing.Point(69, 39);
            this.txtEnvBuscar.Name = "txtEnvBuscar";
            this.txtEnvBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtEnvBuscar.TabIndex = 1;
            this.txtEnvBuscar.TextChanged += new System.EventHandler(this.txtEnvBuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar:";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(793, 476);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 21;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // tabEnvios
            // 
            this.tabEnvios.Controls.Add(this.tabNuevoEnvio);
            this.tabEnvios.Controls.Add(this.tabEnviosRegistrados);
            this.tabEnvios.Location = new System.Drawing.Point(12, 12);
            this.tabEnvios.Name = "tabEnvios";
            this.tabEnvios.SelectedIndex = 0;
            this.tabEnvios.Size = new System.Drawing.Size(860, 429);
            this.tabEnvios.TabIndex = 22;
            // 
            // tabNuevoEnvio
            // 
            this.tabNuevoEnvio.Controls.Add(this.btnGuardarEnvio);
            this.tabNuevoEnvio.Controls.Add(this.groupBox1);
            this.tabNuevoEnvio.Controls.Add(this.btnLimpiarEnvio);
            this.tabNuevoEnvio.Controls.Add(this.groupBox4);
            this.tabNuevoEnvio.Location = new System.Drawing.Point(4, 22);
            this.tabNuevoEnvio.Name = "tabNuevoEnvio";
            this.tabNuevoEnvio.Padding = new System.Windows.Forms.Padding(3);
            this.tabNuevoEnvio.Size = new System.Drawing.Size(852, 403);
            this.tabNuevoEnvio.TabIndex = 0;
            this.tabNuevoEnvio.Text = "Nuevo envío";
            this.tabNuevoEnvio.UseVisualStyleBackColor = true;
            // 
            // btnGuardarEnvio
            // 
            this.btnGuardarEnvio.Location = new System.Drawing.Point(15, 331);
            this.btnGuardarEnvio.Name = "btnGuardarEnvio";
            this.btnGuardarEnvio.Size = new System.Drawing.Size(135, 23);
            this.btnGuardarEnvio.TabIndex = 10;
            this.btnGuardarEnvio.Text = "Guardar envío";
            this.btnGuardarEnvio.UseVisualStyleBackColor = true;
            this.btnGuardarEnvio.Click += new System.EventHandler(this.btnGuardarEnvio_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPaqQuitar);
            this.groupBox1.Controls.Add(this.dgvPaquetes);
            this.groupBox1.Controls.Add(this.btnPaqAgregar);
            this.groupBox1.Controls.Add(this.chkPaqFragil);
            this.groupBox1.Controls.Add(this.nudPaqValor);
            this.groupBox1.Controls.Add(this.nudPaqPeso);
            this.groupBox1.Controls.Add(this.txtPaqDescripcion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(463, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 316);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paquetes";
            // 
            // btnPaqQuitar
            // 
            this.btnPaqQuitar.Location = new System.Drawing.Point(207, 144);
            this.btnPaqQuitar.Name = "btnPaqQuitar";
            this.btnPaqQuitar.Size = new System.Drawing.Size(126, 23);
            this.btnPaqQuitar.TabIndex = 9;
            this.btnPaqQuitar.Text = "Quitar paquete";
            this.btnPaqQuitar.UseVisualStyleBackColor = true;
            this.btnPaqQuitar.Click += new System.EventHandler(this.btnPaqQuitar_Click);
            // 
            // dgvPaquetes
            // 
            this.dgvPaquetes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaquetes.Location = new System.Drawing.Point(18, 183);
            this.dgvPaquetes.Name = "dgvPaquetes";
            this.dgvPaquetes.Size = new System.Drawing.Size(348, 127);
            this.dgvPaquetes.TabIndex = 8;
            // 
            // btnPaqAgregar
            // 
            this.btnPaqAgregar.Location = new System.Drawing.Point(18, 144);
            this.btnPaqAgregar.Name = "btnPaqAgregar";
            this.btnPaqAgregar.Size = new System.Drawing.Size(139, 23);
            this.btnPaqAgregar.TabIndex = 7;
            this.btnPaqAgregar.Text = "Agregar paquete";
            this.btnPaqAgregar.UseVisualStyleBackColor = true;
            this.btnPaqAgregar.Click += new System.EventHandler(this.btnPaqAgregar_Click);
            // 
            // chkPaqFragil
            // 
            this.chkPaqFragil.AutoSize = true;
            this.chkPaqFragil.Checked = true;
            this.chkPaqFragil.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPaqFragil.Location = new System.Drawing.Point(247, 105);
            this.chkPaqFragil.Name = "chkPaqFragil";
            this.chkPaqFragil.Size = new System.Drawing.Size(51, 17);
            this.chkPaqFragil.TabIndex = 6;
            this.chkPaqFragil.Text = "Frágil";
            this.chkPaqFragil.UseVisualStyleBackColor = true;
            // 
            // nudPaqValor
            // 
            this.nudPaqValor.Location = new System.Drawing.Point(87, 103);
            this.nudPaqValor.Name = "nudPaqValor";
            this.nudPaqValor.Size = new System.Drawing.Size(120, 20);
            this.nudPaqValor.TabIndex = 5;
            // 
            // nudPaqPeso
            // 
            this.nudPaqPeso.Location = new System.Drawing.Point(87, 66);
            this.nudPaqPeso.Name = "nudPaqPeso";
            this.nudPaqPeso.Size = new System.Drawing.Size(120, 20);
            this.nudPaqPeso.TabIndex = 4;
            // 
            // txtPaqDescripcion
            // 
            this.txtPaqDescripcion.Location = new System.Drawing.Point(87, 30);
            this.txtPaqDescripcion.Name = "txtPaqDescripcion";
            this.txtPaqDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtPaqDescripcion.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Valor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Peso:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descripción:";
            // 
            // btnLimpiarEnvio
            // 
            this.btnLimpiarEnvio.Location = new System.Drawing.Point(177, 331);
            this.btnLimpiarEnvio.Name = "btnLimpiarEnvio";
            this.btnLimpiarEnvio.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarEnvio.TabIndex = 11;
            this.btnLimpiarEnvio.Text = "Limpiar";
            this.btnLimpiarEnvio.UseVisualStyleBackColor = true;
            this.btnLimpiarEnvio.Click += new System.EventHandler(this.btnLimpiarEnvio_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblCostoEnvio);
            this.groupBox4.Controls.Add(this.lblPesoTotal);
            this.groupBox4.Controls.Add(this.cboEnvSucOrigen);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txtEnvObservaciones);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.nudEnvContraEntrega);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.cboEnvServicio);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.cboEnvSucDestino);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.cboEnvDestinatario);
            this.groupBox4.Controls.Add(this.cboEnvRemitente);
            this.groupBox4.Location = new System.Drawing.Point(15, 9);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(423, 316);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos del envío";
            // 
            // lblCostoEnvio
            // 
            this.lblCostoEnvio.AutoSize = true;
            this.lblCostoEnvio.Location = new System.Drawing.Point(193, 246);
            this.lblCostoEnvio.Name = "lblCostoEnvio";
            this.lblCostoEnvio.Size = new System.Drawing.Size(83, 13);
            this.lblCostoEnvio.TabIndex = 16;
            this.lblCostoEnvio.Text = "Costo de envío:";
            // 
            // lblPesoTotal
            // 
            this.lblPesoTotal.AutoSize = true;
            this.lblPesoTotal.Location = new System.Drawing.Point(22, 246);
            this.lblPesoTotal.Name = "lblPesoTotal";
            this.lblPesoTotal.Size = new System.Drawing.Size(57, 13);
            this.lblPesoTotal.TabIndex = 15;
            this.lblPesoTotal.Text = "Peso total:";
            // 
            // cboEnvSucOrigen
            // 
            this.cboEnvSucOrigen.FormattingEnabled = true;
            this.cboEnvSucOrigen.Location = new System.Drawing.Point(92, 58);
            this.cboEnvSucOrigen.Name = "cboEnvSucOrigen";
            this.cboEnvSucOrigen.Size = new System.Drawing.Size(121, 21);
            this.cboEnvSucOrigen.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Remitente:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(222, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Destinatario:";
            // 
            // txtEnvObservaciones
            // 
            this.txtEnvObservaciones.Location = new System.Drawing.Point(108, 180);
            this.txtEnvObservaciones.Name = "txtEnvObservaciones";
            this.txtEnvObservaciones.Size = new System.Drawing.Size(100, 20);
            this.txtEnvObservaciones.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Suc. origen:";
            // 
            // nudEnvContraEntrega
            // 
            this.nudEnvContraEntrega.Location = new System.Drawing.Point(108, 142);
            this.nudEnvContraEntrega.Name = "nudEnvContraEntrega";
            this.nudEnvContraEntrega.Size = new System.Drawing.Size(120, 20);
            this.nudEnvContraEntrega.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(224, 61);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Suc. destino:";
            // 
            // cboEnvServicio
            // 
            this.cboEnvServicio.FormattingEnabled = true;
            this.cboEnvServicio.Location = new System.Drawing.Point(92, 100);
            this.cboEnvServicio.Name = "cboEnvServicio";
            this.cboEnvServicio.Size = new System.Drawing.Size(121, 21);
            this.cboEnvServicio.TabIndex = 12;
            this.cboEnvServicio.SelectedIndexChanged += new System.EventHandler(this.cboEnvServicio_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(22, 103);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "Servicio:";
            // 
            // cboEnvSucDestino
            // 
            this.cboEnvSucDestino.FormattingEnabled = true;
            this.cboEnvSucDestino.Location = new System.Drawing.Point(294, 58);
            this.cboEnvSucDestino.Name = "cboEnvSucDestino";
            this.cboEnvSucDestino.Size = new System.Drawing.Size(121, 21);
            this.cboEnvSucDestino.TabIndex = 11;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(22, 144);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 13);
            this.label17.TabIndex = 6;
            this.label17.Text = "Contra entrega:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(22, 183);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(81, 13);
            this.label18.TabIndex = 7;
            this.label18.Text = "Observaciones:";
            // 
            // cboEnvDestinatario
            // 
            this.cboEnvDestinatario.FormattingEnabled = true;
            this.cboEnvDestinatario.Location = new System.Drawing.Point(294, 18);
            this.cboEnvDestinatario.Name = "cboEnvDestinatario";
            this.cboEnvDestinatario.Size = new System.Drawing.Size(121, 21);
            this.cboEnvDestinatario.TabIndex = 9;
            this.cboEnvDestinatario.SelectedIndexChanged += new System.EventHandler(this.cboEnvDestinatario_SelectedIndexChanged);
            // 
            // cboEnvRemitente
            // 
            this.cboEnvRemitente.FormattingEnabled = true;
            this.cboEnvRemitente.Location = new System.Drawing.Point(92, 18);
            this.cboEnvRemitente.Name = "cboEnvRemitente";
            this.cboEnvRemitente.Size = new System.Drawing.Size(121, 21);
            this.cboEnvRemitente.TabIndex = 8;
            // 
            // tabEnviosRegistrados
            // 
            this.tabEnviosRegistrados.Controls.Add(this.groupBox2);
            this.tabEnviosRegistrados.Location = new System.Drawing.Point(4, 22);
            this.tabEnviosRegistrados.Name = "tabEnviosRegistrados";
            this.tabEnviosRegistrados.Padding = new System.Windows.Forms.Padding(3);
            this.tabEnviosRegistrados.Size = new System.Drawing.Size(852, 403);
            this.tabEnviosRegistrados.TabIndex = 1;
            this.tabEnviosRegistrados.Text = "Envíos registrados";
            this.tabEnviosRegistrados.UseVisualStyleBackColor = true;
            // 
            // frmEnvios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.tabEnvios);
            this.Controls.Add(this.btnVolver);
            this.Name = "frmEnvios";
            this.Text = "frmEnvios";
            this.Load += new System.EventHandler(this.frmEnvios_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnvios)).EndInit();
            this.tabEnvios.ResumeLayout(false);
            this.tabNuevoEnvio.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaquetes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaqValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaqPeso)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnvContraEntrega)).EndInit();
            this.tabEnviosRegistrados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancelarEnvio;
        private System.Windows.Forms.TextBox txtEnvBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEnvios;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TabControl tabEnvios;
        private System.Windows.Forms.TabPage tabNuevoEnvio;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cboEnvSucOrigen;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEnvObservaciones;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown nudEnvContraEntrega;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cboEnvServicio;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cboEnvSucDestino;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cboEnvDestinatario;
        private System.Windows.Forms.ComboBox cboEnvRemitente;
        private System.Windows.Forms.TabPage tabEnviosRegistrados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPaqAgregar;
        private System.Windows.Forms.CheckBox chkPaqFragil;
        private System.Windows.Forms.NumericUpDown nudPaqValor;
        private System.Windows.Forms.NumericUpDown nudPaqPeso;
        private System.Windows.Forms.TextBox txtPaqDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPaqQuitar;
        private System.Windows.Forms.DataGridView dgvPaquetes;
        private System.Windows.Forms.Button btnLimpiarEnvio;
        private System.Windows.Forms.Button btnGuardarEnvio;
        private System.Windows.Forms.Label lblCostoEnvio;
        private System.Windows.Forms.Label lblPesoTotal;
    }
}