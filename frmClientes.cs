using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnviosExpress
{
    public partial class frmClientes : Form
    {
        private RemitentesBD remitentesBD = new RemitentesBD();
        private DestinatariosBD destinatariosBD = new DestinatariosBD();
        private int idRemitenteSel = 0;
        private int idDestinatarioSel = 0;
        public frmClientes()
        {
            InitializeComponent();
            BordesRedondeados.Aplicar(this);
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            ConfigurarGrid(dgvRemitentes);
            ConfigurarGrid(dgvDestinatarios);

            try
            {
                cboDesZona.DropDownStyle = ComboBoxStyle.DropDownList;
                cboDesZona.DataSource = destinatariosBD.ObtenerZonas();
                cboDesZona.DisplayMember = "Zona";
                cboDesZona.ValueMember = "IdZona";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las zonas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CargarRemitentes();
            CargarDestinatarios();
            LimpiarRemitente();
            LimpiarDestinatario();
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

        private void tabClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarRemitentes();
            CargarDestinatarios();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostrarErrorBD(SqlException ex)
        {
            if (ex.Number == 547)
            {
                MessageBox.Show("No se puede completar la operación porque este registro está relacionado con envíos.\n" +
                                "Si ya no se usa, desmarque la casilla \"Activo\" en lugar de eliminarlo.",
                                "Registro en uso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ex.Number == 2627 || ex.Number == 2601)
            {
                MessageBox.Show("Ya existe un registro con esa cédula.", "Dato duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Error de base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarRemitentes()
        {
            try
            {
                dgvRemitentes.DataSource = remitentesBD.ObtenerTabla(txtRemBuscar.Text.Trim());
                dgvRemitentes.Columns["IdRemitente"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los remitentes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarRemitente()
        {
            idRemitenteSel = 0;
            txtRemCedula.Clear();
            txtRemNombre.Clear();
            txtRemApellido.Clear();
            txtRemTelefono.Clear();
            txtRemCorreo.Clear();
            txtRemDireccion.Clear();
            chkRemActivo.Checked = true;

            btnRemAgregar.Enabled = true;
            btnRemModificar.Enabled = false;
            btnRemEliminar.Enabled = false;

            dgvRemitentes.ClearSelection();
            txtRemCedula.Focus();
        }

        private bool CorreoValido(string correo)
        {
            int arroba = correo.IndexOf('@');
            return arroba > 0 && correo.IndexOf('.', arroba) > arroba + 1 && !correo.EndsWith(".");
        }

        private bool ValidarRemitente()
        {
            if (string.IsNullOrWhiteSpace(txtRemCedula.Text) ||
                string.IsNullOrWhiteSpace(txtRemNombre.Text) ||
                string.IsNullOrWhiteSpace(txtRemApellido.Text) ||
                string.IsNullOrWhiteSpace(txtRemTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtRemDireccion.Text))
            {
                MessageBox.Show("Complete cédula, nombre, apellido, teléfono y dirección.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtRemCorreo.Text) && !CorreoValido(txtRemCorreo.Text.Trim()))
            {
                MessageBox.Show("El correo no tiene un formato válido.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRemCorreo.Focus();
                return false;
            }

            return true;
        }

        private void btnRemAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarRemitente()) return;

            try
            {
                bool ok = remitentesBD.Insertar(txtRemCedula.Text, txtRemNombre.Text, txtRemApellido.Text,
                                                txtRemTelefono.Text, txtRemCorreo.Text, txtRemDireccion.Text);
                if (ok)
                {
                    BitacoraBD.Registrar("Crear", "Remitentes", "Remitente " + txtRemCedula.Text.Trim() + " creado");
                    MessageBox.Show("Remitente guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarRemitente();
                    CargarRemitentes();
                }
            }
            catch (SqlException ex)
            {
                MostrarErrorBD(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemModificar_Click(object sender, EventArgs e)
        {
            if (idRemitenteSel == 0)
            {
                MessageBox.Show("Seleccione un remitente de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!ValidarRemitente()) return;

            try
            {
                bool ok = remitentesBD.Actualizar(idRemitenteSel, txtRemCedula.Text, txtRemNombre.Text, txtRemApellido.Text,
                                                  txtRemTelefono.Text, txtRemCorreo.Text, txtRemDireccion.Text,
                                                  chkRemActivo.Checked);
                if (ok)
                {
                    BitacoraBD.Registrar("Editar", "Remitentes", "Remitente " + txtRemCedula.Text.Trim() + " modificado");
                    MessageBox.Show("Remitente actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarRemitente();
                    CargarRemitentes();
                }
            }
            catch (SqlException ex)
            {
                MostrarErrorBD(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemEliminar_Click(object sender, EventArgs e)
        {
            if (idRemitenteSel == 0)
            {
                MessageBox.Show("Seleccione un remitente de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult r = MessageBox.Show("¿Eliminar al remitente " + txtRemNombre.Text + " " + txtRemApellido.Text + "?",
                                             "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r != DialogResult.Yes) return;

            try
            {
                bool ok = remitentesBD.Eliminar(idRemitenteSel);
                if (ok)
                {
                    BitacoraBD.Registrar("Eliminar", "Remitentes", "Remitente " + txtRemCedula.Text.Trim() + " eliminado");
                    MessageBox.Show("Remitente eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarRemitente();
                    CargarRemitentes();
                }
            }
            catch (SqlException ex)
            {
                MostrarErrorBD(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarRemitente();
        }

        private void dgvRemitentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;   // se hizo clic en el encabezado

            DataGridViewRow fila = dgvRemitentes.Rows[e.RowIndex];
            idRemitenteSel = Convert.ToInt32(fila.Cells["IdRemitente"].Value);
            txtRemCedula.Text = fila.Cells["Cedula"].Value.ToString();
            txtRemNombre.Text = fila.Cells["Nombre"].Value.ToString();
            txtRemApellido.Text = fila.Cells["Apellido"].Value.ToString();
            txtRemTelefono.Text = fila.Cells["Telefono"].Value.ToString();
            txtRemCorreo.Text = fila.Cells["Correo"].Value.ToString();   // si es NULL queda vacío
            txtRemDireccion.Text = fila.Cells["Direccion"].Value.ToString();
            chkRemActivo.Checked = Convert.ToBoolean(fila.Cells["Activo"].Value);

            btnRemAgregar.Enabled = false;
            btnRemModificar.Enabled = true;
            btnRemEliminar.Enabled = true;
        }

        private void txtRemBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarRemitentes();
        }

        private void txtRemTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CargarDestinatarios()
        {
            try
            {
                dgvDestinatarios.DataSource = destinatariosBD.ObtenerTabla(txtDesBuscar.Text.Trim());
                dgvDestinatarios.Columns["IdDestinatario"].Visible = false;
                dgvDestinatarios.Columns["IdZona"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los destinatarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarDestinatario()
        {
            idDestinatarioSel = 0;
            txtDesNombre.Clear();
            txtDesApellido.Clear();
            txtDesTelefono.Clear();
            txtDesDireccion.Clear();
            chkDesActivo.Checked = true;
            if (cboDesZona.Items.Count > 0) cboDesZona.SelectedIndex = 0;

            btnDesAgregar.Enabled = true;
            btnDesModificar.Enabled = false;
            btnDesEliminar.Enabled = false;

            dgvDestinatarios.ClearSelection();
            txtDesNombre.Focus();
        }

        private bool ValidarDestinatario()
        {
            if (string.IsNullOrWhiteSpace(txtDesNombre.Text) ||
                string.IsNullOrWhiteSpace(txtDesApellido.Text) ||
                string.IsNullOrWhiteSpace(txtDesTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtDesDireccion.Text))
            {
                MessageBox.Show("Complete nombre, apellido, teléfono y dirección exacta.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cboDesZona.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione la zona del destinatario.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnDesAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarDestinatario()) return;

            try
            {
                int idZona = Convert.ToInt32(cboDesZona.SelectedValue);
                bool ok = destinatariosBD.Insertar(txtDesNombre.Text, txtDesApellido.Text, txtDesTelefono.Text,
                                                   idZona, txtDesDireccion.Text);
                if (ok)
                {
                    BitacoraBD.Registrar("Crear", "Destinatarios", "Destinatario " + txtDesNombre.Text.Trim() + " " + txtDesApellido.Text.Trim() + " creado");
                    MessageBox.Show("Destinatario guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarDestinatario();
                    CargarDestinatarios();
                }
            }
            catch (SqlException ex)
            {
                MostrarErrorBD(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDesModificar_Click(object sender, EventArgs e)
        {
            if (idDestinatarioSel == 0)
            {
                MessageBox.Show("Seleccione un destinatario de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!ValidarDestinatario()) return;

            try
            {
                int idZona = Convert.ToInt32(cboDesZona.SelectedValue);
                bool ok = destinatariosBD.Actualizar(idDestinatarioSel, txtDesNombre.Text, txtDesApellido.Text,
                                                     txtDesTelefono.Text, idZona, txtDesDireccion.Text,
                                                     chkDesActivo.Checked);
                if (ok)
                {
                    BitacoraBD.Registrar("Editar", "Destinatarios", "Destinatario " + txtDesNombre.Text.Trim() + " " + txtDesApellido.Text.Trim() + " modificado");
                    MessageBox.Show("Destinatario actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarDestinatario();
                    CargarDestinatarios();
                }
            }
            catch (SqlException ex)
            {
                MostrarErrorBD(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDesEliminar_Click(object sender, EventArgs e)
        {
            if (idDestinatarioSel == 0)
            {
                MessageBox.Show("Seleccione un destinatario de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult r = MessageBox.Show("¿Eliminar al destinatario " + txtDesNombre.Text + " " + txtDesApellido.Text + "?",
                                             "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r != DialogResult.Yes) return;

            try
            {
                bool ok = destinatariosBD.Eliminar(idDestinatarioSel);
                if (ok)
                {
                    BitacoraBD.Registrar("Eliminar", "Destinatarios", "Destinatario " + txtDesNombre.Text.Trim() + " " + txtDesApellido.Text.Trim() + " eliminado");
                    MessageBox.Show("Destinatario eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarDestinatario();
                    CargarDestinatarios();
                }
            }
            catch (SqlException ex)
            {
                MostrarErrorBD(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDesLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarDestinatario();
        }

        private void dgvDestinatarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;   // se hizo clic en el encabezado

            DataGridViewRow fila = dgvDestinatarios.Rows[e.RowIndex];
            idDestinatarioSel = Convert.ToInt32(fila.Cells["IdDestinatario"].Value);
            txtDesNombre.Text = fila.Cells["Nombre"].Value.ToString();
            txtDesApellido.Text = fila.Cells["Apellido"].Value.ToString();
            txtDesTelefono.Text = fila.Cells["Telefono"].Value.ToString();
            cboDesZona.SelectedValue = fila.Cells["IdZona"].Value;
            txtDesDireccion.Text = fila.Cells["DireccionExacta"].Value.ToString();
            chkDesActivo.Checked = Convert.ToBoolean(fila.Cells["Activo"].Value);

            btnDesAgregar.Enabled = false;
            btnDesModificar.Enabled = true;
            btnDesEliminar.Enabled = true;
        }

        private void txtDesBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarDestinatarios();
        }

        private void txtDesTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
    }
}
