using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EnviosExpress
{
    public partial class frmUsuarios : Form
    {
        private int idUsuarioSeleccionado = 0;

        public frmUsuarios()
        {
            InitializeComponent();
            BordesRedondeados.Aplicar(this);
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            if (Sesion.Rol != "Admin")
            {
                MessageBox.Show("No tiene permiso para administrar usuarios.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            txtNombreCompleto.MaxLength = 80;
            txtUsuario.MaxLength = 30;
            txtPassword.MaxLength = 50;

            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            CargarRoles();
            ListarUsuarios();
            LimpiarFormulario();
        }

        private void CargarRoles()
        {
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.Items.Clear();
            cmbRol.Items.Add("Admin");
            cmbRol.Items.Add("Operador");
            cmbRol.SelectedIndex = 1;
        }

        private void ListarUsuarios()
        {
            ConexionBD db = new ConexionBD();

            try
            {
                SqlConnection conexion = db.AbrirConexion();

                string query = "SELECT IdUsuario AS [Id], NombreCompleto AS [Nombre], NombreUsuario AS [Usuario], " +
                               "Rol, Activo " +
                               "FROM Usuarios ORDER BY NombreUsuario";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvUsuarios.DataSource = dt;
                    dgvUsuarios.Columns["Id"].Visible = false;
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

        private void LimpiarFormulario()
        {
            idUsuarioSeleccionado = 0;
            txtNombreCompleto.Clear();
            txtUsuario.Clear();
            txtPassword.Clear();
            cmbRol.SelectedIndex = 1;
            chkActivo.Checked = true;

            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;

            dgvUsuarios.ClearSelection();
            txtNombreCompleto.Focus();
        }

        private bool Validar()
        {
            if (string.IsNullOrWhiteSpace(txtNombreCompleto.Text) || string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Complete el nombre y el usuario.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtUsuario.Text.Trim().Contains(" "))
            {
                MessageBox.Show("El usuario no puede contener espacios.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            bool creando = (idUsuarioSeleccionado == 0);
            if (creando && string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Escriba una contraseña para el nuevo usuario.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtPassword.Text.Length > 0 && txtPassword.Text.Length < 6)
            {
                MessageBox.Show("La contraseña debe tener al menos 6 caracteres.", "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void MostrarErrorBD(SqlException ex)
        {
            if (ex.Number == 2627 || ex.Number == 2601)
            {
                MessageBox.Show("Ya existe un usuario con ese nombre de usuario.", "Dato duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ex.Number == 547)
            {
                MessageBox.Show("Este usuario ya tiene actividad registrada (bitácora o seguimientos) y no se puede eliminar.\n" +
                                "Desmarque la casilla \"Activo\" para desactivarlo.",
                                "Usuario en uso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Error de base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!Validar()) return;

            ConexionBD db = new ConexionBD();

            try
            {
                SqlConnection conexion = db.AbrirConexion();

                string query = "INSERT INTO Usuarios (NombreUsuario, Contrasena, NombreCompleto, Rol, Activo) " +
                               "VALUES (@usuario, HASHBYTES('SHA2_256', @password), @nombre, @rol, @activo)";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 30).Value = txtUsuario.Text.Trim();
                    cmd.Parameters.Add("@password", SqlDbType.VarChar, 100).Value = txtPassword.Text;
                    cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 80).Value = txtNombreCompleto.Text.Trim();
                    cmd.Parameters.Add("@rol", SqlDbType.VarChar, 15).Value = cmbRol.SelectedItem.ToString();
                    cmd.Parameters.Add("@activo", SqlDbType.Bit).Value = chkActivo.Checked;
                    cmd.ExecuteNonQuery();
                }

                BitacoraBD.Registrar("Crear", "Usuarios", "Usuario " + txtUsuario.Text.Trim() + " creado con rol " + cmbRol.SelectedItem);
                MessageBox.Show("Usuario registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarFormulario();
                ListarUsuarios();
            }
            catch (SqlException ex)
            {
                MostrarErrorBD(ex);
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
                MessageBox.Show("Seleccione un usuario de la tabla para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!Validar()) return;

            if (idUsuarioSeleccionado == Sesion.IdUsuario)
            {
                if (!chkActivo.Checked)
                {
                    MessageBox.Show("No puede desactivar su propia cuenta.", "No permitido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cmbRol.SelectedItem.ToString() != "Admin")
                {
                    MessageBox.Show("No puede quitarse a sí mismo el rol de Admin.", "No permitido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            ConexionBD db = new ConexionBD();

            try
            {
                SqlConnection conexion = db.AbrirConexion();

                bool cambiarPassword = !string.IsNullOrEmpty(txtPassword.Text);

                string query = "UPDATE Usuarios SET NombreUsuario = @usuario, NombreCompleto = @nombre, " +
                               "Rol = @rol, Activo = @activo";
                if (cambiarPassword)
                {
                    query += ", Contrasena = HASHBYTES('SHA2_256', @password)";
                }
                query += " WHERE IdUsuario = @id";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 30).Value = txtUsuario.Text.Trim();
                    cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 80).Value = txtNombreCompleto.Text.Trim();
                    cmd.Parameters.Add("@rol", SqlDbType.VarChar, 15).Value = cmbRol.SelectedItem.ToString();
                    cmd.Parameters.Add("@activo", SqlDbType.Bit).Value = chkActivo.Checked;
                    if (cambiarPassword)
                    {
                        cmd.Parameters.Add("@password", SqlDbType.VarChar, 100).Value = txtPassword.Text;
                    }
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = idUsuarioSeleccionado;
                    cmd.ExecuteNonQuery();
                }

                BitacoraBD.Registrar("Editar", "Usuarios", "Usuario " + txtUsuario.Text.Trim() + " modificado" + (cambiarPassword ? " (cambio de contraseña)" : ""));
                MessageBox.Show("Usuario actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarFormulario();
                ListarUsuarios();
            }
            catch (SqlException ex)
            {
                MostrarErrorBD(ex);
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
                MessageBox.Show("Seleccione un usuario de la tabla para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (idUsuarioSeleccionado == Sesion.IdUsuario)
            {
                MessageBox.Show("No puede eliminar su propia cuenta.", "No permitido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Eliminar al usuario " + txtUsuario.Text.Trim() + "?",
                                                     "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado != DialogResult.Yes) return;

            ConexionBD db = new ConexionBD();

            try
            {
                SqlConnection conexion = db.AbrirConexion();

                using (SqlCommand cmd = new SqlCommand("DELETE FROM Usuarios WHERE IdUsuario = @id", conexion))
                {
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = idUsuarioSeleccionado;
                    cmd.ExecuteNonQuery();
                }

                BitacoraBD.Registrar("Eliminar", "Usuarios", "Usuario " + txtUsuario.Text.Trim() + " eliminado");
                MessageBox.Show("Usuario eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarFormulario();
                ListarUsuarios();
            }
            catch (SqlException ex)
            {
                MostrarErrorBD(ex);   // el error 547 explica que debe desactivarlo en lugar de eliminarlo
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dgvUsuarios.Rows[e.RowIndex];
            idUsuarioSeleccionado = Convert.ToInt32(fila.Cells["Id"].Value);
            txtNombreCompleto.Text = fila.Cells["Nombre"].Value.ToString();
            txtUsuario.Text = fila.Cells["Usuario"].Value.ToString();
            cmbRol.SelectedItem = fila.Cells["Rol"].Value.ToString();
            chkActivo.Checked = Convert.ToBoolean(fila.Cells["Activo"].Value);
            txtPassword.Clear();   // la contraseña nunca se muestra

            btnAgregar.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }
    }
}