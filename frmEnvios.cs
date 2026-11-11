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
    public partial class frmEnvios : Form
    {
        private EnviosBD enviosBD = new EnviosBD();

        // Lista de paquetes del envío que se está armando (vive en memoria hasta que se guarda)
        private DataTable paquetes = new DataTable();

        // Evita recalcular el costo mientras se están llenando los ComboBox
        private bool cargando = false;

        // Envío seleccionado en el listado
        private int idEnvioSel = 0;
        private string guiaSel = "";
        private string estadoSel = "";
        public frmEnvios()
        {
            InitializeComponent();
        }

        private void frmEnvios_Load(object sender, EventArgs e)
        {
            ConfigurarGrid(dgvPaquetes);
            ConfigurarGrid(dgvEnvios);
            ConfigurarNumericos();

            // Estructura de la tabla de paquetes (en memoria, no es de la base de datos)
            paquetes.Columns.Add("Descripcion", typeof(string));
            paquetes.Columns.Add("PesoKg", typeof(decimal));
            paquetes.Columns.Add("ValorDeclarado", typeof(decimal));
            paquetes.Columns.Add("Fragil", typeof(bool));
            dgvPaquetes.DataSource = paquetes;

            cargando = true;
            try
            {
                CargarCombos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del formulario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cargando = false;

            LimpiarEnvio();
            CargarEnvios();
        }

        private void ConfigurarGrid(DataGridView dgv)
        {
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.MultiSelect = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ConfigurarNumericos()
        {
            nudPaqPeso.DecimalPlaces = 2;
            nudPaqPeso.Minimum = 0.01m;
            nudPaqPeso.Maximum = 999.99m;
            nudPaqPeso.Increment = 0.5m;
            nudPaqPeso.Value = 1;

            nudPaqValor.DecimalPlaces = 2;
            nudPaqValor.Minimum = 0;
            nudPaqValor.Maximum = 100000;
            nudPaqValor.Increment = 5;

            nudEnvContraEntrega.DecimalPlaces = 2;
            nudEnvContraEntrega.Minimum = 0;
            nudEnvContraEntrega.Maximum = 100000;
            nudEnvContraEntrega.Increment = 5;
        }

        private void CargarCombos()
        {
            // Todos son de solo selección
            cboEnvRemitente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEnvDestinatario.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEnvSucOrigen.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEnvSucDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEnvServicio.DropDownStyle = ComboBoxStyle.DropDownList;

            cboEnvRemitente.DataSource = enviosBD.ObtenerRemitentesActivos();
            cboEnvRemitente.DisplayMember = "Remitente";
            cboEnvRemitente.ValueMember = "IdRemitente";

            cboEnvDestinatario.DataSource = enviosBD.ObtenerDestinatariosActivos();
            cboEnvDestinatario.DisplayMember = "Destinatario";
            cboEnvDestinatario.ValueMember = "IdDestinatario";

            // Se piden DOS tablas distintas: si dos ComboBox comparten la misma tabla,
            // al elegir en uno se mueve la selección del otro.
            cboEnvSucOrigen.DataSource = enviosBD.ObtenerSucursalesActivas();
            cboEnvSucOrigen.DisplayMember = "Sucursal";
            cboEnvSucOrigen.ValueMember = "IdSucursal";

            cboEnvSucDestino.DataSource = enviosBD.ObtenerSucursalesActivas();
            cboEnvSucDestino.DisplayMember = "Sucursal";
            cboEnvSucDestino.ValueMember = "IdSucursal";

            cboEnvServicio.DataSource = enviosBD.ObtenerServiciosActivos();
            cboEnvServicio.DisplayMember = "Servicio";
            cboEnvServicio.ValueMember = "IdServicio";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ===================== CÁLCULO DEL COSTO =====================

        private decimal PesoTotal()
        {
            decimal total = 0;
            foreach (DataRow fila in paquetes.Rows)
            {
                total += Convert.ToDecimal(fila["PesoKg"]);
            }
            return total;
        }

        // Costo = tarifa base de la zona del destinatario + peso total x precio por kg del servicio
        private decimal CalcularCosto()
        {
            // SelectedItem de un ComboBox enlazado a una tabla es un DataRowView:
            // permite leer cualquier columna de la fila elegida (no solo la que se muestra)
            DataRowView destinatario = cboEnvDestinatario.SelectedItem as DataRowView;
            DataRowView servicio = cboEnvServicio.SelectedItem as DataRowView;

            if (destinatario == null || servicio == null || paquetes.Rows.Count == 0)
            {
                return 0m;
            }

            decimal tarifaBase = Convert.ToDecimal(destinatario["TarifaBase"]);
            decimal precioPorKg = Convert.ToDecimal(servicio["PrecioPorKg"]);

            return Math.Round(tarifaBase + PesoTotal() * precioPorKg, 2);
        }

        private void RecalcularCosto()
        {
            lblPesoTotal.Text = "Peso total: " + PesoTotal().ToString("N2") + " kg";
            lblCostoEnvio.Text = "Costo del envío: $" + CalcularCosto().ToString("N2");
        }

        private void cboEnvDestinatario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargando) return;
            RecalcularCosto();
        }

        private void cboEnvServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargando) return;
            RecalcularCosto();
        }

        // ===================== PAQUETES DEL ENVÍO =====================

        private void btnPaqAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPaqDescripcion.Text))
            {
                MessageBox.Show("Escriba la descripción del paquete.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPaqDescripcion.Focus();
                return;
            }

            paquetes.Rows.Add(txtPaqDescripcion.Text.Trim(), nudPaqPeso.Value, nudPaqValor.Value, chkPaqFragil.Checked);

            txtPaqDescripcion.Clear();
            nudPaqPeso.Value = 1;
            nudPaqValor.Value = 0;
            chkPaqFragil.Checked = false;
            txtPaqDescripcion.Focus();

            RecalcularCosto();
        }

        private void btnPaqQuitar_Click(object sender, EventArgs e)
        {
            if (dgvPaquetes.CurrentRow == null)
            {
                MessageBox.Show("Seleccione el paquete que desea quitar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataRowView fila = (DataRowView)dgvPaquetes.CurrentRow.DataBoundItem;
            paquetes.Rows.Remove(fila.Row);

            RecalcularCosto();
        }

        // ===================== GUARDAR EL ENVÍO =====================

        private void LimpiarEnvio()
        {
            cboEnvRemitente.SelectedIndex = -1;
            cboEnvDestinatario.SelectedIndex = -1;
            cboEnvSucOrigen.SelectedIndex = -1;
            cboEnvSucDestino.SelectedIndex = -1;
            cboEnvServicio.SelectedIndex = -1;
            nudEnvContraEntrega.Value = 0;
            txtEnvObservaciones.Clear();

            paquetes.Clear();
            txtPaqDescripcion.Clear();
            nudPaqPeso.Value = 1;
            nudPaqValor.Value = 0;
            chkPaqFragil.Checked = false;

            RecalcularCosto();
        }

        private bool ValidarEnvio()
        {
            if (cboEnvRemitente.SelectedIndex < 0 || cboEnvDestinatario.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione el remitente y el destinatario.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cboEnvSucOrigen.SelectedIndex < 0 || cboEnvSucDestino.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione la sucursal de origen y la de destino.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cboEnvServicio.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione el tipo de servicio.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (paquetes.Rows.Count == 0)
            {
                MessageBox.Show("Agregue al menos un paquete al envío.", "Sin paquetes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnGuardarEnvio_Click(object sender, EventArgs e)
        {
            if (!ValidarEnvio()) return;

            try
            {
                string guia = enviosBD.RegistrarEnvio(
                    Convert.ToInt32(cboEnvRemitente.SelectedValue),
                    Convert.ToInt32(cboEnvDestinatario.SelectedValue),
                    Convert.ToInt32(cboEnvSucOrigen.SelectedValue),
                    Convert.ToInt32(cboEnvSucDestino.SelectedValue),
                    Convert.ToInt32(cboEnvServicio.SelectedValue),
                    CalcularCosto(),
                    nudEnvContraEntrega.Value,
                    txtEnvObservaciones.Text,
                    paquetes,
                    Sesion.IdUsuario);

                BitacoraBD.Registrar("Crear", "Envios", "Envío " + guia + " registrado");
                MessageBox.Show("Envío registrado correctamente.\nNúmero de guía: " + guia, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarEnvio();
                CargarEnvios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo registrar el envío: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiarEnvio_Click(object sender, EventArgs e)
        {
            LimpiarEnvio();
        }

        // ===================== LISTADO DE ENVÍOS =====================

        private void CargarEnvios()
        {
            idEnvioSel = 0;
            guiaSel = "";
            estadoSel = "";
            btnCancelarEnvio.Enabled = false;

            try
            {
                dgvEnvios.DataSource = enviosBD.ObtenerPanel(txtEnvBuscar.Text.Trim());
                dgvEnvios.Columns["IdEnvio"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los envíos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEnvBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarEnvios();
        }

        private void dgvEnvios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dgvEnvios.Rows[e.RowIndex];
            idEnvioSel = Convert.ToInt32(fila.Cells["IdEnvio"].Value);
            guiaSel = fila.Cells["Guia"].Value.ToString();
            estadoSel = fila.Cells["EstadoActual"].Value.ToString();

            // Solo se puede cancelar un envío que todavía no salió
            btnCancelarEnvio.Enabled = (estadoSel == "Registrado");
        }

        private void btnCancelarEnvio_Click(object sender, EventArgs e)
        {
            if (idEnvioSel == 0)
            {
                MessageBox.Show("Seleccione un envío de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult r = MessageBox.Show("¿Cancelar el envío " + guiaSel + "?\nEsta acción no se puede deshacer.",
                                             "Confirmar cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r != DialogResult.Yes) return;

            try
            {
                bool ok = enviosBD.CancelarEnvio(idEnvioSel, Sesion.IdUsuario);
                if (ok)
                {
                    BitacoraBD.Registrar("Eliminar", "Envios", "Envío " + guiaSel + " cancelado");
                    MessageBox.Show("Envío cancelado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Solo se pueden cancelar envíos en estado \"Registrado\".", "No permitido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                CargarEnvios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cancelar el envío: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
