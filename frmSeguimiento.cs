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
    public partial class frmSeguimiento : Form
    {
        private SeguimientoBD seguimientoBD = new SeguimientoBD();

        // Datos del envío que se está mostrando
        private int idEnvioSel = 0;
        private string guiaSel = "";
        private string estadoActual = "";
        private int idSucOrigen = 0;
        private int idSucDestino = 0;
        private decimal montoContraEntrega = 0;

        public frmSeguimiento()
        {
            InitializeComponent();
            BordesRedondeados.Aplicar(this);
        }

        private void frmSeguimiento_Load(object sender, EventArgs e)
        {
            dgvSeguimiento.ReadOnly = true;
            dgvSeguimiento.AllowUserToAddRows = false;
            dgvSeguimiento.AllowUserToDeleteRows = false;
            dgvSeguimiento.MultiSelect = false;
            dgvSeguimiento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSeguimiento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            cboSegEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSegRepartidor.DropDownStyle = ComboBoxStyle.DropDownList;

            try
            {
                cboSegRepartidor.DataSource = seguimientoBD.ObtenerRepartidoresActivos();
                cboSegRepartidor.DisplayMember = "Repartidor";
                cboSegRepartidor.ValueMember = "IdRepartidor";
                cboSegRepartidor.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los repartidores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LimpiarPantalla();
        }

        private void LimpiarPantalla()
        {
            idEnvioSel = 0;
            guiaSel = "";
            estadoActual = "";

            lblSegResumen.Text = "Escriba el número de guía y pulse Buscar.";
            lblSegEstado.Text = "";
            dgvSeguimiento.DataSource = null;

            cboSegEstado.DataSource = null;
            cboSegRepartidor.SelectedIndex = -1;
            txtSegNota.Clear();
            gbSegMovimiento.Enabled = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ===================== BUSCAR UN ENVÍO =====================

        // Acepta "EE-000007" o solo "7"
        private string NormalizarGuia(string texto)
        {
            texto = texto.Trim().ToUpper();

            int numero;
            if (int.TryParse(texto, out numero))
            {
                return "EE-" + numero.ToString().PadLeft(6, '0');
            }
            return texto;
        }

        private void btnSegBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSegGuia.Text))
            {
                MessageBox.Show("Escriba el número de guía.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSegGuia.Focus();
                return;
            }

            BuscarEnvio(NormalizarGuia(txtSegGuia.Text));
        }

        private void BuscarEnvio(string guia)
        {
            try
            {
                DataTable tabla = seguimientoBD.ObtenerEnvioPorGuia(guia);

                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("No existe ningún envío con la guía " + guia + ".", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarPantalla();
                    txtSegGuia.Focus();
                    return;
                }

                MostrarEnvio(tabla.Rows[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el envío: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarEnvio(DataRow fila)
        {
            idEnvioSel = Convert.ToInt32(fila["IdEnvio"]);
            guiaSel = fila["Guia"].ToString();
            estadoActual = fila["EstadoActual"].ToString();
            idSucOrigen = Convert.ToInt32(fila["IdSucursalOrigen"]);
            idSucDestino = Convert.ToInt32(fila["IdSucursalDestino"]);
            montoContraEntrega = Convert.ToDecimal(fila["MontoContraEntrega"]);

            lblSegResumen.Text =
                "Guía: " + guiaSel + Environment.NewLine +
                "Remitente: " + fila["Remitente"] + Environment.NewLine +
                "Destinatario: " + fila["Destinatario"] + " (" + fila["ZonaDestino"] + ")" + Environment.NewLine +
                "Dirección: " + fila["DireccionExacta"] + Environment.NewLine +
                "Ruta: " + fila["SucursalOrigen"] + "  >  " + fila["SucursalDestino"] + Environment.NewLine +
                "Servicio: " + fila["Servicio"] + Environment.NewLine +
                "Repartidor: " + fila["Repartidor"] + Environment.NewLine +
                "Costo: $" + Convert.ToDecimal(fila["CostoEnvio"]).ToString("N2") +
                "     Contra entrega: $" + montoContraEntrega.ToString("N2");

            lblSegEstado.Text = "Estado actual: " + estadoActual;

            CargarHistorial();
            PrepararMovimiento(fila);
        }

        private void CargarHistorial()
        {
            try
            {
                dgvSeguimiento.DataSource = seguimientoBD.ObtenerHistorial(idEnvioSel);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el historial: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===================== REGLAS DE LOS ESTADOS =====================

        // A qué estados puede pasar un envío según el estado en que está
        private string[] EstadosPermitidos(string estado)
        {
            switch (estado)
            {
                case "Registrado":
                    return new string[] { "En transito", "En sucursal destino", "En reparto" };
                case "En transito":
                    return new string[] { "En sucursal destino" };
                case "En sucursal destino":
                    return new string[] { "En reparto" };
                case "En reparto":
                    return new string[] { "Entregado", "Intento fallido" };
                case "Intento fallido":
                    return new string[] { "En reparto", "Devuelto" };
                default:
                    // Entregado, Devuelto y Cancelado son estados finales
                    return new string[] { };
            }
        }

        private void PrepararMovimiento(DataRow fila)
        {
            string[] permitidos = EstadosPermitidos(estadoActual);

            txtSegNota.Clear();

            if (permitidos.Length == 0)
            {
                cboSegEstado.DataSource = null;
                cboSegRepartidor.SelectedIndex = -1;
                gbSegMovimiento.Enabled = false;
                lblSegEstado.Text = "Estado actual: " + estadoActual + "  (estado final, no admite más cambios)";
                return;
            }

            gbSegMovimiento.Enabled = true;
            cboSegEstado.DataSource = permitidos;
            cboSegEstado.SelectedIndex = -1;

            // Si el envío ya tenía repartidor, se propone el mismo
            if (fila["IdRepartidor"] != DBNull.Value)
            {
                cboSegRepartidor.SelectedValue = Convert.ToInt32(fila["IdRepartidor"]);
            }
            else
            {
                cboSegRepartidor.SelectedIndex = -1;
            }
        }

        // El repartidor solo se pide cuando el nuevo estado es "En reparto"
        private void cboSegEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            string estado = cboSegEstado.SelectedItem as string;
            cboSegRepartidor.Enabled = (estado == "En reparto");
        }

        // ===================== REGISTRAR EL MOVIMIENTO =====================

        private void btnSegRegistrar_Click(object sender, EventArgs e)
        {
            if (idEnvioSel == 0)
            {
                MessageBox.Show("Primero busque un envío.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string nuevoEstado = cboSegEstado.SelectedItem as string;
            if (nuevoEstado == null)
            {
                MessageBox.Show("Seleccione el nuevo estado del envío.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // En reparto: obligatorio elegir repartidor
            int? idRepartidor = null;
            if (nuevoEstado == "En reparto")
            {
                if (cboSegRepartidor.SelectedIndex < 0)
                {
                    MessageBox.Show("Seleccione el repartidor que hará la entrega.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                idRepartidor = Convert.ToInt32(cboSegRepartidor.SelectedValue);
            }

            // Intento fallido: obligatorio explicar el motivo
            if (nuevoEstado == "Intento fallido" && string.IsNullOrWhiteSpace(txtSegNota.Text))
            {
                MessageBox.Show("Escriba el motivo del intento fallido en la nota.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSegNota.Focus();
                return;
            }

            // Estados finales: pedir confirmación
            if (nuevoEstado == "Entregado" || nuevoEstado == "Devuelto")
            {
                DialogResult r = MessageBox.Show("¿Marcar el envío " + guiaSel + " como " + nuevoEstado + "?\nDespués no se podrá cambiar su estado.",
                                                 "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r != DialogResult.Yes) return;
            }

            // Sucursal donde ocurre el movimiento (en tránsito no hay sucursal)
            int? idSucursal = null;
            switch (nuevoEstado)
            {
                case "En sucursal destino":
                case "En reparto":
                case "Entregado":
                case "Intento fallido":
                    idSucursal = idSucDestino;
                    break;
                case "Devuelto":
                    idSucursal = idSucOrigen;
                    break;
            }

            try
            {
                bool ok = seguimientoBD.RegistrarMovimiento(idEnvioSel, estadoActual, nuevoEstado,
                                                            idSucursal, idRepartidor, txtSegNota.Text, Sesion.IdUsuario);
                if (ok)
                {
                    BitacoraBD.Registrar("Editar", "Envios", "Envío " + guiaSel + " cambió de " + estadoActual + " a " + nuevoEstado);

                    string mensaje = "Movimiento registrado: " + nuevoEstado + ".";
                    if (nuevoEstado == "Entregado" && montoContraEntrega > 0)
                    {
                        mensaje += "\n\nEl repartidor debe liquidar $" + montoContraEntrega.ToString("N2") + " de contra entrega.";
                    }
                    MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    BuscarEnvio(guiaSel);   // se recarga para ver el nuevo estado y el historial
                }
                else
                {
                    MessageBox.Show("El estado del envío cambió mientras lo editaba.\nBúsquelo de nuevo para ver el estado actual.",
                                    "Envío modificado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    BuscarEnvio(guiaSel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo registrar el movimiento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
 
        
    

