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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Por favor, ingrese el usuario y la contraseña.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ConexionBD conexion = new ConexionBD();
            SqlCommand cmd = new SqlCommand();
            bool accesoConcedido = false;

            try
            {
                // Consulta segura usando parámetros y HASHBYTES tal como lo estructuramos en la BD.
                // Ahora también traemos IdUsuario y NombreUsuario para guardarlos en la sesión.
                string query = "SELECT IdUsuario, NombreUsuario, NombreCompleto, Rol " +
                               "FROM Usuarios " +
                               "WHERE NombreUsuario = @usuario " +
                               "AND Contrasena = HASHBYTES('SHA2_256', @password) " +
                               "AND Activo = 1";

                cmd.Connection = conexion.AbrirConexion();
                cmd.CommandText = query;

                // AGREGAR PARÁMETROS (Evita inyección SQL exigida por el profesor)
                cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 50).Value = txtUsuario.Text.Trim();
                cmd.Parameters.Add("@password", SqlDbType.VarChar, 100).Value = txtPassword.Text;

                SqlDataReader lector = cmd.ExecuteReader();

                if (lector.Read())
                {
                    // Guardar los datos de quien inició sesión
                    Sesion.IdUsuario = Convert.ToInt32(lector["IdUsuario"]);
                    Sesion.NombreUsuario = lector["NombreUsuario"].ToString();
                    Sesion.NombreCompleto = lector["NombreCompleto"].ToString();
                    Sesion.Rol = lector["Rol"].ToString();
                    accesoConcedido = true;
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                    txtUsuario.Focus();
                }

                lector.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar conectar con la base de datos: " + ex.Message, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.CerrarConexion();
            }

            // El menú se abre FUERA del try/finally: así la conexión ya está cerrada
            // y no queda abierta mientras el usuario usa el sistema.
            if (accesoConcedido)
            {
                BitacoraBD.Registrar("Login", null, "Inicio de sesión");

                this.Hide();
                using (frmMenuPrincipal menu = new frmMenuPrincipal())
                {
                    menu.ShowDialog();   // el login espera aquí hasta que se cierre el menú
                }

                // Al cerrar el menú, también se cierra el login oculto y termina la aplicación.
                this.Close();
            }
        }
    }
}
