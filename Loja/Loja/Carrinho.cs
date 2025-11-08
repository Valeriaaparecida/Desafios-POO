

namespace Loja
{
    internal class Carrinho
    {
        public List<Produto> Produtos { get; set; } = new List<Produto>();

        public void AdicionarProduto(Produto produto)
        {
            Produtos.Add(produto);
        }
        public void ExibirCarrinho()
        {
           
            Console.WriteLine("Produtos no carrinho:");

            
            decimal total = 0;

            
            if (Produtos.Count == 0)
            {
                Console.WriteLine("Nenhum produto adicionado ainda!");
            }
            else
            {
                
                for (int i = 0; i < Produtos.Count; i++)
                {
                    Produto p = Produtos[i];
                    Console.WriteLine($"{i + 1}. {p.Nome} - R$ {p.Preco:F2}");
                    total += p.Preco; 
                }

                Console.WriteLine($"Total: R$ {total:F2}");
            }


        }
    }
}