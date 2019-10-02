using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrizLibrary
{
    public static class OperaMatriz
    {
        public static int[,] criaMatriz(int l, int c, bool random, int li = 0, int ls = 10)
        {
            if(!random)
            {
                return new int[l, c];
            } else
            {
                Random x = new Random();

                int[,] matriz= new int[l, c];

                for (int i = 0; i < l; i++)
                {
                    for (int j = 0; j < c; j++)
                    {
                        matriz[i, j] = x.Next(li, ls + 1);
                    }
                }

                return matriz;
            }

        }

        public static void mostraMatriz(int [,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"{matriz[i, j],6}");
                }
            }

            Console.ReadKey();
        }

        public static int[] achaLimites(int[,] m)
        {
            int[] vetor = new int[2];
            int menor = m[0, 0];
            int maior = m[0, 0];

            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    if(m[i, j] < menor)
                    {
                        menor = m[i, j];
                    }

                    if (m[i, j] > maior)
                    {
                        maior = m[i, j];
                    }
                }
            }

            vetor[0] = menor;
            vetor[1] = maior;

            return vetor;
        }

        public static int[] SomaLinhas(int[,] m)
        {
            int[] vetor = new int[m.GetLength(0)];
            int soma;

            for (int i = 0; i < m.GetLength(0); i++)
            {
                soma = 0;

                for (int j = 0; j < m.GetLength(1); j++)
                {
                    soma += m[i, j];
                }

                vetor[i] = soma;
            }

            return vetor;
        }

        public static int[] SomaColunas(int[,] m)
        {
            int[] vetor = new int[m.GetLength(1)];
            int soma;

            for (int i = 0; i < m.GetLength(1); i++)
            {
                soma = 0;

                for (int j = 0; j < m.GetLength(0); j++)
                {
                    soma += m[j, i];
                }

                vetor[i] = soma;
            }

            return vetor;
        }
    }
}
