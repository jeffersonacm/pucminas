using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor1 = new int[10] { 11, 23, 44, 51, 21, 90, 23, 4, 44, 6};
            int[] vetor2 = new int[10] { 14, 31, 43, 55, 63, 62, 36, 48, 49, 63};
            int[] vetor3 = new int[10];

            for (int i = 0; i < 10; i++)
            {
                vetor3[i] = vetor1[i] + vetor2[i];
            }

            Console.WriteLine("A soma dos vetores é: ");

            mostraVetor(vetor3);

            Console.ReadKey();
        }

        static void mostraVetor(int[] vetor)
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write(" | {0}", vetor[i]);
            }
        }
    }
}
