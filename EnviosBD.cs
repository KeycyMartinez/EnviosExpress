using System;
using System.Data;
using System.Data.SqlClient;

namespace EnviosExpress
{
    public class EnviosBD
    {
        // ===================== DATOS PARA LOS COMBOBOX =====================

        // Ejecuta un SELECT sin parámetros y devuelve el resultado como tabla
        private DataTable ConsultarTabla(string query)
        {
            ConexionBD conexion = new ConexionBD();
            try
            {
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

        public DataTable ObtenerRemitentesActivos()
        {
            return ConsultarTabla("SELECT IdRemitente, Nombre + ' ' + Apellido + ' (' + Cedula + ')' AS Remitente " +
                                  "FROM Remitentes WHERE Activo = 1 ORDER BY Apellido, Nombre");
        }

        // Incluye TarifaBase de la zona: se usa para calcular el costo del envío
        public DataTable ObtenerDestinatariosActivos()
        {
            return ConsultarTabla("SELECT d.IdDestinatario, d.Nombre + ' ' + d.Apellido + ' - ' + z.Nombre AS Destinatario, z.TarifaBase " +
                                  "FROM Destinatarios d INNER JOIN Zonas z ON z.IdZona = d.IdZona " +
                                  "WHERE d.Activo = 1 ORDER BY d.Apellido, d.Nombre");
        }

        public DataTable ObtenerSucursalesActivas()
        {
            return ConsultarTabla("SELECT IdSucursal, Nombre AS Sucursal FROM Sucursales WHERE Activa = 1 ORDER BY Nombre");
        }

        // Incluye PrecioPorKg: se usa para calcular el costo del envío
        public DataTable ObtenerServiciosActivos()
        {
            return ConsultarTabla("SELECT IdServicio, Nombre + ' - ' + CAST(DiasEstimados AS VARCHAR(3)) + ' dias' AS Servicio, PrecioPorKg " +
                                  "FROM TiposServicio WHERE Activo = 1 ORDER BY PrecioPorKg");
        }

        // ===================== LISTADO (READ) =====================

        // Lee de la vista vw_PanelEnvios, que hace JOIN de 7 tablas
        public DataTable ObtenerPanel(string filtro)
        {
            ConexionBD conexion = new ConexionBD();
            try
            {
                string query = "SELECT IdEnvio, Guia, FechaRegistro, Remitente, Destinatario, ZonaDestino, " +
                               "Servicio, CostoEnvio, EstadoActual " +
                               "FROM vw_PanelEnvios " +
                               "WHERE Guia LIKE @filtro OR Remitente LIKE @filtro " +
                               "OR Destinatario LIKE @filtro OR EstadoActual LIKE @filtro " +
                               "ORDER BY IdEnvio DESC";

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

        // ===================== REGISTRAR UN ENVÍO (CREATE) =====================

        // Guarda el envío, sus paquetes y el primer movimiento de seguimiento.
        // Todo dentro de UNA transacción: o se guarda completo o no se guarda nada.
        // Devuelve el número de guía generado.
        public string RegistrarEnvio(int idRemitente, int idDestinatario, int idSucOrigen, int idSucDestino,
                                     int idServicio, decimal costo, decimal contraEntrega,
                                     string observaciones, DataTable paquetes, int idUsuario)
        {
            ConexionBD conexion = new ConexionBD();
            SqlConnection cn = conexion.AbrirConexion();
            SqlTransaction tx = cn.BeginTransaction();

            try
            {
                // 1) El envío (devuelve el Id recién generado con SCOPE_IDENTITY)
                string sqlEnvio = "INSERT INTO Envios (IdRemitente, IdDestinatario, IdSucursalOrigen, IdSucursalDestino, " +
                                  "IdServicio, CostoEnvio, MontoContraEntrega, Observaciones) " +
                                  "VALUES (@rem, @des, @orig, @dest, @serv, @costo, @contra, @obs); " +
                                  "SELECT CAST(SCOPE_IDENTITY() AS INT);";

                SqlCommand cmdEnvio = new SqlCommand(sqlEnvio, cn, tx);
                cmdEnvio.Parameters.AddWithValue("@rem", idRemitente);
                cmdEnvio.Parameters.AddWithValue("@des", idDestinatario);
                cmdEnvio.Parameters.AddWithValue("@orig", idSucOrigen);
                cmdEnvio.Parameters.AddWithValue("@dest", idSucDestino);
                cmdEnvio.Parameters.AddWithValue("@serv", idServicio);
                cmdEnvio.Parameters.AddWithValue("@costo", costo);
                cmdEnvio.Parameters.AddWithValue("@contra", contraEntrega);
                cmdEnvio.Parameters.AddWithValue("@obs", string.IsNullOrWhiteSpace(observaciones) ? (object)DBNull.Value : observaciones.Trim());
                int idEnvio = Convert.ToInt32(cmdEnvio.ExecuteScalar());

                // 2) Cada paquete de la lista
                string sqlPaquete = "INSERT INTO Paquetes (IdEnvio, Descripcion, PesoKg, ValorDeclarado, Fragil) " +
                                    "VALUES (@envio, @desc, @peso, @valor, @fragil)";

                foreach (DataRow fila in paquetes.Rows)
                {
                    SqlCommand cmdPaquete = new SqlCommand(sqlPaquete, cn, tx);
                    cmdPaquete.Parameters.AddWithValue("@envio", idEnvio);
                    cmdPaquete.Parameters.AddWithValue("@desc", fila["Descripcion"].ToString());
                    cmdPaquete.Parameters.AddWithValue("@peso", Convert.ToDecimal(fila["PesoKg"]));
                    cmdPaquete.Parameters.AddWithValue("@valor", Convert.ToDecimal(fila["ValorDeclarado"]));
                    cmdPaquete.Parameters.AddWithValue("@fragil", Convert.ToBoolean(fila["Fragil"]));
                    cmdPaquete.ExecuteNonQuery();
                }

                // 3) Primer movimiento del historial: "Registrado" en la sucursal de origen
                string sqlSeg = "INSERT INTO SeguimientoEnvio (IdEnvio, Estado, IdSucursal, IdUsuario) " +
                                "VALUES (@envio, 'Registrado', @suc, @usuario)";

                SqlCommand cmdSeg = new SqlCommand(sqlSeg, cn, tx);
                cmdSeg.Parameters.AddWithValue("@envio", idEnvio);
                cmdSeg.Parameters.AddWithValue("@suc", idSucOrigen);
                cmdSeg.Parameters.AddWithValue("@usuario", idUsuario);
                cmdSeg.ExecuteNonQuery();

                // 4) Leer la guía generada por la base de datos (columna calculada)
                SqlCommand cmdGuia = new SqlCommand("SELECT Guia FROM Envios WHERE IdEnvio = @envio", cn, tx);
                cmdGuia.Parameters.AddWithValue("@envio", idEnvio);
                string guia = cmdGuia.ExecuteScalar().ToString();

                tx.Commit();
                return guia;
            }
            catch
            {
                tx.Rollback();   // si algo falló, se deshace todo
                throw;           // y el error sube al formulario
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        // ===================== CANCELAR UN ENVÍO (DELETE LÓGICO) =====================

        // Un envío no se borra: se marca "Cancelado" y queda en el historial.
        // Solo se puede cancelar si todavía está en estado "Registrado".
        public bool CancelarEnvio(int idEnvio, int idUsuario)
        {
            ConexionBD conexion = new ConexionBD();
            SqlConnection cn = conexion.AbrirConexion();
            SqlTransaction tx = cn.BeginTransaction();

            try
            {
                string sqlUpdate = "UPDATE Envios SET EstadoActual = 'Cancelado' " +
                                   "WHERE IdEnvio = @id AND EstadoActual = 'Registrado'";

                SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, cn, tx);
                cmdUpdate.Parameters.AddWithValue("@id", idEnvio);
                int filas = cmdUpdate.ExecuteNonQuery();

                if (filas == 0)
                {
                    tx.Rollback();
                    return false;   // el envío ya no estaba en estado "Registrado"
                }

                string sqlSeg = "INSERT INTO SeguimientoEnvio (IdEnvio, Estado, IdUsuario, Nota) " +
                                "VALUES (@id, 'Cancelado', @usuario, 'Envio cancelado')";

                SqlCommand cmdSeg = new SqlCommand(sqlSeg, cn, tx);
                cmdSeg.Parameters.AddWithValue("@id", idEnvio);
                cmdSeg.Parameters.AddWithValue("@usuario", idUsuario);
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