using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R05_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor1 = new int[5];
            int[] vetor2 = new int[5];
            int[] vetor3 = new int[10];
            int key = 0;

            for(int i = 0; i < vetor1.Length; i++)
            {
                Console.Write("Digite o "+ (i + 1) +"º número do vetor 1: ");
                vetor1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n");

            for (int i = 0; i < vetor2.Length; i++)
            {
                Console.Write("Digite o " + (i + 1) + "º número do vetor 2: ");
                vetor2[i] = int.Parse(Console.ReadLine());
            }
            
            for(int i = 0; i < 5; i++)
            {
                vetor3[key] = vetor1[i];
                key++;
                vetor3[key] = vetor2[i];
                key++;
            }

            Console.WriteLine("Vetores intercalados:");
             
            for (int i = 0; i < vetor3.Length; i++){
                Console.WriteLine(vetor3[i]);
            }

            Console.ReadKey();
        }
    }
}
