using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionPrestamos.Negocio
{
    public class Clientes02
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaRegistro { get; set; }

        public Clientes02()
        {
            FechaRegistro = DateTime.Now;
        }

        public bool EsValido(out List<string> errores)
        {
            errores = new List<string>();

            if(string.IsNullOrWhiteSpace(Nombre))
                errores.Add("El nombre del cliente es obligatorio.");

            if(string.IsNullOrWhiteSpace(Cedula))
                errores.Add("La cédula del cliente es obligatoria.");

            return errores.Count == 0;
        }


    }
}
