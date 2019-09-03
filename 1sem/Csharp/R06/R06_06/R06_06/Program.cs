using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R06_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3];
            double mediaDiagonal = 0;

            for (int l = 0; l < 3; l++)
            {
                Console.WriteLine("---------- Linha " + (l+1) + " ----------");
                
                for (int c = 0; c < 3; c++)
                {
                    Console.Write("Digite o valor da " + (c+1) + "º coluna: ");
                    matriz[l,c] = int.Parse(Console.ReadLine());
                }
            }

            for (int l = 0; l < 3; l++)
            {
                for (int c = 0; c < 3; c++)
                {
                    if(l == c)
                    {
                        mediaDiagonal += matriz[l, c];
                    }
                }
            }

            Console.WriteLine("A média da diagonal principal é: " + mediaDiagonal / 3);
            Console.ReadKey();
        }
    }
}
