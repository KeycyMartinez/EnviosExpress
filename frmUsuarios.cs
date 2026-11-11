using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace EnviosExpress
{
    public partial class frmUsuarios : Form
    {
        private int idUsuarioSeleccionado = 0; // Variable interna para saber qué usuario se está editando

        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            CargarRoles();
            ListarUsuarios();
        }

        private void CargarRoles()
        {
            cmbRol.Items.Clear();
            cmbRol.Items.Add("Administrador");
            cmbRol.Items.Add("Operador");
            cmbRol.SelectedIndex = 0;
        }

        private void ListarUsuarios()
        {
            ConexionBD db = new ConexionBD();
            SqlConnection conexion = null;

            try
            {
                conexion = db.AbrirConexion();
                string query = "SELECT IdUsuario AS [Id], NombreUsuario AS [Usuario], Rol FROM Usuarios";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvUsuarios.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los usuarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CerrarConexion();
            }
        }

        // Método para encriptar la contraseña utilizando SHA2-256
        private string EncriptarSHA256(string texto)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(texto));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Por favor, complete el usuario y la contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ConexionBD db = new ConexionBD();
            SqlConnection conexion = null;

            try
            {
                conexion = db.AbrirConexion();
                string query = "INSERT INTO Usuarios (NombreUsuario, PasswordUsuario, Rol) VALUES (@Usuario, @Password, @Rol)";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@Usuario", txtUsuario.Text.Trim());
                    cmd.Parameters.AddWithValue("@Password", EncriptarSHA256(txtPassword.Text.Trim()));
                    cmd.Parameters.AddWithValue("@Rol", cmbRol.SelectedItem.ToString());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usuario registrado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ListarUsuarios();
                    btnLimpiar_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CerrarConexion();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (idUsuarioSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un usuario de la tabla para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ConexionBD db = new ConexionBD();
            SqlConnection conexion = null;

            try
            {
                conexion = db.AbrirConexion();

                // Si el campo de contraseña está lleno, se actualiza; si está vacío, se mantiene la anterior
                bool cambiarPass = !string.IsNullOrWhiteSpace(txtPassword.Text);
                string query;

                if (cambiarPass)
                {
                    query = "UPDATE Usuarios SET NombreUsuario = @Usuario, PasswordUsuario = @Password, Rol = @Rol WHERE IdUsuario = @Id";
                }
                else
                {
                    query = "UPDATE Usuarios SET NombreUsuario = @Usuario, Rol = @Rol WHERE IdUsuario = @Id";
                }

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@Usuario", txtUsuario.Text.Trim());
                    if (cambiarPass)
                    {
                        cmd.Parameters.AddWithValue("@Password", EncriptarSHA256(txtPassword.Text.Trim()));
                    }
                    cmd.Parameters.AddWithValue("@Rol", cmbRol.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Id", idUsuarioSeleccionado);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usuario actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ListarUsuarios();
                    btnLimpiar_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.CerrarConexion();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idUsuarioSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un usuario de la tabla para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar este usuario?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                ConexionBD db = new ConexionBD();
                SqlConnection conexion = null;

                try
                {
                    conexion = db.AbrirConexion();
                    string query = "DELETE FROM Usuarios WHERE IdUsuario = @Id";

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@Id", idUsuarioSeleccionado);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Usuario eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ListarUsuarios();
                        btnLimpiar_Click(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    db.CerrarConexion();
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            idUsuarioSeleccionado = 0;
            txtUsuario.Clear();
            txtPassword.Clear();
            if (cmbRol.Items.Count > 0) cmbRol.SelectedIndex = 0;
            txtUsuario.Focus();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Al hacer clic en la tabla, pasamos los datos a los controles (la contraseña se limpia por seguridad)
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsuarios.Rows[e.RowIndex];
                idUsuarioSeleccionado = Convert.ToInt32(row.Cells["Id"].Value);
                txtUsuario.Text = row.Cells["Usuario"].Value.ToString();
                cmbRol.SelectedItem = row.Cells["Rol"].Value.ToString();
                txtPassword.Clear();
            }
        }
    }
}