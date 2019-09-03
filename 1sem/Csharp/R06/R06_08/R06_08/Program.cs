using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R06_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor1 = new int[10];
            int[] vetor2 = new int[10];
            int[] vetor3 = new int[10];

            for (int i = 0; i < vetor1.Length; i++)
            {
                Console.WriteLine("Digite o "+(i+1)+ "º numero do vetor 1");
                vetor1[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vetor2.Length; i++)
            {
                Console.WriteLine("Digite o " + (i + 1) + "º numero do vetor 2");
                vetor2[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vetor3.Length; i++)
            {
                Console.WriteLine("Digite o " + (i + 1) + "º numero do vetor 3");
                vetor3[i] = int.Parse(Console.ReadLine());
            }

            

        }
    }
}
