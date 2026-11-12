using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnviosExpress
{
    public static class BitacoraBD
    {
        public static void Registrar(string accion, string tabla, string detalle)
        {
            ConexionBD conexion = new ConexionBD();
            try
            {
                string query = "INSERT INTO Bitacora (IdUsuario, Accion, TablaAfectada, Detalle) " +
                               "VALUES (@usuario, @accion, @tabla, @detalle)";

                SqlCommand cmd = new SqlCommand(query, conexion.AbrirConexion());
                cmd.Parameters.AddWithValue("@usuario", Sesion.IdUsuario);
                cmd.Parameters.AddWithValue("@accion", accion);
                cmd.Parameters.AddWithValue("@tabla", (object)tabla ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@detalle", (object)detalle ?? DBNull.Value);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
    }
}
