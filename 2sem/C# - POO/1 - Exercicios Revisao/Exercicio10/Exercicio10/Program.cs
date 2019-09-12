using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3];
            int[] vetor = new int[6];

            for (int l = 0; l < 3; l++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Console.WriteLine("Digite um numero: ");
                    matriz[l, c] = int.Parse(Console.ReadLine());
                }
            }

            int i = 0;
            for (int l = 0; l < 3; l++)
            {
                for (int c = 0; c < 3; c++)
                {
                    if (l != c)
                    {
                        vetor[i] = matriz[l, c];
                        i++;
                    }
                }
            }

            for (int F = 0; F < 6; F++)
            {
                Console.Write("| {0}", vetor[F]);
            }

            Console.ReadKey();
        }
    }
}
