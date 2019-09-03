using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R06_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int linha = 8, coluna = 6, countMedia = 0;
            int[,] matriz = new int[linha, coluna];
            double media=0;

            for (int c = 0; c < coluna; c++)
            {
                Console.WriteLine("---------------- Coluna "+ (c+1) + "-----------------");

                for (int l = 0; l < linha; l++)
                {
                    Console.WriteLine("Digite a "+(l+1)+"º linha: ");
                    matriz[l, c] = int.Parse(Console.ReadLine());
                }
            }

            for (int c = 0; c < coluna; c++)
            {
                for (int l = 0; l < linha; l++)
                {
                    if (l % 2 == 0)
                    {
                        media+= matriz[l, c]; 
                        countMedia++;
                    }
                }
            }

            Console.WriteLine("A média dos elementos das linhas pares é :" + media / countMedia);
            Console.ReadKey();
        }
    }
}
