using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionPrestamos.Negocio
{
    public static class Sesion06
    {
        public static Usuarios01 UsuarioActual { get; set; }

        public static bool EstaAutenticado()
        {
            return UsuarioActual != null;
        }

        public static bool EsAdministrador()
        {
            return EstaAutenticado() && UsuarioActual.Rol == "Administrador";
        }

        public static void CerrarSesion()
        {
            UsuarioActual = null;
        }

    }
}
