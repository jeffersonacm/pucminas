using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetor02
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] vetorA = new int[10];
            int [] vetorB = new int[10];
            double sub=0;

            for (int i = 0; i < vetorA.Length; i++)
            {
                Console.WriteLine("Digite um número (VETOR A)");
                vetorA[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine("Digite um número (VETOR B)");
                 vetorB[i] = int.Parse(Console.ReadLine());
                //Console.WriteLine(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < vetorA.Length; i++)
            {
                sub += vetorA[i] - vetorB[i];
            }

            Console.WriteLine("O resultado é "+sub);
            Console.ReadKey();


        }
    }
}
