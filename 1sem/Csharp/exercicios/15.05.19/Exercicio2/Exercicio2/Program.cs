using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int linha, coluna;

            Console.Write("Digite o número de colunas: ");
            coluna = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de linhas: ");
            linha = int.Parse(Console.ReadLine());

            int[,] matriz = new int[linha, coluna];
            int[,] matrizInvetida = new int[coluna, linha];

            Console.WriteLine("\n");
            for (int l = 0; l < linha; l++)
            {
                Console.WriteLine("------------- Linha "+ (l+1) + " -------------");

                for (int c = 0; c < coluna; c++)
                {

                    Console.Write("Digite o valor da " + (c + 1) + "º coluna: ");
                    matriz[l,c] = int.Parse(Console.ReadLine());
                }
            }

            for (int l = 0; l < coluna; l++)
            {
                for (int c = 0; c < linha; c++)
                {
                    matrizInvetida[l,c] = matriz[c , l];
                    //Console.WriteLine(matrizInvetida[c, l]);
                }
                Console.WriteLine("\n");
            }

            //impressao matriz normal
            Console.WriteLine("Matriz normal: \n");

            for (int l = 0; l < linha; l++) //3
            {
                for (int c = 0; c < coluna; c++) //2
                {
                    Console.Write(matriz[l, c] + " | ");
                }
                Console.WriteLine("\n");
            }


            //impressão matriz invertida
            Console.WriteLine("Matriz invertida: \n");

            for (int l = 0; l < coluna; l++) //3
            {
                for (int c = 0; c < linha; c++) //2
                {
                    Console.Write(matrizInvetida[l,c]+" | ");
                }
                Console.WriteLine("\n");
            }

            Console.ReadKey();
        }
    }
}
