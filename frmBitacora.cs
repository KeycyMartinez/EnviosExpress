using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EnviosExpress
{
    public partial class frmBitacora : Form
    {
        public frmBitacora()
        {
            InitializeComponent();
            BordesRedondeados.Aplicar(this);
        }

        private void frmBitacora_Load(object sender, EventArgs e)
        {
            // Inicializamos los selectores de fecha con el último mes por defecto
            dtpFechaInicio.Value = DateTime.Now.AddDays(-30);
            dtpFechaFin.Value = DateTime.Now;

            // Cargamos la bitácora completa al iniciar
            CargarBitacoraGeneral();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarBitacoraGeneral()
        {
            EjecutarConsultaFiltrada(string.Empty, null, null);
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string usuarioFiltro = txtBuscarUsuario.Text.Trim();
            DateTime fechaInicio = dtpFechaInicio.Value.Date;
            DateTime fechaFin = dtpFechaFin.Value.Date;

            if (fechaInicio > fechaFin)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha final.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            EjecutarConsultaFiltrada(usuarioFiltro, fechaInicio, fechaFin);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBuscarUsuario.Clear();
            dtpFechaInicio.Value = DateTime.Now.AddDays(-30);
            dtpFechaFin.Value = DateTime.Now;

            CargarBitacoraGeneral();
        }

        private void EjecutarConsultaFiltrada(string usuario, DateTime? fechaInicio, DateTime? fechaFin)
        {
            ConexionBD db = new ConexionBD();
            SqlConnection conexion = null;

            try
            {
                conexion = db.AbrirConexion();

                // Consulta dinámica segura que evalúa si se usa el filtro de usuario y/o fechas
                string query = @"SELECT 
                                    b.IdBitacora AS [Código], 
                                    u.NombreUsuario AS [Usuario], 
                                    b.Accion AS [Acción], 
                                    ISNULL(b.TablaAfectada, '-') AS [Tabla], 
                                    ISNULL(b.Detalle, '') AS [Detalle], 
                                    b.FechaHora AS [Fecha y Hora] 
                                 FROM Bitacora b
                                 INNER JOIN Usuarios u ON u.IdUsuario = b.IdUsuario
                                 WHERE (@FiltrarUsuario = 0 OR u.NombreUsuario LIKE '%' + @Usuario + '%')
                                   AND (@FiltrarFechas = 0 OR b.FechaHora BETWEEN @FechaInicio AND @FechaFin)
                                 ORDER BY b.FechaHora DESC";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    // Filtro por Usuario
                    if (!string.IsNullOrEmpty(usuario))
                    {
                        cmd.Parameters.AddWithValue("@FiltrarUsuario", 1);
                        cmd.Parameters.AddWithValue("@Usuario", usuario);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@FiltrarUsuario", 0);
                        cmd.Parameters.AddWithValue("@Usuario", DBNull.Value);
                    }

                    // Filtro por Fechas
                    if (fechaInicio.HasValue && fechaFin.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@FiltrarFechas", 1);
                        cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio.Value);
                        // Ajustamos la fecha fin hasta el último segundo del día
                        cmd.Parameters.AddWithValue("@FechaFin", fechaFin.Value.AddDays(1).AddSeconds(-1));
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@FiltrarFechas", 0);
                        cmd.Parameters.AddWithValue("@FechaInicio", DBNull.Value);
                        cmd.Parameters.AddWithValue("@FechaFin", DBNull.Value);
                    }

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvBitacora.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la bitácora: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CerrarConexion();
            }
        }
    }
}