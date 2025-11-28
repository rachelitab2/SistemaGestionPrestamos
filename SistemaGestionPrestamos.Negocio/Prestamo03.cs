using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionPrestamos.Negocio
{
    public class Prestamo03
    {
        public int IdPrestamos { get; set; }
        public int IdCliente { get; set; }
        public decimal Monto { get; set; }
        public decimal TasaInteres { get; set; }
        public int PlazoMeses { get; set; }

        public DateTime FechaSolicitud  { get; set; }
        public string Estado { get; set; }
        public decimal SaldoPendiente { get; set; }

        public int IdUsuarioRegistro { get; set; }

        public Clientes02 clientes02 { get; set; }

        public Prestamo03()
        {
            FechaSolicitud = DateTime.Now;
            Estado = "Pediente";
           
        }

        public bool EsValido(out List<string> errores)
        {
             errores = new List<string>();
            if (IdCliente <= 0)
                errores.Add("Debe selecccionar un cliente valido");

            if (Monto <= 0)
                errores.Add("El monto del préstamo debe ser mayor que cero.");

            if (TasaInteres <= 0 || TasaInteres > 100)
                errores.Add("La tasa de interés debe estar entre 0 y 100.");

            if (PlazoMeses <= 0)
                errores.Add("El plazo en meses debe ser mayor que cero.");

            return errores.Count == 0;
        }

        public decimal CalcularPagoMensual()
        {
            if (TasaInteres == 0 )
               return Monto / PlazoMeses;

            double tasaMensual = (double)TasaInteres / 100 / 12;
            double factor = Math.Pow(1 + tasaMensual, PlazoMeses);
            return Monto * (decimal)(tasaMensual * factor / (factor - 1));


        }



    }
}
