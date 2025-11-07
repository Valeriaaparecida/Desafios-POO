using CadastroProduto;

Console.WriteLine("Olá usuário(a)!");
Console.WriteLine("Bem-vindo ao sistema de cadastro de produtos.");
Console.WriteLine("Por favor, insira as informações do produto abaixo:");
Produto produto = new Produto();
Console.Write("Insira o código do produto: ");
produto.Codigo = int.Parse(Console.ReadLine()!);
Console.Write("Insira o nome do produto: ");
produto.Nome = Console.ReadLine()!;
Console.Write("Insira o preço do produto: ");
produto.Preco = decimal.Parse(Console.ReadLine()!);

produto.ExibirInformacoes();