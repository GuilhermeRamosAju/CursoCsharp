using System;
using System.Globalization;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre os dados do produto:");
            
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());

            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p =  new Produto(nome, preco, quantidade);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            if (int.TryParse(Console.ReadLine(), out int qteAdicionar))
            {
                p.AdicionarProdutos(qteAdicionar);
            }
            else
            {
                Console.WriteLine("Quantidade inválida.");
            }

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            if (int.TryParse(Console.ReadLine(), out int qteRemover))
            {
                p.RemoverProdutos(qteRemover);
            }
            else
            {
                Console.WriteLine("Quantidade inválida.");
            }

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
