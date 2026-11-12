using System;
using System.Data;
using System.Data.SqlClient;

namespace EnviosExpress
{
    public class RemitentesBD
    {
        public DataTable ObtenerTabla(string filtro)
        {
            ConexionBD conexion = new ConexionBD();
            try
            {
                string query = "SELECT IdRemitente, Cedula, Nombre, Apellido, Telefono, Correo, Direccion, Activo " +
                               "FROM Remitentes " +
                               "WHERE Cedula LIKE @filtro OR Nombre LIKE @filtro OR Apellido LIKE @filtro " +
                               "ORDER BY Apellido, Nombre";

                SqlCommand cmd = new SqlCommand(query, conexion.AbrirConexion());
                cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%");

                DataTable tabla = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                return tabla;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public bool Insertar(string cedula, string nombre, string apellido,
                             string telefono, string correo, string direccion)
        {
            ConexionBD conexion = new ConexionBD();
            try
            {
                string query = "INSERT INTO Remitentes (Cedula, Nombre, Apellido, Telefono, Correo, Direccion) " +
                               "VALUES (@ced, @nom, @ape, @tel, @cor, @dir)";

                SqlCommand cmd = new SqlCommand(query, conexion.AbrirConexion());
                cmd.Parameters.AddWithValue("@ced", cedula.Trim());
                cmd.Parameters.AddWithValue("@nom", nombre.Trim());
                cmd.Parameters.AddWithValue("@ape", apellido.Trim());
                cmd.Parameters.AddWithValue("@tel", telefono.Trim());
                cmd.Parameters.AddWithValue("@cor", string.IsNullOrWhiteSpace(correo) ? (object)DBNull.Value : correo.Trim());
                cmd.Parameters.AddWithValue("@dir", direccion.Trim());

                int filas = cmd.ExecuteNonQuery();
                return filas > 0;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public bool Actualizar(int id, string cedula, string nombre, string apellido,
                               string telefono, string correo, string direccion, bool activo)
        {
            ConexionBD conexion = new ConexionBD();
            try
            {
                string query = "UPDATE Remitentes " +
                               "SET Cedula = @ced, Nombre = @nom, Apellido = @ape, Telefono = @tel, " +
                               "Correo = @cor, Direccion = @dir, Activo = @act " +
                               "WHERE IdRemitente = @id";

                SqlCommand cmd = new SqlCommand(query, conexion.AbrirConexion());
                cmd.Parameters.AddWithValue("@ced", cedula.Trim());
                cmd.Parameters.AddWithValue("@nom", nombre.Trim());
                cmd.Parameters.AddWithValue("@ape", apellido.Trim());
                cmd.Parameters.AddWithValue("@tel", telefono.Trim());
                cmd.Parameters.AddWithValue("@cor", string.IsNullOrWhiteSpace(correo) ? (object)DBNull.Value : correo.Trim());
                cmd.Parameters.AddWithValue("@dir", direccion.Trim());
                cmd.Parameters.AddWithValue("@act", activo);
                cmd.Parameters.AddWithValue("@id", id);

                int filas = cmd.ExecuteNonQuery();
                return filas > 0;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public bool Eliminar(int id)
        {
            ConexionBD conexion = new ConexionBD();
            try
            {
                string query = "DELETE FROM Remitentes WHERE IdRemitente = @id";

                SqlCommand cmd = new SqlCommand(query, conexion.AbrirConexion());
                cmd.Parameters.AddWithValue("@id", id);

                int filas = cmd.ExecuteNonQuery();
                return filas > 0;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
    }
}
