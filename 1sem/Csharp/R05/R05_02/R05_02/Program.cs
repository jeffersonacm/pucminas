using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R05_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor1 = new int[15];
            int quantDois = 0;
            string multiplo2 = "", multiplo3 = "";

            for (int i = 0; i < vetor1.Length; i++)
            {
                Console.Write("Digite o " + (i + 1) + "º número: ");
                vetor1[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vetor1.Length; i++)
            {
                if (vetor1[i] == 2)
                {
                    quantDois++;
                }

                if (vetor1[i] % 3 == 0 && vetor1[i] > 1)
                {
                    multiplo3 += "|" + vetor1[i] + "|";
                }

                if (vetor1[i] % 2 == 0 && vetor1[i] > 1)
                {
                    multiplo2 += "|" + i + "|";
                }
            }

            Console.WriteLine("A quantidade de posições com elementos iguais a 2 é \n" + quantDois);
            Console.WriteLine("Os elementos (números) múltiplos de 3 são:\n " + multiplo3);
            Console.WriteLine("As posições que possuem elementos (números) múltiplos de 2:\n " + multiplo2);
            Console.ReadKey();
        }
    }
}
