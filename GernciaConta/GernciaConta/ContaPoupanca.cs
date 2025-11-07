

namespace GernciaConta
{
    internal class ContaPoupanca : Conta
    {
        private const decimal _rendimentoMensal = 0.01m; 
       

        public void AplicarRendimento()
        {
                Saldo += Saldo * _rendimentoMensal;
        }

    }
}
