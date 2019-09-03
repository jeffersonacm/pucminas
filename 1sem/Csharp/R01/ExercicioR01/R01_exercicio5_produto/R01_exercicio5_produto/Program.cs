using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R01_exercicio5_produto
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco, novoPreco;

            Console.Title = "Reajuste preço do produto";
            Console.WriteLine("Digite o preço do produto:");
            preco = double.Parse(Console.ReadLine());

            novoPreco = preco - (preco * 0.10);

            Console.WriteLine("O preço do produto com reajuste é de:" +novoPreco+"R$");
            Console.ReadKey();
        }
    }
}
