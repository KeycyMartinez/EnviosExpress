namespace EnviosExpress
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.btnSeguimiento = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnBitacora = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.lblTituloMenu = new System.Windows.Forms.Label();
            this.btnEnvios = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.picClientes = new System.Windows.Forms.PictureBox();
            this.picEnvios = new System.Windows.Forms.PictureBox();
            this.picSeguimiento = new System.Windows.Forms.PictureBox();
            this.picReportes = new System.Windows.Forms.PictureBox();
            this.picUsuarios = new System.Windows.Forms.PictureBox();
            this.picBitacora = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnvios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSeguimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.Location = new System.Drawing.Point(213, 58);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(124, 25);
            this.lblBienvenida.TabIndex = 1;
            this.lblBienvenida.Text = "¡Bienvenido!";
            // 
            // btnSeguimiento
            // 
            this.btnSeguimiento.BackColor = System.Drawing.Color.LightSalmon;
            this.btnSeguimiento.FlatAppearance.BorderSize = 3;
            this.btnSeguimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeguimiento.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeguimiento.ForeColor = System.Drawing.Color.White;
            this.btnSeguimiento.Location = new System.Drawing.Point(173, 372);
            this.btnSeguimiento.Name = "btnSeguimiento";
            this.btnSeguimiento.Size = new System.Drawing.Size(181, 53);
            this.btnSeguimiento.TabIndex = 5;
            this.btnSeguimiento.Text = "Seguimiento";
            this.btnSeguimiento.UseVisualStyleBackColor = false;
            this.btnSeguimiento.Click += new System.EventHandler(this.btnSeguimiento_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.Gold;
            this.btnReportes.FlatAppearance.BorderSize = 3;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.Location = new System.Drawing.Point(444, 372);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(181, 53);
            this.btnReportes.TabIndex = 6;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.Crimson;
            this.btnUsuarios.FlatAppearance.BorderSize = 3;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Location = new System.Drawing.Point(173, 543);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(181, 53);
            this.btnUsuarios.TabIndex = 7;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnBitacora
            // 
            this.btnBitacora.BackColor = System.Drawing.Color.HotPink;
            this.btnBitacora.FlatAppearance.BorderSize = 3;
            this.btnBitacora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBitacora.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBitacora.ForeColor = System.Drawing.Color.White;
            this.btnBitacora.Location = new System.Drawing.Point(444, 543);
            this.btnBitacora.Name = "btnBitacora";
            this.btnBitacora.Size = new System.Drawing.Size(181, 53);
            this.btnBitacora.TabIndex = 8;
            this.btnBitacora.Text = "Bitácora";
            this.btnBitacora.UseVisualStyleBackColor = false;
            this.btnBitacora.Click += new System.EventHandler(this.btnBitacora_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Silver;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.Location = new System.Drawing.Point(644, 13);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(133, 31);
            this.btnCerrarSesion.TabIndex = 9;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // lblTituloMenu
            // 
            this.lblTituloMenu.AutoSize = true;
            this.lblTituloMenu.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloMenu.Location = new System.Drawing.Point(12, 9);
            this.lblTituloMenu.Name = "lblTituloMenu";
            this.lblTituloMenu.Size = new System.Drawing.Size(188, 32);
            this.lblTituloMenu.TabIndex = 10;
            this.lblTituloMenu.Text = "Menú Principal";
            // 
            // btnEnvios
            // 
            this.btnEnvios.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEnvios.FlatAppearance.BorderSize = 3;
            this.btnEnvios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnvios.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnvios.ForeColor = System.Drawing.Color.White;
            this.btnEnvios.Location = new System.Drawing.Point(444, 200);
            this.btnEnvios.Name = "btnEnvios";
            this.btnEnvios.Size = new System.Drawing.Size(181, 53);
            this.btnEnvios.TabIndex = 4;
            this.btnEnvios.Text = "Envíos";
            this.btnEnvios.UseVisualStyleBackColor = false;
            this.btnEnvios.Click += new System.EventHandler(this.btnEnvios_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.Turquoise;
            this.btnClientes.FlatAppearance.BorderSize = 2;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Location = new System.Drawing.Point(173, 200);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(181, 53);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // picClientes
            // 
            this.picClientes.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.picClientes.Location = new System.Drawing.Point(205, 96);
            this.picClientes.Name = "picClientes";
            this.picClientes.Size = new System.Drawing.Size(120, 98);
            this.picClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClientes.TabIndex = 11;
            this.picClientes.TabStop = false;
            // 
            // picEnvios
            // 
            this.picEnvios.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.picEnvios.Location = new System.Drawing.Point(475, 96);
            this.picEnvios.Name = "picEnvios";
            this.picEnvios.Size = new System.Drawing.Size(120, 98);
            this.picEnvios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEnvios.TabIndex = 12;
            this.picEnvios.TabStop = false;
            // 
            // picSeguimiento
            // 
            this.picSeguimiento.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.picSeguimiento.Location = new System.Drawing.Point(205, 268);
            this.picSeguimiento.Name = "picSeguimiento";
            this.picSeguimiento.Size = new System.Drawing.Size(120, 98);
            this.picSeguimiento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSeguimiento.TabIndex = 13;
            this.picSeguimiento.TabStop = false;
            // 
            // picReportes
            // 
            this.picReportes.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.picReportes.Location = new System.Drawing.Point(475, 268);
            this.picReportes.Name = "picReportes";
            this.picReportes.Size = new System.Drawing.Size(120, 98);
            this.picReportes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picReportes.TabIndex = 14;
            this.picReportes.TabStop = false;
            // 
            // picUsuarios
            // 
            this.picUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.picUsuarios.Location = new System.Drawing.Point(475, 440);
            this.picUsuarios.Name = "picUsuarios";
            this.picUsuarios.Size = new System.Drawing.Size(120, 97);
            this.picUsuarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUsuarios.TabIndex = 15;
            this.picUsuarios.TabStop = false;
            // 
            // picBitacora
            // 
            this.picBitacora.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.picBitacora.Location = new System.Drawing.Point(205, 439);
            this.picBitacora.Name = "picBitacora";
            this.picBitacora.Size = new System.Drawing.Size(120, 98);
            this.picBitacora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBitacora.TabIndex = 16;
            this.picBitacora.TabStop = false;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 611);
            this.Controls.Add(this.picBitacora);
            this.Controls.Add(this.picUsuarios);
            this.Controls.Add(this.picReportes);
            this.Controls.Add(this.picSeguimiento);
            this.Controls.Add(this.picEnvios);
            this.Controls.Add(this.picClientes);
            this.Controls.Add(this.btnEnvios);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnBitacora);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnSeguimiento);
            this.Controls.Add(this.lblTituloMenu);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.lblBienvenida);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMenuPrincipal";
            this.Text = "frmMenuPrincipal";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnvios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSeguimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBitacora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Button btnSeguimiento;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnBitacora;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Label lblTituloMenu;
        private System.Windows.Forms.Button btnEnvios;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.PictureBox picClientes;
        private System.Windows.Forms.PictureBox picEnvios;
        private System.Windows.Forms.PictureBox picSeguimiento;
        private System.Windows.Forms.PictureBox picReportes;
        private System.Windows.Forms.PictureBox picUsuarios;
        private System.Windows.Forms.PictureBox picBitacora;
    }
}