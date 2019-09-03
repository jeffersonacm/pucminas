using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R02_exercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorProduto, result;
            Console.WriteLine("Digite o valor do produto: ");
            valorProduto = double.Parse(Console.ReadLine());

            if(valorProduto <= 50)
            {
                result = valorProduto + (valorProduto * 0.05);
            } else if (valorProduto > 50 && valorProduto < 100)
            {
                result = valorProduto + (valorProduto * 0.10);
            } else
            {
                result = valorProduto + (valorProduto * 0.15);
            }

            if(result < 80)
            {
                Console.WriteLine("O seu produto é classificado como barato, valor:" +result);
            } else if (result >= 80 && result <= 120)
            {
                Console.WriteLine("O seu produto é classificado como normal, valor:" + result);
            } else if (result >= 120 && result <= 200)
            {
                Console.WriteLine("O seu produto é classificado como caro, valor:" + result);
            } else
            {
                Console.WriteLine("O seu produto é classificado como muito caro, valor:" + result);
            }
            Console.ReadKey();
        }
    }
}
