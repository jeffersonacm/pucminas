using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R06_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[4, 4];
            int multiplicacao;

            for (int c = 0; c < 4; c++)
            {
                Console.WriteLine("-------------- Coluna "+(c+1)+ " --------------");

                for(int l = 0; l < 4; l++)
                {
                    Console.WriteLine("Digite um valor para a "+(l+1)+"º linha: ");
                    matriz[l, c] = int.Parse(Console.ReadLine()); 
                }
            }

            Console.Write("\nDigite um número para multiplicação: ");
            multiplicacao = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");

            for (int c = 0; c < 4; c++)
            {
                for (int l = 0; l < 4; l++)
                {
                    Console.WriteLine(matriz[l, c] +" x "+ multiplicacao +" = "+ matriz[l, c] * multiplicacao);
                }
            }

            Console.ReadLine();
        }
    }
}
