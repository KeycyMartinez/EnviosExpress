using System;
using System.Data;
using System.Data.SqlClient;

namespace EnviosExpress
{
    public class SeguimientoBD
    {
        public DataTable ObtenerEnvioPorGuia(string guia)
        {
            ConexionBD conexion = new ConexionBD();
            try
            {
                string query = "SELECT e.IdEnvio, e.Guia, e.FechaRegistro, e.EstadoActual, e.CostoEnvio, " +
                               "e.MontoContraEntrega, e.IdSucursalOrigen, e.IdSucursalDestino, e.IdRepartidor, " +
                               "r.Nombre + ' ' + r.Apellido AS Remitente, " +
                               "d.Nombre + ' ' + d.Apellido AS Destinatario, d.DireccionExacta, " +
                               "z.Nombre AS ZonaDestino, s.Nombre AS Servicio, " +
                               "so.Nombre AS SucursalOrigen, sd.Nombre AS SucursalDestino, " +
                               "ISNULL(rp.Nombre + ' ' + rp.Apellido, 'Sin asignar') AS Repartidor " +
                               "FROM Envios e " +
                               "INNER JOIN Remitentes r     ON r.IdRemitente    = e.IdRemitente " +
                               "INNER JOIN Destinatarios d  ON d.IdDestinatario = e.IdDestinatario " +
                               "INNER JOIN Zonas z          ON z.IdZona         = d.IdZona " +
                               "INNER JOIN TiposServicio s  ON s.IdServicio     = e.IdServicio " +
                               "INNER JOIN Sucursales so    ON so.IdSucursal    = e.IdSucursalOrigen " +
                               "INNER JOIN Sucursales sd    ON sd.IdSucursal    = e.IdSucursalDestino " +
                               "LEFT JOIN Repartidores rp   ON rp.IdRepartidor  = e.IdRepartidor " +
                               "WHERE e.Guia = @guia";

                SqlCommand cmd = new SqlCommand(query, conexion.AbrirConexion());
                cmd.Parameters.AddWithValue("@guia", guia);

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

        public DataTable ObtenerHistorial(int idEnvio)
        {
            ConexionBD conexion = new ConexionBD();
            try
            {
                string query = "SELECT sg.FechaHora, sg.Estado, ISNULL(su.Nombre, 'En camino') AS Sucursal, " +
                               "u.NombreCompleto AS RegistradoPor, sg.Nota " +
                               "FROM SeguimientoEnvio sg " +
                               "INNER JOIN Usuarios u ON u.IdUsuario = sg.IdUsuario " +
                               "LEFT JOIN Sucursales su ON su.IdSucursal = sg.IdSucursal " +
                               "WHERE sg.IdEnvio = @id " +
                               "ORDER BY sg.FechaHora, sg.IdSeguimiento";

                SqlCommand cmd = new SqlCommand(query, conexion.AbrirConexion());
                cmd.Parameters.AddWithValue("@id", idEnvio);

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

        public DataTable ObtenerRepartidoresActivos()
        {
            ConexionBD conexion = new ConexionBD();
            try
            {
                string query = "SELECT IdRepartidor, Nombre + ' ' + Apellido + ' (' + Vehiculo + ')' AS Repartidor " +
                               "FROM Repartidores WHERE Activo = 1 ORDER BY Nombre, Apellido";

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

        public bool RegistrarMovimiento(int idEnvio, string estadoAnterior, string estadoNuevo,
                                        int? idSucursal, int? idRepartidor, string nota, int idUsuario)
        {
            ConexionBD conexion = new ConexionBD();
            SqlConnection cn = conexion.AbrirConexion();
            SqlTransaction tx = cn.BeginTransaction();

            try
            {
                string sqlUpdate = "UPDATE Envios SET EstadoActual = @nuevo, " +
                                   "IdRepartidor = COALESCE(@rep, IdRepartidor), " +
                                   "FechaEntrega = CASE WHEN @nuevo = 'Entregado' THEN GETDATE() ELSE FechaEntrega END " +
                                   "WHERE IdEnvio = @id AND EstadoActual = @anterior";

                SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, cn, tx);
                cmdUpdate.Parameters.AddWithValue("@nuevo", estadoNuevo);
                cmdUpdate.Parameters.Add("@rep", SqlDbType.Int).Value = (object)idRepartidor ?? DBNull.Value;
                cmdUpdate.Parameters.AddWithValue("@id", idEnvio);
                cmdUpdate.Parameters.AddWithValue("@anterior", estadoAnterior);
                int filas = cmdUpdate.ExecuteNonQuery();

                if (filas == 0)
                {
                    tx.Rollback();
                    return false;
                }

                string sqlSeg = "INSERT INTO SeguimientoEnvio (IdEnvio, Estado, IdSucursal, IdUsuario, Nota) " +
                                "VALUES (@id, @estado, @suc, @usuario, @nota)";

                SqlCommand cmdSeg = new SqlCommand(sqlSeg, cn, tx);
                cmdSeg.Parameters.AddWithValue("@id", idEnvio);
                cmdSeg.Parameters.AddWithValue("@estado", estadoNuevo);
                cmdSeg.Parameters.Add("@suc", SqlDbType.Int).Value = (object)idSucursal ?? DBNull.Value;
                cmdSeg.Parameters.AddWithValue("@usuario", idUsuario);
                cmdSeg.Parameters.AddWithValue("@nota", string.IsNullOrWhiteSpace(nota) ? (object)DBNull.Value : nota.Trim());
                cmdSeg.ExecuteNonQuery();

                tx.Commit();
                return true;
            }
            catch
            {
                tx.Rollback();
                throw;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
    }
}
