using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
   public class Cuenta
    {
        public string NumeroCuenta { get; set; }

        public Cliente MiCliente { get; set; }

        public DateTime FechaApertura { get; set; }

        public decimal Saldo { get; set; }

        public Cuenta(string numeroCuenta, Cliente miCliente, DateTime fechaApertura, decimal saldo)
        {
            NumeroCuenta = numeroCuenta;
            MiCliente = miCliente;
            FechaApertura = fechaApertura;
            Saldo = decimal.Zero;
        }
        public void Depositar(decimal monto)
        {
            Saldo = Saldo + monto;
        }

        public bool Retirar(decimal monto) 
        {
            bool puedeRetirar;
            if(Saldo == decimal.Zero || Saldo < monto) 
            {
                puedeRetirar = false;
            }
            else if (Saldo < monto) 
            {
                puedeRetirar = false;
            }
            else 
            {
                Saldo = Saldo - monto;
                puedeRetirar = true;
            }
            return puedeRetirar;
        }
    }
}
