using System;
using System.Data.SqlClient;
namespace SistemaGestionPrestamos
{
    public class ConexionDatos
    {
        public static string cadenaConexion = "Server=.;Database=SistemaGestionPrestamosDB;Trusted_Connection=True;";
        
        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}
