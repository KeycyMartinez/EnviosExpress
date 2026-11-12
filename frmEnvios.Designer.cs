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
            this.groupBox2.Size = new System.Drawing.Size(1020, 373);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Envíos registrados";
            // 
            // dgvEnvios
            // 
            this.dgvEnvios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnvios.Location = new System.Drawing.Point(24, 77);
            this.dgvEnvios.Name = "dgvEnvios";
            this.dgvEnvios.Size = new System.Drawing.Size(839, 249);
            this.dgvEnvios.TabIndex = 3;
            this.dgvEnvios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEnvios_CellClick);
            // 
            // btnCancelarEnvio
            // 
            this.btnCancelarEnvio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnCancelarEnvio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarEnvio.ForeColor = System.Drawing.Color.White;
            this.btnCancelarEnvio.Location = new System.Drawing.Point(24, 332);
            this.btnCancelarEnvio.Name = "btnCancelarEnvio";
            this.btnCancelarEnvio.Size = new System.Drawing.Size(125, 35);
            this.btnCancelarEnvio.TabIndex = 2;
            this.btnCancelarEnvio.Text = "Cancelar envío";
            this.btnCancelarEnvio.UseVisualStyleBackColor = true;
            this.btnCancelarEnvio.Click += new System.EventHandler(this.btnCancelarEnvio_Click);
            // 
            // txtEnvBuscar
            // 
            this.txtEnvBuscar.Location = new System.Drawing.Point(80, 34);
            this.txtEnvBuscar.Name = "txtEnvBuscar";
            this.txtEnvBuscar.Size = new System.Drawing.Size(176, 25);
            this.txtEnvBuscar.TabIndex = 1;
            this.txtEnvBuscar.TextChanged += new System.EventHandler(this.txtEnvBuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar:";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Location = new System.Drawing.Point(982, 470);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(90, 29);
            this.btnVolver.TabIndex = 21;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // tabEnvios
            // 
            this.tabEnvios.Controls.Add(this.tabNuevoEnvio);
            this.tabEnvios.Controls.Add(this.tabEnviosRegistrados);
            this.tabEnvios.Location = new System.Drawing.Point(12, 12);
            this.tabEnvios.Name = "tabEnvios";
            this.tabEnvios.SelectedIndex = 0;
            this.tabEnvios.Size = new System.Drawing.Size(1060, 436);
            this.tabEnvios.TabIndex = 22;
            // 
            // tabNuevoEnvio
            // 
            this.tabNuevoEnvio.Controls.Add(this.btnGuardarEnvio);
            this.tabNuevoEnvio.Controls.Add(this.groupBox1);
            this.tabNuevoEnvio.Controls.Add(this.btnLimpiarEnvio);
            this.tabNuevoEnvio.Controls.Add(this.groupBox4);
            this.tabNuevoEnvio.Location = new System.Drawing.Point(4, 26);
            this.tabNuevoEnvio.Name = "tabNuevoEnvio";
            this.tabNuevoEnvio.Padding = new System.Windows.Forms.Padding(3);
            this.tabNuevoEnvio.Size = new System.Drawing.Size(1052, 406);
            this.tabNuevoEnvio.TabIndex = 0;
            this.tabNuevoEnvio.Text = "Nuevo envío";
            this.tabNuevoEnvio.UseVisualStyleBackColor = true;
            // 
            // btnGuardarEnvio
            // 
            this.btnGuardarEnvio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnGuardarEnvio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarEnvio.ForeColor = System.Drawing.Color.White;
            this.btnGuardarEnvio.Location = new System.Drawing.Point(15, 345);
            this.btnGuardarEnvio.Name = "btnGuardarEnvio";
            this.btnGuardarEnvio.Size = new System.Drawing.Size(145, 39);
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
            this.btnPaqQuitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnPaqQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaqQuitar.ForeColor = System.Drawing.Color.White;
            this.btnPaqQuitar.Location = new System.Drawing.Point(207, 144);
            this.btnPaqQuitar.Name = "btnPaqQuitar";
            this.btnPaqQuitar.Size = new System.Drawing.Size(140, 33);
            this.btnPaqQuitar.TabIndex = 9;
            this.btnPaqQuitar.Text = "Quitar paquete";
            this.btnPaqQuitar.UseVisualStyleBackColor = true;
            this.btnPaqQuitar.Click += new System.EventHandler(this.btnPaqQuitar_Click);
            // 
            // dgvPaquetes
            // 
            this.dgvPaquetes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPaquetes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaquetes.Location = new System.Drawing.Point(18, 194);
            this.dgvPaquetes.Name = "dgvPaquetes";
            this.dgvPaquetes.RowHeadersVisible = false;
            this.dgvPaquetes.Size = new System.Drawing.Size(329, 104);
            this.dgvPaquetes.TabIndex = 8;
            // 
            // btnPaqAgregar
            // 
            this.btnPaqAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnPaqAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaqAgregar.ForeColor = System.Drawing.Color.White;
            this.btnPaqAgregar.Location = new System.Drawing.Point(19, 144);
            this.btnPaqAgregar.Name = "btnPaqAgregar";
            this.btnPaqAgregar.Size = new System.Drawing.Size(145, 33);
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
            this.chkPaqFragil.Location = new System.Drawing.Point(286, 105);
            this.chkPaqFragil.Name = "chkPaqFragil";
            this.chkPaqFragil.Size = new System.Drawing.Size(61, 23);
            this.chkPaqFragil.TabIndex = 6;
            this.chkPaqFragil.Text = "Frágil";
            this.chkPaqFragil.UseVisualStyleBackColor = true;
            // 
            // nudPaqValor
            // 
            this.nudPaqValor.Location = new System.Drawing.Point(103, 105);
            this.nudPaqValor.Name = "nudPaqValor";
            this.nudPaqValor.Size = new System.Drawing.Size(120, 25);
            this.nudPaqValor.TabIndex = 5;
            // 
            // nudPaqPeso
            // 
            this.nudPaqPeso.Location = new System.Drawing.Point(103, 66);
            this.nudPaqPeso.Name = "nudPaqPeso";
            this.nudPaqPeso.Size = new System.Drawing.Size(120, 25);
            this.nudPaqPeso.TabIndex = 4;
            // 
            // txtPaqDescripcion
            // 
            this.txtPaqDescripcion.Location = new System.Drawing.Point(103, 30);
            this.txtPaqDescripcion.Name = "txtPaqDescripcion";
            this.txtPaqDescripcion.Size = new System.Drawing.Size(221, 25);
            this.txtPaqDescripcion.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Valor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Peso:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Descripción:";
            // 
            // btnLimpiarEnvio
            // 
            this.btnLimpiarEnvio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnLimpiarEnvio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarEnvio.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarEnvio.Location = new System.Drawing.Point(176, 345);
            this.btnLimpiarEnvio.Name = "btnLimpiarEnvio";
            this.btnLimpiarEnvio.Size = new System.Drawing.Size(90, 39);
            this.btnLimpiarEnvio.TabIndex = 11;
            this.btnLimpiarEnvio.Text = "Limpiar";
            this.btnLimpiarEnvio.UseVisualStyleBackColor = false;
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
            this.groupBox4.Size = new System.Drawing.Size(429, 316);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos del envío";
            // 
            // lblCostoEnvio
            // 
            this.lblCostoEnvio.AutoSize = true;
            this.lblCostoEnvio.Location = new System.Drawing.Point(9, 279);
            this.lblCostoEnvio.Name = "lblCostoEnvio";
            this.lblCostoEnvio.Size = new System.Drawing.Size(104, 19);
            this.lblCostoEnvio.TabIndex = 16;
            this.lblCostoEnvio.Text = "Costo de envío:";
            // 
            // lblPesoTotal
            // 
            this.lblPesoTotal.AutoSize = true;
            this.lblPesoTotal.Location = new System.Drawing.Point(8, 248);
            this.lblPesoTotal.Name = "lblPesoTotal";
            this.lblPesoTotal.Size = new System.Drawing.Size(72, 19);
            this.lblPesoTotal.TabIndex = 15;
            this.lblPesoTotal.Text = "Peso total:";
            // 
            // cboEnvSucOrigen
            // 
            this.cboEnvSucOrigen.FormattingEnabled = true;
            this.cboEnvSucOrigen.Location = new System.Drawing.Point(88, 66);
            this.cboEnvSucOrigen.Name = "cboEnvSucOrigen";
            this.cboEnvSucOrigen.Size = new System.Drawing.Size(121, 25);
            this.cboEnvSucOrigen.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 19);
            this.label12.TabIndex = 1;
            this.label12.Text = "Remitente:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(215, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 19);
            this.label13.TabIndex = 2;
            this.label13.Text = "Destinatario:";
            // 
            // txtEnvObservaciones
            // 
            this.txtEnvObservaciones.Location = new System.Drawing.Point(119, 194);
            this.txtEnvObservaciones.Name = "txtEnvObservaciones";
            this.txtEnvObservaciones.Size = new System.Drawing.Size(209, 25);
            this.txtEnvObservaciones.TabIndex = 14;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 69);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 19);
            this.label14.TabIndex = 3;
            this.label14.Text = "Suc. origen:";
            // 
            // nudEnvContraEntrega
            // 
            this.nudEnvContraEntrega.Location = new System.Drawing.Point(119, 152);
            this.nudEnvContraEntrega.Name = "nudEnvContraEntrega";
            this.nudEnvContraEntrega.Size = new System.Drawing.Size(119, 25);
            this.nudEnvContraEntrega.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(216, 66);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 19);
            this.label15.TabIndex = 4;
            this.label15.Text = "Suc. destino:";
            // 
            // cboEnvServicio
            // 
            this.cboEnvServicio.FormattingEnabled = true;
            this.cboEnvServicio.Location = new System.Drawing.Point(88, 107);
            this.cboEnvServicio.Name = "cboEnvServicio";
            this.cboEnvServicio.Size = new System.Drawing.Size(121, 25);
            this.cboEnvServicio.TabIndex = 12;
            this.cboEnvServicio.SelectedIndexChanged += new System.EventHandler(this.cboEnvServicio_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 107);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 19);
            this.label16.TabIndex = 5;
            this.label16.Text = "Servicio:";
            // 
            // cboEnvSucDestino
            // 
            this.cboEnvSucDestino.FormattingEnabled = true;
            this.cboEnvSucDestino.Location = new System.Drawing.Point(302, 65);
            this.cboEnvSucDestino.Name = "cboEnvSucDestino";
            this.cboEnvSucDestino.Size = new System.Drawing.Size(121, 25);
            this.cboEnvSucDestino.TabIndex = 11;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 152);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(105, 19);
            this.label17.TabIndex = 6;
            this.label17.Text = "Contra entrega:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 194);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(101, 19);
            this.label18.TabIndex = 7;
            this.label18.Text = "Observaciones:";
            // 
            // cboEnvDestinatario
            // 
            this.cboEnvDestinatario.FormattingEnabled = true;
            this.cboEnvDestinatario.Location = new System.Drawing.Point(302, 30);
            this.cboEnvDestinatario.Name = "cboEnvDestinatario";
            this.cboEnvDestinatario.Size = new System.Drawing.Size(121, 25);
            this.cboEnvDestinatario.TabIndex = 9;
            this.cboEnvDestinatario.SelectedIndexChanged += new System.EventHandler(this.cboEnvDestinatario_SelectedIndexChanged);
            // 
            // cboEnvRemitente
            // 
            this.cboEnvRemitente.FormattingEnabled = true;
            this.cboEnvRemitente.Location = new System.Drawing.Point(88, 30);
            this.cboEnvRemitente.Name = "cboEnvRemitente";
            this.cboEnvRemitente.Size = new System.Drawing.Size(121, 25);
            this.cboEnvRemitente.TabIndex = 8;
            // 
            // tabEnviosRegistrados
            // 
            this.tabEnviosRegistrados.Controls.Add(this.groupBox2);
            this.tabEnviosRegistrados.Location = new System.Drawing.Point(4, 26);
            this.tabEnviosRegistrados.Name = "tabEnviosRegistrados";
            this.tabEnviosRegistrados.Padding = new System.Windows.Forms.Padding(3);
            this.tabEnviosRegistrados.Size = new System.Drawing.Size(1052, 406);
            this.tabEnviosRegistrados.TabIndex = 1;
            this.tabEnviosRegistrados.Text = "Envíos registrados";
            this.tabEnviosRegistrados.UseVisualStyleBackColor = true;
            // 
            // frmEnvios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 511);
            this.Controls.Add(this.tabEnvios);
            this.Controls.Add(this.btnVolver);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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