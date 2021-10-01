using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
   public class MovimientosCuenta
    {
        public Cuenta MiCuenta { get; set; }
        DateTime FechaMovimiento { get; set; }

        public decimal Monto { get; set; }

        public string TipoMovimiento { get; set; }

        public MovimientosCuenta() { }

        public MovimientosCuenta(Cuenta miCuenta, DateTime fechaMovimiento, decimal monto, string tipoMovimiento)
        {
            MiCuenta = miCuenta;
            FechaMovimiento = fechaMovimiento;
            Monto = monto;
            TipoMovimiento = tipoMovimiento;
        }
    }
}
