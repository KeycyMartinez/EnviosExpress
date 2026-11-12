using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnviosExpress
{
    public partial class frmMenuPrincipal : Form
    {
        public bool VolverAlLogin { get; private set; }

        public frmMenuPrincipal()
        {
            InitializeComponent();
            BordesRedondeados.Aplicar(this);
            ConfigurarTarjetas();
        }

        private void ConfigurarTarjetas()
        {
            Button[] tarjetas = { btnClientes, btnEnvios, btnSeguimiento, btnReportes, btnUsuarios, btnBitacora };
            foreach (Button tarjeta in tarjetas)
            {
                tarjeta.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
                tarjeta.ForeColor = Color.White;
                tarjeta.FlatStyle = FlatStyle.Flat;
                tarjeta.FlatAppearance.BorderSize = 3;
                tarjeta.FlatAppearance.BorderColor = ControlPaint.Dark(tarjeta.BackColor, 0.35f);
                tarjeta.TextImageRelation = TextImageRelation.Overlay;
                tarjeta.TextAlign = ContentAlignment.MiddleCenter;
                tarjeta.Padding = new Padding(8);
            }

            btnClientes.FlatAppearance.BorderSize = 2;
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            lblBienvenida.Text = "Bienvenido, " + Sesion.NombreCompleto + " (" + Sesion.Rol + ")";

            // Solo el Admin ve estos módulos
            bool esAdmin = Sesion.Rol == "Admin";
            btnUsuarios.Visible = esAdmin;
            btnBitacora.Visible = esAdmin;
        }

        private void AbrirFormulario(Form frm)
        {
            this.Hide();
            using (frm)
            {
                frm.ShowDialog();
            }
            this.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmClientes());
        }

        private void btnEnvios_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmEnvios());
        }

        private void btnSeguimiento_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmSeguimiento());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmReportes());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmUsuarios());
        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmBitacora());
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Desea cerrar sesión?", "Confirmar",
                                             MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                BitacoraBD.Registrar("Logout", null, "Cierre de sesión");
                Sesion.Cerrar();
                VolverAlLogin = true;
                this.Close();
            }
        }
    }
}
