using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vetor com 10 posições");
            CVetor vetor = new CVetor();

            Console.WriteLine("Digite o tamanho");
            CVetor vetorN = new CVetor(int.Parse(Console.ReadLine()));

            Console.ReadKey();
        }
    }
}
