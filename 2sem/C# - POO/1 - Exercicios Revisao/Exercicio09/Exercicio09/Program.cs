using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vetor = new double[10];

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write("Digite um numero: ");
                vetor[i] = double.Parse(Console.ReadLine());
            }

            multiplo(vetor);
        }

        static void multiplo (double [] vetor)
        {
            int multiplo = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                if(vetor[i] % 3 == 0)
                {
                    multiplo++;
                }
            }

            Console.WriteLine("O vetor informado possui {0} multiplos de 3", multiplo);
            Console.ReadKey();
        }
    }
}
