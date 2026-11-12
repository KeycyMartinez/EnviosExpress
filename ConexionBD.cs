using System;
using System.Configuration;
using System.Data.SqlClient;

public class ConexionBD
{
    private SqlConnection conexion;

    public ConexionBD()
    {
        string cadenaConexion = ConfigurationManager.ConnectionStrings["EnviosExpressConnection"].ConnectionString;
        conexion = new SqlConnection(cadenaConexion);
    }

    public SqlConnection AbrirConexion()
    {
        try
        {
            if (conexion.State == System.Data.ConnectionState.Closed)
            {
                conexion.Open();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al abrir la conexión: " + ex.Message);
        }
        return conexion;
    }

    public SqlConnection CerrarConexion()
    {
        try
        {
            if (conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al cerrar la conexión: " + ex.Message);
        }
        return conexion;
    }
}