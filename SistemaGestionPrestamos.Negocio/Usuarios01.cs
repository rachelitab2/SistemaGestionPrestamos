using System;
using System.Collections.Generic;
namespace SistemaGestionPrestamos.Negocio
{
    public class Usuarios01
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public string NombreCompleto { get; set; }
        public string Rol { get; set; }
        public DateTime FechaRegistro { get; set; }

        public Usuarios01()
        {
            FechaRegistro = DateTime.Now;

        }

        public bool EsValido(out List<string> errores)
        {
            errores = new List<string>();

            if(string.IsNullOrWhiteSpace(NombreUsuario))
            errores.Add("El nombre de usuario es obligatorio.");

            if(string.IsNullOrWhiteSpace(Contrasena))
                errores.Add("La contraseña es obligatoria.");

            if(string.IsNullOrWhiteSpace(NombreCompleto))
                errores.Add("El nombre completo es obligatorio.");  

            if(string.IsNullOrWhiteSpace(Rol) || (Rol !="Administrador" && Rol != "Empleador" ))
                errores.Add("El rol es obligatorio. Debe ser 'Administrador' o 'Empleado'.");

            return errores.Count == 0;
        }

    }
}
