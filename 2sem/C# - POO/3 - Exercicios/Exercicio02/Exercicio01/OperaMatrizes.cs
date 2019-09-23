using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class OperaMatrizes:Matrizes
    {
        public OperaMatrizes(int l = 3, int c = 3)
        {
        }

        public OperaMatrizes(int limMin, int limMax, int linha = 3, int coluna = 3)
        {
        }

        public void MultiplicaMatriz(Matrizes matriz1, Matrizes matriz2)
        {
            int linha = matriz1.matriz.GetLength(0);
            int coluna = matriz1.matriz.GetLength(1);
            Matrizes result = new Matrizes(linha, coluna);

            for (int l = 0; l < linha; l++)
            {
                for (int c = 0; c < coluna; c++)
                {
                    matriz[l, c] = matriz1.matriz[l, c] * matriz2.matriz[l, c];
                }
            }
        }
    }
}
