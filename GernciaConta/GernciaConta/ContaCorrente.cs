

namespace GernciaConta
{
    internal class ContaCorrente : Conta
    {
       
        public override void Sacar(decimal valor)
        {
            if (valor > Saldo)
            {
                throw new InvalidOperationException("Saldo insuficiente.");
            }
            if (valor > 1000)
            {
                throw new InvalidOperationException("Limite de saque excedido para Conta Corrente.");
            }
            Saldo -= valor;
        }
    }
}
