using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GernciaConta
{
    internal class Conta
    {
        public string Titular { get; set; }
        public decimal Saldo { get; set; }


        public void Depositar(decimal valor)
        {
            Saldo += valor;
        }
        public virtual void Sacar(decimal valor)
        {
            if (valor > Saldo)
            {
                throw new InvalidOperationException("Saldo insuficiente.");
            }
            Saldo -= valor;
        }
    }
}
