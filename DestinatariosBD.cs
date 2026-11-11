using System;
using System.Data;
using System.Data.SqlClient;

namespace EnviosExpress
{
    public class DestinatariosBD
    {
        // READ (con JOIN): destinatarios junto al nombre de su zona
        public DataTable ObtenerTabla(string filtro)
        {
            ConexionBD conexion = new ConexionBD();
            try
            {
                string query = "SELECT d.IdDestinatario, d.Nombre, d.Apellido, d.Telefono, " +
                               "d.IdZona, z.Provincia, z.Nombre AS Zona, d.DireccionExacta, d.Activo " +
                               "FROM Destinatarios d " +
                               "INNER JOIN Zonas z ON z.IdZona = d.IdZona " +
                               "WHERE d.Nombre LIKE @filtro OR d.Apellido LIKE @filtro " +
                               "OR d.Telefono LIKE @filtro OR z.Nombre LIKE @filtro " +
                               "ORDER BY d.Apellido, d.Nombre";

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

        // Zonas activas para llenar el ComboBox (se ve "Provincia - Zona", vale IdZona)
        public DataTable ObtenerZonas()
        {
            ConexionBD conexion = new ConexionBD();
            try
            {
                string query = "SELECT IdZona, Provincia + ' - ' + Nombre AS Zona " +
                               "FROM Zonas WHERE Activa = 1 ORDER BY Provincia, Nombre";

                SqlCommand cmd = new SqlCommand(query, conexion.AbrirConexion());

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

        // CREATE
        public bool Insertar(string nombre, string apellido, string telefono, int idZona, string direccion)
        {
            ConexionBD conexion = new ConexionBD();
            try
            {
                string query = "INSERT INTO Destinatarios (Nombre, Apellido, Telefono, IdZona, DireccionExacta) " +
                               "VALUES (@nom, @ape, @tel, @zona, @dir)";

                SqlCommand cmd = new SqlCommand(query, conexion.AbrirConexion());
                cmd.Parameters.AddWithValue("@nom", nombre.Trim());
                cmd.Parameters.AddWithValue("@ape", apellido.Trim());
                cmd.Parameters.AddWithValue("@tel", telefono.Trim());
                cmd.Parameters.AddWithValue("@zona", idZona);
                cmd.Parameters.AddWithValue("@dir", direccion.Trim());

                int filas = cmd.ExecuteNonQuery();
                return filas > 0;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        // UPDATE
        public bool Actualizar(int id, string nombre, string apellido, string telefono,
                               int idZona, string direccion, bool activo)
        {
            ConexionBD conexion = new ConexionBD();
            try
            {
                string query = "UPDATE Destinatarios " +
                               "SET Nombre = @nom, Apellido = @ape, Telefono = @tel, " +
                               "IdZona = @zona, DireccionExacta = @dir, Activo = @act " +
                               "WHERE IdDestinatario = @id";

                SqlCommand cmd = new SqlCommand(query, conexion.AbrirConexion());
                cmd.Parameters.AddWithValue("@nom", nombre.Trim());
                cmd.Parameters.AddWithValue("@ape", apellido.Trim());
                cmd.Parameters.AddWithValue("@tel", telefono.Trim());
                cmd.Parameters.AddWithValue("@zona", idZona);
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

        // DELETE (falla con error 547 si el destinatario ya tiene envíos)
        public bool Eliminar(int id)
        {
            ConexionBD conexion = new ConexionBD();
            try
            {
                string query = "DELETE FROM Destinatarios WHERE IdDestinatario = @id";

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
