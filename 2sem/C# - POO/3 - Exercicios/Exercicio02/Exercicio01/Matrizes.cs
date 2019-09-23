using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Matrizes
    {
        public int [,] matriz;

        public Matrizes(int l = 3, int c = 3) {
            matriz = new int[l, c];
        }

        public Matrizes(int limMin, int limMax, int linha = 3, int coluna = 3) {
            Random ran = new Random();
            matriz = new int[linha, coluna];

            for (int l = 0; l < linha; l++)
            {
                for (int c = 0; c < coluna; c++)
                {
                    matriz[l, c] = ran.Next(limMin, limMax);
                }
            }
        }

        public void PreencheMatriz()
        {
            for (int l = 0; l < matriz.GetLength(0); l++)
            {
                Console.WriteLine("----------- Linha {0} -------------", l+1);
                for (int c = 0; c < matriz.GetLength(1); c++)
                {
                    Console.Write("Coluna {0}: ", c + 1);
                    matriz[l, c] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void ListaMatriz()
        {
            for (int l = 0; l < matriz.GetLength(0); l++)
            {
                for (int c = 0; c < matriz.GetLength(1); c++)
                {
                    Console.Write("| " + matriz[l, c]);
                }

                Console.WriteLine("");
            }
        }
    }
}
