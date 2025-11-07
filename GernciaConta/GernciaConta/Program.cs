using GernciaConta;


List<Conta> contas = new List<Conta>
{
    new ContaCorrente { Titular = "Alexandre Green", Saldo = 2000m },
    new ContaPoupanca { Titular = "Maria Valentina", Saldo = 1500m }
};

foreach (Conta conta in contas)
{
    Console.WriteLine($"Titular: {conta.Titular} | Saldo: {conta.Saldo:C2}");
}
contas[0].Depositar(500m);
contas[1].Sacar(200m);
((ContaPoupanca)contas[1]).AplicarRendimento();

foreach (Conta conta in contas)
{
    Console.WriteLine($"Titular: {conta.Titular} | Saldo atualizado: {conta.Saldo:C2}");
}
