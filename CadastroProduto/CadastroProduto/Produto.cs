using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroProduto
{
    internal class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Código: {Codigo}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Preço: {Preco:C2}");
        }


    }
}
