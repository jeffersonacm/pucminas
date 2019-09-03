using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R05_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];
            int aux;

            for(int i = 0; i < vetor.Length ; i++)
            {
                Console.Write("Digite o "+(i + 1)+"º número: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            for (int i = vetor.Length -1; i >= 0; i--)
            {
                for (int x = (i - 1); x >= 0; x--)
                {
                    if(vetor[i] < vetor[x])
                    {
                        aux = vetor[i];
                        vetor[i] = vetor[x];
                        vetor[x] = aux;
                    }
                }
            }
            
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine(vetor[i]);
            }

            Console.ReadKey();
        }
    }
}
