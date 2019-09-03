using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Program
    {
        /*
            Preencha matriz 4x4, depois some os elementos da diagonal principal,
            mostre os elementos abaixo da diagonal e a matriz completa
        */
        static void Main(string[] args)
        {
            int[,] matriz = new int[4, 4];
            int soma=0;

            for (int c = 0; c < 4; c++)
            {
                Console.WriteLine("------------- Coluna "+(c+1)+ " -------------");

                for (int l = 0; l < 4; l++)
                {
                    Console.Write("Digite o "+(l+1)+"º número: ");
                    matriz[l, c] = int.Parse(Console.ReadLine());
                }
            }

            
                // i != c && l > c
            for (int c = 0; c < 4; c++)
            {
                for (int l = 0; l < 4; l++)
                {
                    if(c == l)
                    {
                        soma += matriz[l, c];
                    }
                }
            }

            Console.WriteLine("A soma da diagonal principal é: "+soma);

            Console.WriteLine("Os números abaixo da diagonal são: ");

            for (int c = 0; c < 4; c++)
            {
                for (int l = 0; l < 4; l++)
                {
                    if (l != c && l < c)
                    {
                        Console.Write(matriz[l,c]+" | ");
                    }
                }
            }

            Console.WriteLine("\nA matriz digitada foi:");

            for (int c = 0; c < 4; c++)
            {
                for (int l = 0; l < 4; l++)
                {
                    Console.Write(matriz[l,c] + " | ");
                }
                Console.WriteLine("\n");
            }

            Console.ReadKey();
        }
    }
}
