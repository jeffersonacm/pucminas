using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R06_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int linhas, colunas, elementos=0;

            Console.WriteLine("Digite o número de linhas: ");
            linhas = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de colunas");
            colunas = int.Parse(Console.ReadLine());

            int[,] matriz = new int[linhas, colunas];

            for (int c = 0; c < colunas; c++)
            {
                Console.WriteLine("-----------------Coluna " + (c+1) + " ----------------");

                for (int l = 0; l < linhas; l++)
                {
                    Console.Write("Digite o numero para a "+(l+1)+"º linha: ");
                    matriz[l, c] = int.Parse(Console.ReadLine());
                }

            }

            for( int c = 0; c < colunas; c++)
            {
                for( int l = 0; l < linhas; l++)
                {

                    //Console.WriteLine(l);
                    if (matriz[l,c] > 15 && matriz[l,c] < 25)
                    {
                        elementos++;
                    }
                }
            }

            Console.WriteLine("\nO número de elementos maior que 15 e menor que 25 é: "+elementos);

            Console.ReadKey();
        }
    }
}
