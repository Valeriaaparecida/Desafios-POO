using SistemaFuncionario;

Console.WriteLine("Bem vindo(a) ao sistema de cadastro de funcionários");
Console.WriteLine("Vamos começar com o gerente");
Console.Write("Digite o nome do gerente: ");
Gerente gerente = new Gerente();
gerente.Nome = Console.ReadLine();
Console.Write("Digite o salário do gerente: ");
gerente.Salario = decimal.Parse(Console.ReadLine()!);
Console.Write("Digite o bônus do gerente: ");
gerente.Bonus = decimal.Parse(Console.ReadLine()!);
Console.WriteLine($"Salário total do gerente {gerente.Nome} é {gerente.CalcularSalarioTotal():C2}");
Console.WriteLine("Agora vamos cadastrar um funcionário");
Funcionario funcionario = new Funcionario();
Console.Write("Digite o nome do funcionário: ");
funcionario.Nome = Console.ReadLine();
Console.Write("Digite o salário do funcionário: ");
funcionario.Salario = decimal.Parse(Console.ReadLine()!);
Console.WriteLine($"Salário total do funcionário {funcionario.Nome} é {funcionario.CalcularSalarioTotal():C2}");
Console.WriteLine("Cadastro concluído. Obrigado!");

