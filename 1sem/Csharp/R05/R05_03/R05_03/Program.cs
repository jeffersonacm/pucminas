using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R05_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor1 = new int[6];
            int[] vetor2 = new int[6];
            int[] vetor3 = new int[6];
            int pos2 = 0, pos3 = 0;

            for(int i = 0; i < vetor1.Length; i++)
            {
                Console.Write("Digite o "+(i+1)+"º número: ");
                vetor1[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vetor1.Length; i++)
            {

                if (vetor1[i] % 3 == 0 && vetor1[i] != 0)
                {
                    vetor2[pos2] = vetor1[i];
                    pos2++;
                } else
                {
                    vetor3[pos3] = vetor1[i];
                    pos3++;
                }
            }

            Console.WriteLine("Primeiro vetor");
            for (int i=0; i < pos2; i++)
            {
                Console.WriteLine(" | "+vetor2[i]);
            }

            Console.WriteLine("\nSegundo vetor");
            for (int i = 0; i < pos3; i++)
            {
                Console.WriteLine(" | " + vetor3[i]);
            }

            Console.ReadKey();
          
        }
    }
}
