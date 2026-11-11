using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnviosExpress
{
    public static class Sesion
    {
        public static int IdUsuario { get; set; }
        public static string NombreUsuario { get; set; }
        public static string NombreCompleto { get; set; }
        public static string Rol { get; set; }

        public static void Cerrar()
        {
            IdUsuario = 0;
            NombreUsuario = null;
            NombreCompleto = null;
            Rol = null;
        }
    }
}
