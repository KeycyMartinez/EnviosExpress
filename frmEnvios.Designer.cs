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
            this.grpEnviosRegistrados = new System.Windows.Forms.GroupBox();
            this.dgvEnvios = new System.Windows.Forms.DataGridView();
            this.btnCancelarEnvio = new System.Windows.Forms.Button();
            this.txtEnvBuscar = new System.Windows.Forms.TextBox();
            this.lblEnvBuscar = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.tabEnvios = new System.Windows.Forms.TabControl();
            this.tabNuevoEnvio = new System.Windows.Forms.TabPage();
            this.btnGuardarEnvio = new System.Windows.Forms.Button();
            this.grpPaquetes = new System.Windows.Forms.GroupBox();
            this.btnPaqQuitar = new System.Windows.Forms.Button();
            this.dgvPaquetes = new System.Windows.Forms.DataGridView();
            this.btnPaqAgregar = new System.Windows.Forms.Button();
            this.chkPaqFragil = new System.Windows.Forms.CheckBox();
            this.nudPaqValor = new System.Windows.Forms.NumericUpDown();
            this.nudPaqPeso = new System.Windows.Forms.NumericUpDown();
            this.txtPaqDescripcion = new System.Windows.Forms.TextBox();
            this.lblPaqValor = new System.Windows.Forms.Label();
            this.lblPaqPeso = new System.Windows.Forms.Label();
            this.lblPaqDescripcion = new System.Windows.Forms.Label();
            this.btnLimpiarEnvio = new System.Windows.Forms.Button();
            this.grpDatosEnvio = new System.Windows.Forms.GroupBox();
            this.lblCostoEnvio = new System.Windows.Forms.Label();
            this.lblPesoTotal = new System.Windows.Forms.Label();
            this.cboEnvSucOrigen = new System.Windows.Forms.ComboBox();
            this.lblEnvRemitente = new System.Windows.Forms.Label();
            this.lblEnvDestinatario = new System.Windows.Forms.Label();
            this.txtEnvObservaciones = new System.Windows.Forms.TextBox();
            this.lblEnvSucOrigen = new System.Windows.Forms.Label();
            this.nudEnvContraEntrega = new System.Windows.Forms.NumericUpDown();
            this.lblEnvContraEntrega = new System.Windows.Forms.Label();
            this.cboEnvServicio = new System.Windows.Forms.ComboBox();
            this.lblEnvServicio = new System.Windows.Forms.Label();
            this.cboEnvSucDestino = new System.Windows.Forms.ComboBox();
            this.lblEnvSucDestino = new System.Windows.Forms.Label();
            this.lblEnvObservaciones = new System.Windows.Forms.Label();
            this.cboEnvDestinatario = new System.Windows.Forms.ComboBox();
            this.cboEnvRemitente = new System.Windows.Forms.ComboBox();
            this.tabEnviosRegistrados = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.grpEnviosRegistrados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnvios)).BeginInit();
            this.tabEnvios.SuspendLayout();
            this.tabNuevoEnvio.SuspendLayout();
            this.grpPaquetes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaquetes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaqValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaqPeso)).BeginInit();
            this.grpDatosEnvio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnvContraEntrega)).BeginInit();
            this.tabEnviosRegistrados.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEnviosRegistrados
            // 
            this.grpEnviosRegistrados.Controls.Add(this.dgvEnvios);
            this.grpEnviosRegistrados.Controls.Add(this.btnCancelarEnvio);
            this.grpEnviosRegistrados.Controls.Add(this.txtEnvBuscar);
            this.grpEnviosRegistrados.Controls.Add(this.lblEnvBuscar);
            this.grpEnviosRegistrados.Location = new System.Drawing.Point(28, 27);
            this.grpEnviosRegistrados.Name = "grpEnviosRegistrados";
            this.grpEnviosRegistrados.Size = new System.Drawing.Size(1020, 373);
            this.grpEnviosRegistrados.TabIndex = 19;
            this.grpEnviosRegistrados.TabStop = false;
            this.grpEnviosRegistrados.Text = "Envíos registrados";
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
            // lblEnvBuscar
            // 
            this.lblEnvBuscar.AutoSize = true;
            this.lblEnvBuscar.Location = new System.Drawing.Point(22, 34);
            this.lblEnvBuscar.Name = "lblEnvBuscar";
            this.lblEnvBuscar.Size = new System.Drawing.Size(52, 19);
            this.lblEnvBuscar.TabIndex = 0;
            this.lblEnvBuscar.Text = "Buscar:";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Location = new System.Drawing.Point(978, 511);
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
            this.tabEnvios.Location = new System.Drawing.Point(12, 50);
            this.tabEnvios.Name = "tabEnvios";
            this.tabEnvios.SelectedIndex = 0;
            this.tabEnvios.Size = new System.Drawing.Size(1060, 436);
            this.tabEnvios.TabIndex = 22;
            // 
            // tabNuevoEnvio
            // 
            this.tabNuevoEnvio.Controls.Add(this.btnGuardarEnvio);
            this.tabNuevoEnvio.Controls.Add(this.grpPaquetes);
            this.tabNuevoEnvio.Controls.Add(this.btnLimpiarEnvio);
            this.tabNuevoEnvio.Controls.Add(this.grpDatosEnvio);
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
            // grpPaquetes
            // 
            this.grpPaquetes.Controls.Add(this.btnPaqQuitar);
            this.grpPaquetes.Controls.Add(this.dgvPaquetes);
            this.grpPaquetes.Controls.Add(this.btnPaqAgregar);
            this.grpPaquetes.Controls.Add(this.chkPaqFragil);
            this.grpPaquetes.Controls.Add(this.nudPaqValor);
            this.grpPaquetes.Controls.Add(this.nudPaqPeso);
            this.grpPaquetes.Controls.Add(this.txtPaqDescripcion);
            this.grpPaquetes.Controls.Add(this.lblPaqValor);
            this.grpPaquetes.Controls.Add(this.lblPaqPeso);
            this.grpPaquetes.Controls.Add(this.lblPaqDescripcion);
            this.grpPaquetes.Location = new System.Drawing.Point(463, 9);
            this.grpPaquetes.Name = "grpPaquetes";
            this.grpPaquetes.Size = new System.Drawing.Size(372, 316);
            this.grpPaquetes.TabIndex = 22;
            this.grpPaquetes.TabStop = false;
            this.grpPaquetes.Text = "Paquetes";
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
            // lblPaqValor
            // 
            this.lblPaqValor.AutoSize = true;
            this.lblPaqValor.Location = new System.Drawing.Point(15, 103);
            this.lblPaqValor.Name = "lblPaqValor";
            this.lblPaqValor.Size = new System.Drawing.Size(43, 19);
            this.lblPaqValor.TabIndex = 2;
            this.lblPaqValor.Text = "Valor:";
            // 
            // lblPaqPeso
            // 
            this.lblPaqPeso.AutoSize = true;
            this.lblPaqPeso.Location = new System.Drawing.Point(15, 66);
            this.lblPaqPeso.Name = "lblPaqPeso";
            this.lblPaqPeso.Size = new System.Drawing.Size(40, 19);
            this.lblPaqPeso.TabIndex = 1;
            this.lblPaqPeso.Text = "Peso:";
            // 
            // lblPaqDescripcion
            // 
            this.lblPaqDescripcion.AutoSize = true;
            this.lblPaqDescripcion.Location = new System.Drawing.Point(15, 33);
            this.lblPaqDescripcion.Name = "lblPaqDescripcion";
            this.lblPaqDescripcion.Size = new System.Drawing.Size(82, 19);
            this.lblPaqDescripcion.TabIndex = 0;
            this.lblPaqDescripcion.Text = "Descripción:";
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
            // grpDatosEnvio
            // 
            this.grpDatosEnvio.Controls.Add(this.lblCostoEnvio);
            this.grpDatosEnvio.Controls.Add(this.lblPesoTotal);
            this.grpDatosEnvio.Controls.Add(this.cboEnvSucOrigen);
            this.grpDatosEnvio.Controls.Add(this.lblEnvRemitente);
            this.grpDatosEnvio.Controls.Add(this.lblEnvDestinatario);
            this.grpDatosEnvio.Controls.Add(this.txtEnvObservaciones);
            this.grpDatosEnvio.Controls.Add(this.lblEnvSucOrigen);
            this.grpDatosEnvio.Controls.Add(this.nudEnvContraEntrega);
            this.grpDatosEnvio.Controls.Add(this.lblEnvContraEntrega);
            this.grpDatosEnvio.Controls.Add(this.cboEnvServicio);
            this.grpDatosEnvio.Controls.Add(this.lblEnvServicio);
            this.grpDatosEnvio.Controls.Add(this.cboEnvSucDestino);
            this.grpDatosEnvio.Controls.Add(this.lblEnvSucDestino);
            this.grpDatosEnvio.Controls.Add(this.lblEnvObservaciones);
            this.grpDatosEnvio.Controls.Add(this.cboEnvDestinatario);
            this.grpDatosEnvio.Controls.Add(this.cboEnvRemitente);
            this.grpDatosEnvio.Location = new System.Drawing.Point(15, 9);
            this.grpDatosEnvio.Name = "grpDatosEnvio";
            this.grpDatosEnvio.Size = new System.Drawing.Size(429, 316);
            this.grpDatosEnvio.TabIndex = 21;
            this.grpDatosEnvio.TabStop = false;
            this.grpDatosEnvio.Text = "Datos del envío";
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
            // lblEnvRemitente
            // 
            this.lblEnvRemitente.AutoSize = true;
            this.lblEnvRemitente.Location = new System.Drawing.Point(8, 30);
            this.lblEnvRemitente.Name = "lblEnvRemitente";
            this.lblEnvRemitente.Size = new System.Drawing.Size(74, 19);
            this.lblEnvRemitente.TabIndex = 1;
            this.lblEnvRemitente.Text = "Remitente:";
            // 
            // lblEnvDestinatario
            // 
            this.lblEnvDestinatario.AutoSize = true;
            this.lblEnvDestinatario.Location = new System.Drawing.Point(215, 30);
            this.lblEnvDestinatario.Name = "lblEnvDestinatario";
            this.lblEnvDestinatario.Size = new System.Drawing.Size(86, 19);
            this.lblEnvDestinatario.TabIndex = 2;
            this.lblEnvDestinatario.Text = "Destinatario:";
            // 
            // txtEnvObservaciones
            // 
            this.txtEnvObservaciones.Location = new System.Drawing.Point(119, 194);
            this.txtEnvObservaciones.Name = "txtEnvObservaciones";
            this.txtEnvObservaciones.Size = new System.Drawing.Size(209, 25);
            this.txtEnvObservaciones.TabIndex = 14;
            // 
            // lblEnvSucOrigen
            // 
            this.lblEnvSucOrigen.AutoSize = true;
            this.lblEnvSucOrigen.Location = new System.Drawing.Point(7, 69);
            this.lblEnvSucOrigen.Name = "lblEnvSucOrigen";
            this.lblEnvSucOrigen.Size = new System.Drawing.Size(79, 19);
            this.lblEnvSucOrigen.TabIndex = 3;
            this.lblEnvSucOrigen.Text = "Suc. origen:";
            // 
            // nudEnvContraEntrega
            // 
            this.nudEnvContraEntrega.Location = new System.Drawing.Point(119, 150);
            this.nudEnvContraEntrega.Name = "nudEnvContraEntrega";
            this.nudEnvContraEntrega.Size = new System.Drawing.Size(119, 25);
            this.nudEnvContraEntrega.TabIndex = 13;
            // 
            // lblEnvContraEntrega
            // 
            this.lblEnvContraEntrega.AutoSize = true;
            this.lblEnvContraEntrega.Location = new System.Drawing.Point(9, 152);
            this.lblEnvContraEntrega.Name = "lblEnvContraEntrega";
            this.lblEnvContraEntrega.Size = new System.Drawing.Size(105, 19);
            this.lblEnvContraEntrega.TabIndex = 4;
            this.lblEnvContraEntrega.Text = "Contra entrega:";
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
            // lblEnvServicio
            // 
            this.lblEnvServicio.AutoSize = true;
            this.lblEnvServicio.Location = new System.Drawing.Point(8, 107);
            this.lblEnvServicio.Name = "lblEnvServicio";
            this.lblEnvServicio.Size = new System.Drawing.Size(58, 19);
            this.lblEnvServicio.TabIndex = 5;
            this.lblEnvServicio.Text = "Servicio:";
            // 
            // cboEnvSucDestino
            // 
            this.cboEnvSucDestino.FormattingEnabled = true;
            this.cboEnvSucDestino.Location = new System.Drawing.Point(302, 65);
            this.cboEnvSucDestino.Name = "cboEnvSucDestino";
            this.cboEnvSucDestino.Size = new System.Drawing.Size(121, 25);
            this.cboEnvSucDestino.TabIndex = 11;
            // 
            // lblEnvSucDestino
            // 
            this.lblEnvSucDestino.AutoSize = true;
            this.lblEnvSucDestino.Location = new System.Drawing.Point(215, 66);
            this.lblEnvSucDestino.Name = "lblEnvSucDestino";
            this.lblEnvSucDestino.Size = new System.Drawing.Size(85, 19);
            this.lblEnvSucDestino.TabIndex = 6;
            this.lblEnvSucDestino.Text = "Suc. destino:";
            // 
            // lblEnvObservaciones
            // 
            this.lblEnvObservaciones.AutoSize = true;
            this.lblEnvObservaciones.Location = new System.Drawing.Point(7, 194);
            this.lblEnvObservaciones.Name = "lblEnvObservaciones";
            this.lblEnvObservaciones.Size = new System.Drawing.Size(101, 19);
            this.lblEnvObservaciones.TabIndex = 7;
            this.lblEnvObservaciones.Text = "Observaciones:";
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
            this.tabEnviosRegistrados.Controls.Add(this.grpEnviosRegistrados);
            this.tabEnviosRegistrados.Location = new System.Drawing.Point(4, 26);
            this.tabEnviosRegistrados.Name = "tabEnviosRegistrados";
            this.tabEnviosRegistrados.Padding = new System.Windows.Forms.Padding(3);
            this.tabEnviosRegistrados.Size = new System.Drawing.Size(1052, 406);
            this.tabEnviosRegistrados.TabIndex = 1;
            this.tabEnviosRegistrados.Text = "Envíos registrados";
            this.tabEnviosRegistrados.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 32);
            this.label1.TabIndex = 23;
            this.label1.Text = "Gestión de Envíos";
            // 
            // frmEnvios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabEnvios);
            this.Controls.Add(this.btnVolver);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmEnvios";
            this.Text = "frmEnvios";
            this.Load += new System.EventHandler(this.frmEnvios_Load);
            this.grpEnviosRegistrados.ResumeLayout(false);
            this.grpEnviosRegistrados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnvios)).EndInit();
            this.tabEnvios.ResumeLayout(false);
            this.tabNuevoEnvio.ResumeLayout(false);
            this.grpPaquetes.ResumeLayout(false);
            this.grpPaquetes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaquetes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaqValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaqPeso)).EndInit();
            this.grpDatosEnvio.ResumeLayout(false);
            this.grpDatosEnvio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnvContraEntrega)).EndInit();
            this.tabEnviosRegistrados.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpEnviosRegistrados;
        private System.Windows.Forms.Button btnCancelarEnvio;
        private System.Windows.Forms.TextBox txtEnvBuscar;
        private System.Windows.Forms.Label lblEnvBuscar;
        private System.Windows.Forms.DataGridView dgvEnvios;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TabControl tabEnvios;
        private System.Windows.Forms.TabPage tabNuevoEnvio;
        private System.Windows.Forms.GroupBox grpDatosEnvio;
        private System.Windows.Forms.ComboBox cboEnvSucOrigen;
        private System.Windows.Forms.Label lblEnvRemitente;
        private System.Windows.Forms.Label lblEnvDestinatario;
        private System.Windows.Forms.TextBox txtEnvObservaciones;
        private System.Windows.Forms.Label lblEnvSucOrigen;
        private System.Windows.Forms.NumericUpDown nudEnvContraEntrega;
        private System.Windows.Forms.Label lblEnvContraEntrega;
        private System.Windows.Forms.ComboBox cboEnvServicio;
        private System.Windows.Forms.Label lblEnvServicio;
        private System.Windows.Forms.ComboBox cboEnvSucDestino;
        private System.Windows.Forms.Label lblEnvSucDestino;
        private System.Windows.Forms.Label lblEnvObservaciones;
        private System.Windows.Forms.ComboBox cboEnvDestinatario;
        private System.Windows.Forms.ComboBox cboEnvRemitente;
        private System.Windows.Forms.TabPage tabEnviosRegistrados;
        private System.Windows.Forms.GroupBox grpPaquetes;
        private System.Windows.Forms.Button btnPaqAgregar;
        private System.Windows.Forms.CheckBox chkPaqFragil;
        private System.Windows.Forms.NumericUpDown nudPaqValor;
        private System.Windows.Forms.NumericUpDown nudPaqPeso;
        private System.Windows.Forms.TextBox txtPaqDescripcion;
        private System.Windows.Forms.Label lblPaqValor;
        private System.Windows.Forms.Label lblPaqPeso;
        private System.Windows.Forms.Label lblPaqDescripcion;
        private System.Windows.Forms.Button btnPaqQuitar;
        private System.Windows.Forms.DataGridView dgvPaquetes;
        private System.Windows.Forms.Button btnLimpiarEnvio;
        private System.Windows.Forms.Button btnGuardarEnvio;
        private System.Windows.Forms.Label lblCostoEnvio;
        private System.Windows.Forms.Label lblPesoTotal;
        private System.Windows.Forms.Label label1;
    }
}