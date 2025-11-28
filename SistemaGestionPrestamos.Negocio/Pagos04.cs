using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionPrestamos.Negocio
{
    public  class Pagos04
    {
        public int IdPago { get; set; }
        public int IdPrestamo { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal MontoPago { get; set; }
        public int NumeroCuota { get; set; }
        public int IdUsuarioRegistro { get; set; }

        public Prestamo03 prestamo03 { get; set; }
        public Pagos04()
        {
            FechaPago = DateTime.Now;
        }

        public bool EsValido(out List<string> errores)
        {
            errores = new List<string>();
            
            if (IdPrestamo <= 0)
                errores.Add("Debe seleccionar un préstamo válido.");
            
            if (MontoPago <= 0)
                errores.Add("El monto del pago debe ser mayor que cero.");

            if (NumeroCuota <= 0)
                errores.Add("El número de cuota debe ser mayor que cero.");

            return errores.Count == 0;
        }
    }
}
