using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EnviosExpress
{
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            // Cargamos los estados posibles en el ComboBox al abrir el formulario
            CargarEstados();

            // Cargamos todos los registros por defecto al iniciar
            CargarReporteGeneral();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarEstados()
        {
            cmbEstado.Items.Clear();
            cmbEstado.Items.Add("Todos");
            cmbEstado.Items.Add("Pendiente");
            cmbEstado.Items.Add("En tránsito");
            cmbEstado.Items.Add("Entregado");
            cmbEstado.Items.Add("Cancelado");

            cmbEstado.SelectedIndex = 0; // Selecciona "Todos" por defecto
        }

        private void CargarReporteGeneral()
        {
            EjecutarConsultaFiltrada(null, null, "Todos");
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dtpFechaInicio.Value.Date;
            DateTime fechaFin = dtpFechaFin.Value.Date;
            string estadoSeleccionado = cmbEstado.SelectedItem != null ? cmbEstado.SelectedItem.ToString() : "Todos";

            if (fechaInicio > fechaFin)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha final.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            EjecutarConsultaFiltrada(fechaInicio, fechaFin, estadoSeleccionado);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dtpFechaInicio.Value = DateTime.Now.AddDays(-30);
            dtpFechaFin.Value = DateTime.Now;
            cmbEstado.SelectedIndex = 0;

            CargarReporteGeneral();
        }

        private void EjecutarConsultaFiltrada(DateTime? fechaInicio, DateTime? fechaFin, string estado)
        {
            // Instanciamos tu clase de conexión
            ConexionBD db = new ConexionBD();
            SqlConnection conexion = null;

            try
            {
                // Abrimos la conexión usando tu método
                conexion = db.AbrirConexion();

                string query = @"SELECT 
                                    e.IdEnvio AS [Código], 
                                    r.Nombre + ' ' + r.Apellido AS [Remitente], 
                                    d.Nombre + ' ' + d.Apellido AS [Destinatario], 
                                    e.FechaRegistro AS [Fecha], 
                                    e.EstadoActual AS [Estado], 
                                    e.CostoEnvio AS [Costo]
                                 FROM Envios e
                                 INNER JOIN Remitentes r ON r.IdRemitente = e.IdRemitente
                                 INNER JOIN Destinatarios d ON d.IdDestinatario = e.IdDestinatario
                                 WHERE (@FiltrarFechas = 0 OR e.FechaRegistro BETWEEN @FechaInicio AND @FechaFin)
                                   AND (@Estado = 'Todos' OR e.EstadoActual = @Estado)";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    if (fechaInicio.HasValue && fechaFin.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@FiltrarFechas", 1);
                        cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio.Value);
                        cmd.Parameters.AddWithValue("@FechaFin", fechaFin.Value.AddDays(1).AddSeconds(-1));
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@FiltrarFechas", 0);
                        cmd.Parameters.AddWithValue("@FechaInicio", DBNull.Value);
                        cmd.Parameters.AddWithValue("@FechaFin", DBNull.Value);
                    }

                    cmd.Parameters.AddWithValue("@Estado", estado);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvReportes.DataSource = dt;
                    lblTotalRegistros.Text = $"Total de registros encontrados: {dt.Rows.Count}";

                    // Calcula la suma total de la columna Costo de los registros filtrados
                    decimal sumaIngresos = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row["Costo"] != DBNull.Value)
                            sumaIngresos += Convert.ToDecimal(row["Costo"]);
                    }
                    // Asume que a la etiqueta de ingresos le pusiste lblTotalIngresos
                    lblTotalIngresos.Text = $"Total de ingresos: ${sumaIngresos:N2}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Cerramos la conexión de forma segura al terminar
                db.CerrarConexion();
            }
        }
    }
}