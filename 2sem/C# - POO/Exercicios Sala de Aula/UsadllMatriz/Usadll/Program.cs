using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using matrizLibrary;

namespace Usadll
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] MinhaMatriz = OperaMatriz.criaMatriz(4, 7, true, 1, 100);

            OperaMatriz.mostraMatriz(MinhaMatriz);
            Console.ReadKey();

            int[] vetor;
            vetor = OperaMatriz.achaLimites(MinhaMatriz);

            MostraVetor(vetor);

            vetor = OperaMatriz.SomaColunas(MinhaMatriz);

            MostraVetor(vetor);

            vetor = OperaMatriz.SomaLinhas(MinhaMatriz);

            MostraVetor(vetor);
        }

        static void MostraVetor(int[] v)
        {
            Console.WriteLine("\n");

            foreach (int x in v)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\n");
            Console.ReadKey();
        }
    }
}
