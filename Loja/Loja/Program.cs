using Loja;

Carrinho carrinho = new Carrinho();
string opcao;

Console.WriteLine("=== SISTEMA DE LOJA ===");

do
{
    Console.WriteLine("\nDigite o código do produto:");
    int codigo = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o nome do produto:");
    string nome = Console.ReadLine();

    Console.WriteLine("Digite o preço do produto:");
    decimal preco = decimal.Parse(Console.ReadLine());

    // Cria o produto e adiciona ao carrinho
    Produto produto = new Produto(codigo, nome, preco);
    carrinho.AdicionarProduto(produto);

    Console.WriteLine("Produto adicionado com sucesso!");

    Console.WriteLine("\nDeseja adicionar outro produto? (s/n)");
    opcao = Console.ReadLine().ToLower();

} while (opcao == "s");


Console.WriteLine("\nResumo da compra:");
carrinho.ExibirCarrinho();

Console.WriteLine("Pressione ENTER para sair...");
Console.ReadLine();