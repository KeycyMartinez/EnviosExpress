namespace EnviosExpress
{
    partial class frmClientes
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
            this.tabClientes = new System.Windows.Forms.TabControl();
            this.tabRemitentes = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.chkRemActivo = new System.Windows.Forms.CheckBox();
            this.txtRemBuscar = new System.Windows.Forms.TextBox();
            this.lblRemBuscar = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblApellidoRem = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombreRem = new System.Windows.Forms.Label();
            this.txtRemDireccion = new System.Windows.Forms.TextBox();
            this.txtRemCorreo = new System.Windows.Forms.TextBox();
            this.txtRemTelefono = new System.Windows.Forms.TextBox();
            this.txtRemApellido = new System.Windows.Forms.TextBox();
            this.txtRemCedula = new System.Windows.Forms.TextBox();
            this.txtRemNombre = new System.Windows.Forms.TextBox();
            this.btnRemLimpiar = new System.Windows.Forms.Button();
            this.btnRemEliminar = new System.Windows.Forms.Button();
            this.btnRemModificar = new System.Windows.Forms.Button();
            this.btnRemAgregar = new System.Windows.Forms.Button();
            this.dgvRemitentes = new System.Windows.Forms.DataGridView();
            this.tabDestinatarios = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.cboDesZona = new System.Windows.Forms.ComboBox();
            this.chkDesActivo = new System.Windows.Forms.CheckBox();
            this.txtDesDireccion = new System.Windows.Forms.TextBox();
            this.txtDesApellido = new System.Windows.Forms.TextBox();
            this.txtDesNombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDesApellido = new System.Windows.Forms.Label();
            this.lblDesNombre = new System.Windows.Forms.Label();
            this.lblDesTelefono = new System.Windows.Forms.Label();
            this.txtDesTelefono = new System.Windows.Forms.TextBox();
            this.btnDesLimpiar = new System.Windows.Forms.Button();
            this.btnDesEliminar = new System.Windows.Forms.Button();
            this.btnDesModificar = new System.Windows.Forms.Button();
            this.btnDesAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDesBuscar = new System.Windows.Forms.TextBox();
            this.dgvDestinatarios = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblTituloClientes = new System.Windows.Forms.Label();
            this.tabClientes.SuspendLayout();
            this.tabRemitentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemitentes)).BeginInit();
            this.tabDestinatarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestinatarios)).BeginInit();
            this.SuspendLayout();
            // 
            // tabClientes
            // 
            this.tabClientes.Controls.Add(this.tabRemitentes);
            this.tabClientes.Controls.Add(this.tabDestinatarios);
            this.tabClientes.Location = new System.Drawing.Point(28, 50);
            this.tabClientes.Name = "tabClientes";
            this.tabClientes.SelectedIndex = 0;
            this.tabClientes.Size = new System.Drawing.Size(1056, 399);
            this.tabClientes.TabIndex = 0;
            this.tabClientes.SelectedIndexChanged += new System.EventHandler(this.tabClientes_SelectedIndexChanged);
            // 
            // tabRemitentes
            // 
            this.tabRemitentes.Controls.Add(this.label3);
            this.tabRemitentes.Controls.Add(this.chkRemActivo);
            this.tabRemitentes.Controls.Add(this.txtRemBuscar);
            this.tabRemitentes.Controls.Add(this.lblRemBuscar);
            this.tabRemitentes.Controls.Add(this.label6);
            this.tabRemitentes.Controls.Add(this.label5);
            this.tabRemitentes.Controls.Add(this.label4);
            this.tabRemitentes.Controls.Add(this.lblApellidoRem);
            this.tabRemitentes.Controls.Add(this.label2);
            this.tabRemitentes.Controls.Add(this.lblNombreRem);
            this.tabRemitentes.Controls.Add(this.txtRemDireccion);
            this.tabRemitentes.Controls.Add(this.txtRemCorreo);
            this.tabRemitentes.Controls.Add(this.txtRemTelefono);
            this.tabRemitentes.Controls.Add(this.txtRemApellido);
            this.tabRemitentes.Controls.Add(this.txtRemCedula);
            this.tabRemitentes.Controls.Add(this.txtRemNombre);
            this.tabRemitentes.Controls.Add(this.btnRemLimpiar);
            this.tabRemitentes.Controls.Add(this.btnRemEliminar);
            this.tabRemitentes.Controls.Add(this.btnRemModificar);
            this.tabRemitentes.Controls.Add(this.btnRemAgregar);
            this.tabRemitentes.Controls.Add(this.dgvRemitentes);
            this.tabRemitentes.Location = new System.Drawing.Point(4, 26);
            this.tabRemitentes.Name = "tabRemitentes";
            this.tabRemitentes.Padding = new System.Windows.Forms.Padding(3);
            this.tabRemitentes.Size = new System.Drawing.Size(1048, 369);
            this.tabRemitentes.TabIndex = 0;
            this.tabRemitentes.Text = "Remitentes";
            this.tabRemitentes.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(386, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Registro de Remitentes";
            // 
            // chkRemActivo
            // 
            this.chkRemActivo.AutoSize = true;
            this.chkRemActivo.Checked = true;
            this.chkRemActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRemActivo.Location = new System.Drawing.Point(25, 264);
            this.chkRemActivo.Name = "chkRemActivo";
            this.chkRemActivo.Size = new System.Drawing.Size(66, 23);
            this.chkRemActivo.TabIndex = 19;
            this.chkRemActivo.Text = "Activo";
            this.chkRemActivo.UseVisualStyleBackColor = true;
            // 
            // txtRemBuscar
            // 
            this.txtRemBuscar.Location = new System.Drawing.Point(76, 28);
            this.txtRemBuscar.Name = "txtRemBuscar";
            this.txtRemBuscar.Size = new System.Drawing.Size(179, 25);
            this.txtRemBuscar.TabIndex = 18;
            this.txtRemBuscar.TextChanged += new System.EventHandler(this.txtRemBuscar_TextChanged);
            // 
            // lblRemBuscar
            // 
            this.lblRemBuscar.AutoSize = true;
            this.lblRemBuscar.Location = new System.Drawing.Point(20, 31);
            this.lblRemBuscar.Name = "lblRemBuscar";
            this.lblRemBuscar.Size = new System.Drawing.Size(52, 19);
            this.lblRemBuscar.TabIndex = 17;
            this.lblRemBuscar.Text = "Buscar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Dirección:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Correo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Teléfono:";
            // 
            // lblApellidoRem
            // 
            this.lblApellidoRem.AutoSize = true;
            this.lblApellidoRem.Location = new System.Drawing.Point(21, 138);
            this.lblApellidoRem.Name = "lblApellidoRem";
            this.lblApellidoRem.Size = new System.Drawing.Size(61, 19);
            this.lblApellidoRem.TabIndex = 13;
            this.lblApellidoRem.Text = "Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cédula:";
            // 
            // lblNombreRem
            // 
            this.lblNombreRem.AutoSize = true;
            this.lblNombreRem.Location = new System.Drawing.Point(21, 77);
            this.lblNombreRem.Name = "lblNombreRem";
            this.lblNombreRem.Size = new System.Drawing.Size(62, 19);
            this.lblNombreRem.TabIndex = 11;
            this.lblNombreRem.Text = "Nombre:";
            // 
            // txtRemDireccion
            // 
            this.txtRemDireccion.Location = new System.Drawing.Point(205, 220);
            this.txtRemDireccion.Name = "txtRemDireccion";
            this.txtRemDireccion.Size = new System.Drawing.Size(148, 25);
            this.txtRemDireccion.TabIndex = 10;
            // 
            // txtRemCorreo
            // 
            this.txtRemCorreo.Location = new System.Drawing.Point(25, 220);
            this.txtRemCorreo.Name = "txtRemCorreo";
            this.txtRemCorreo.Size = new System.Drawing.Size(145, 25);
            this.txtRemCorreo.TabIndex = 9;
            // 
            // txtRemTelefono
            // 
            this.txtRemTelefono.Location = new System.Drawing.Point(205, 160);
            this.txtRemTelefono.Name = "txtRemTelefono";
            this.txtRemTelefono.Size = new System.Drawing.Size(107, 25);
            this.txtRemTelefono.TabIndex = 8;
            this.txtRemTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRemTelefono_KeyPress);
            // 
            // txtRemApellido
            // 
            this.txtRemApellido.Location = new System.Drawing.Point(25, 160);
            this.txtRemApellido.Name = "txtRemApellido";
            this.txtRemApellido.Size = new System.Drawing.Size(145, 25);
            this.txtRemApellido.TabIndex = 7;
            // 
            // txtRemCedula
            // 
            this.txtRemCedula.Location = new System.Drawing.Point(205, 99);
            this.txtRemCedula.Name = "txtRemCedula";
            this.txtRemCedula.Size = new System.Drawing.Size(107, 25);
            this.txtRemCedula.TabIndex = 6;
            // 
            // txtRemNombre
            // 
            this.txtRemNombre.Location = new System.Drawing.Point(24, 99);
            this.txtRemNombre.Name = "txtRemNombre";
            this.txtRemNombre.Size = new System.Drawing.Size(146, 25);
            this.txtRemNombre.TabIndex = 5;
            // 
            // btnRemLimpiar
            // 
            this.btnRemLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnRemLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnRemLimpiar.Location = new System.Drawing.Point(296, 306);
            this.btnRemLimpiar.Name = "btnRemLimpiar";
            this.btnRemLimpiar.Size = new System.Drawing.Size(75, 33);
            this.btnRemLimpiar.TabIndex = 4;
            this.btnRemLimpiar.Text = "Limpiar";
            this.btnRemLimpiar.UseVisualStyleBackColor = false;
            this.btnRemLimpiar.Click += new System.EventHandler(this.btnRemLimpiar_Click);
            // 
            // btnRemEliminar
            // 
            this.btnRemEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnRemEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemEliminar.ForeColor = System.Drawing.Color.White;
            this.btnRemEliminar.Location = new System.Drawing.Point(212, 306);
            this.btnRemEliminar.Name = "btnRemEliminar";
            this.btnRemEliminar.Size = new System.Drawing.Size(78, 32);
            this.btnRemEliminar.TabIndex = 3;
            this.btnRemEliminar.Text = "Eliminar";
            this.btnRemEliminar.UseVisualStyleBackColor = false;
            this.btnRemEliminar.Click += new System.EventHandler(this.btnRemEliminar_Click);
            // 
            // btnRemModificar
            // 
            this.btnRemModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnRemModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemModificar.ForeColor = System.Drawing.Color.White;
            this.btnRemModificar.Location = new System.Drawing.Point(116, 305);
            this.btnRemModificar.Name = "btnRemModificar";
            this.btnRemModificar.Size = new System.Drawing.Size(90, 33);
            this.btnRemModificar.TabIndex = 2;
            this.btnRemModificar.Text = "Modificar";
            this.btnRemModificar.UseVisualStyleBackColor = false;
            this.btnRemModificar.Click += new System.EventHandler(this.btnRemModificar_Click);
            // 
            // btnRemAgregar
            // 
            this.btnRemAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnRemAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemAgregar.ForeColor = System.Drawing.Color.White;
            this.btnRemAgregar.Location = new System.Drawing.Point(25, 306);
            this.btnRemAgregar.Name = "btnRemAgregar";
            this.btnRemAgregar.Size = new System.Drawing.Size(85, 33);
            this.btnRemAgregar.TabIndex = 1;
            this.btnRemAgregar.Text = "Agregar remitente";
            this.btnRemAgregar.UseVisualStyleBackColor = false;
            this.btnRemAgregar.Click += new System.EventHandler(this.btnRemAgregar_Click);
            // 
            // dgvRemitentes
            // 
            this.dgvRemitentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRemitentes.Location = new System.Drawing.Point(390, 66);
            this.dgvRemitentes.Name = "dgvRemitentes";
            this.dgvRemitentes.Size = new System.Drawing.Size(630, 272);
            this.dgvRemitentes.TabIndex = 0;
            this.dgvRemitentes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRemitentes_CellClick);
            // 
            // tabDestinatarios
            // 
            this.tabDestinatarios.BackColor = System.Drawing.Color.Transparent;
            this.tabDestinatarios.Controls.Add(this.label7);
            this.tabDestinatarios.Controls.Add(this.cboDesZona);
            this.tabDestinatarios.Controls.Add(this.chkDesActivo);
            this.tabDestinatarios.Controls.Add(this.txtDesDireccion);
            this.tabDestinatarios.Controls.Add(this.txtDesApellido);
            this.tabDestinatarios.Controls.Add(this.txtDesNombre);
            this.tabDestinatarios.Controls.Add(this.label9);
            this.tabDestinatarios.Controls.Add(this.label8);
            this.tabDestinatarios.Controls.Add(this.lblDesApellido);
            this.tabDestinatarios.Controls.Add(this.lblDesNombre);
            this.tabDestinatarios.Controls.Add(this.lblDesTelefono);
            this.tabDestinatarios.Controls.Add(this.txtDesTelefono);
            this.tabDestinatarios.Controls.Add(this.btnDesLimpiar);
            this.tabDestinatarios.Controls.Add(this.btnDesEliminar);
            this.tabDestinatarios.Controls.Add(this.btnDesModificar);
            this.tabDestinatarios.Controls.Add(this.btnDesAgregar);
            this.tabDestinatarios.Controls.Add(this.label1);
            this.tabDestinatarios.Controls.Add(this.txtDesBuscar);
            this.tabDestinatarios.Controls.Add(this.dgvDestinatarios);
            this.tabDestinatarios.Location = new System.Drawing.Point(4, 26);
            this.tabDestinatarios.Name = "tabDestinatarios";
            this.tabDestinatarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabDestinatarios.Size = new System.Drawing.Size(1048, 369);
            this.tabDestinatarios.TabIndex = 1;
            this.tabDestinatarios.Text = "Destinatarios";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(399, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Registro de Destinatarios";
            // 
            // cboDesZona
            // 
            this.cboDesZona.FormattingEnabled = true;
            this.cboDesZona.Location = new System.Drawing.Point(206, 104);
            this.cboDesZona.Name = "cboDesZona";
            this.cboDesZona.Size = new System.Drawing.Size(168, 25);
            this.cboDesZona.TabIndex = 18;
            // 
            // chkDesActivo
            // 
            this.chkDesActivo.AutoSize = true;
            this.chkDesActivo.Checked = true;
            this.chkDesActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDesActivo.Location = new System.Drawing.Point(207, 226);
            this.chkDesActivo.Name = "chkDesActivo";
            this.chkDesActivo.Size = new System.Drawing.Size(66, 23);
            this.chkDesActivo.TabIndex = 17;
            this.chkDesActivo.Text = "Activo";
            this.chkDesActivo.UseVisualStyleBackColor = true;
            // 
            // txtDesDireccion
            // 
            this.txtDesDireccion.Location = new System.Drawing.Point(207, 165);
            this.txtDesDireccion.Name = "txtDesDireccion";
            this.txtDesDireccion.Size = new System.Drawing.Size(167, 25);
            this.txtDesDireccion.TabIndex = 16;
            // 
            // txtDesApellido
            // 
            this.txtDesApellido.Location = new System.Drawing.Point(24, 165);
            this.txtDesApellido.Name = "txtDesApellido";
            this.txtDesApellido.Size = new System.Drawing.Size(137, 25);
            this.txtDesApellido.TabIndex = 14;
            // 
            // txtDesNombre
            // 
            this.txtDesNombre.Location = new System.Drawing.Point(24, 104);
            this.txtDesNombre.Name = "txtDesNombre";
            this.txtDesNombre.Size = new System.Drawing.Size(137, 25);
            this.txtDesNombre.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(203, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 19);
            this.label9.TabIndex = 12;
            this.label9.Text = "Dirección exacta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(203, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "Zona:";
            // 
            // lblDesApellido
            // 
            this.lblDesApellido.AutoSize = true;
            this.lblDesApellido.Location = new System.Drawing.Point(21, 143);
            this.lblDesApellido.Name = "lblDesApellido";
            this.lblDesApellido.Size = new System.Drawing.Size(61, 19);
            this.lblDesApellido.TabIndex = 10;
            this.lblDesApellido.Text = "Apellido:";
            // 
            // lblDesNombre
            // 
            this.lblDesNombre.AutoSize = true;
            this.lblDesNombre.Location = new System.Drawing.Point(22, 82);
            this.lblDesNombre.Name = "lblDesNombre";
            this.lblDesNombre.Size = new System.Drawing.Size(62, 19);
            this.lblDesNombre.TabIndex = 9;
            this.lblDesNombre.Text = "Nombre:";
            // 
            // lblDesTelefono
            // 
            this.lblDesTelefono.AutoSize = true;
            this.lblDesTelefono.Location = new System.Drawing.Point(21, 202);
            this.lblDesTelefono.Name = "lblDesTelefono";
            this.lblDesTelefono.Size = new System.Drawing.Size(63, 19);
            this.lblDesTelefono.TabIndex = 8;
            this.lblDesTelefono.Text = "Teléfono:";
            // 
            // txtDesTelefono
            // 
            this.txtDesTelefono.Location = new System.Drawing.Point(24, 224);
            this.txtDesTelefono.Name = "txtDesTelefono";
            this.txtDesTelefono.Size = new System.Drawing.Size(137, 25);
            this.txtDesTelefono.TabIndex = 7;
            this.txtDesTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesTelefono_KeyPress);
            // 
            // btnDesLimpiar
            // 
            this.btnDesLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnDesLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnDesLimpiar.Location = new System.Drawing.Point(298, 285);
            this.btnDesLimpiar.Name = "btnDesLimpiar";
            this.btnDesLimpiar.Size = new System.Drawing.Size(81, 32);
            this.btnDesLimpiar.TabIndex = 6;
            this.btnDesLimpiar.Text = "Limpiar";
            this.btnDesLimpiar.UseVisualStyleBackColor = false;
            this.btnDesLimpiar.Click += new System.EventHandler(this.btnDesLimpiar_Click);
            // 
            // btnDesEliminar
            // 
            this.btnDesEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnDesEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesEliminar.ForeColor = System.Drawing.Color.White;
            this.btnDesEliminar.Location = new System.Drawing.Point(206, 285);
            this.btnDesEliminar.Name = "btnDesEliminar";
            this.btnDesEliminar.Size = new System.Drawing.Size(85, 32);
            this.btnDesEliminar.TabIndex = 5;
            this.btnDesEliminar.Text = "Eliminar";
            this.btnDesEliminar.UseVisualStyleBackColor = false;
            this.btnDesEliminar.Click += new System.EventHandler(this.btnDesEliminar_Click);
            // 
            // btnDesModificar
            // 
            this.btnDesModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnDesModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesModificar.ForeColor = System.Drawing.Color.White;
            this.btnDesModificar.Location = new System.Drawing.Point(113, 285);
            this.btnDesModificar.Name = "btnDesModificar";
            this.btnDesModificar.Size = new System.Drawing.Size(87, 32);
            this.btnDesModificar.TabIndex = 4;
            this.btnDesModificar.Text = "Modificar";
            this.btnDesModificar.UseVisualStyleBackColor = false;
            this.btnDesModificar.Click += new System.EventHandler(this.btnDesModificar_Click);
            // 
            // btnDesAgregar
            // 
            this.btnDesAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnDesAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesAgregar.ForeColor = System.Drawing.Color.White;
            this.btnDesAgregar.Location = new System.Drawing.Point(28, 285);
            this.btnDesAgregar.Name = "btnDesAgregar";
            this.btnDesAgregar.Size = new System.Drawing.Size(79, 32);
            this.btnDesAgregar.TabIndex = 3;
            this.btnDesAgregar.Text = "Agregar";
            this.btnDesAgregar.UseVisualStyleBackColor = false;
            this.btnDesAgregar.Click += new System.EventHandler(this.btnDesAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar:";
            // 
            // txtDesBuscar
            // 
            this.txtDesBuscar.Location = new System.Drawing.Point(78, 27);
            this.txtDesBuscar.Name = "txtDesBuscar";
            this.txtDesBuscar.Size = new System.Drawing.Size(209, 25);
            this.txtDesBuscar.TabIndex = 1;
            this.txtDesBuscar.TextChanged += new System.EventHandler(this.txtDesBuscar_TextChanged);
            // 
            // dgvDestinatarios
            // 
            this.dgvDestinatarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDestinatarios.Location = new System.Drawing.Point(404, 50);
            this.dgvDestinatarios.Name = "dgvDestinatarios";
            this.dgvDestinatarios.Size = new System.Drawing.Size(616, 267);
            this.dgvDestinatarios.TabIndex = 0;
            this.dgvDestinatarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDestinatarios_CellClick);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Location = new System.Drawing.Point(990, 469);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(94, 30);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblTituloClientes
            // 
            this.lblTituloClientes.AutoSize = true;
            this.lblTituloClientes.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloClientes.Location = new System.Drawing.Point(22, 9);
            this.lblTituloClientes.Name = "lblTituloClientes";
            this.lblTituloClientes.Size = new System.Drawing.Size(233, 32);
            this.lblTituloClientes.TabIndex = 2;
            this.lblTituloClientes.Text = "Gestión de Clientes";
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 511);
            this.Controls.Add(this.lblTituloClientes);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.tabClientes);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmClientes";
            this.Text = "frmClientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.tabClientes.ResumeLayout(false);
            this.tabRemitentes.ResumeLayout(false);
            this.tabRemitentes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemitentes)).EndInit();
            this.tabDestinatarios.ResumeLayout(false);
            this.tabDestinatarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestinatarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabClientes;
        private System.Windows.Forms.TabPage tabRemitentes;
        private System.Windows.Forms.TabPage tabDestinatarios;
        private System.Windows.Forms.DataGridView dgvRemitentes;
        private System.Windows.Forms.Button btnRemLimpiar;
        private System.Windows.Forms.Button btnRemEliminar;
        private System.Windows.Forms.Button btnRemModificar;
        private System.Windows.Forms.Button btnRemAgregar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox txtRemNombre;
        private System.Windows.Forms.TextBox txtRemTelefono;
        private System.Windows.Forms.TextBox txtRemApellido;
        private System.Windows.Forms.TextBox txtRemCedula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblApellidoRem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombreRem;
        private System.Windows.Forms.TextBox txtRemDireccion;
        private System.Windows.Forms.TextBox txtRemCorreo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRemBuscar;
        private System.Windows.Forms.Label lblRemBuscar;
        private System.Windows.Forms.CheckBox chkRemActivo;
        private System.Windows.Forms.DataGridView dgvDestinatarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDesBuscar;
        private System.Windows.Forms.Label lblDesTelefono;
        private System.Windows.Forms.TextBox txtDesTelefono;
        private System.Windows.Forms.Button btnDesLimpiar;
        private System.Windows.Forms.Button btnDesEliminar;
        private System.Windows.Forms.Button btnDesModificar;
        private System.Windows.Forms.Button btnDesAgregar;
        private System.Windows.Forms.TextBox txtDesDireccion;
        private System.Windows.Forms.TextBox txtDesApellido;
        private System.Windows.Forms.TextBox txtDesNombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDesApellido;
        private System.Windows.Forms.Label lblDesNombre;
        private System.Windows.Forms.CheckBox chkDesActivo;
        private System.Windows.Forms.ComboBox cboDesZona;
        private System.Windows.Forms.Label lblTituloClientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
    }
}