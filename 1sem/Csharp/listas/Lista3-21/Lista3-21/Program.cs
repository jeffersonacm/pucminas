using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int qnt, qntPositivo=0, qntNegativo=0;

            Console.WriteLine("Informe a quantidade de nmeros");
            qnt = int.Parse(Console.ReadLine());
            int []vetor = new int[qnt];

            for(int i=0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite o "+ (i+1)+"º numero");
                vetor[i] = int.Parse(Console.ReadLine());
            }

                Console.Write("\nA sequencia digitada foi:");
            for(int i=0; i <vetor.Length; i++)
            {
                Console.Write(" | "+vetor[i]);

                if(vetor[i] >= 0)
                {
                    qntPositivo++;
                } else
                {
                    qntNegativo++;
                }

            }

            Console.WriteLine("\nNumeros positivos: " +qntPositivo);
            Console.WriteLine("Numeros negativos: " + qntNegativo);
            Console.ReadKey();




        }
    }
}
