using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int opTam, linhas = 3, colunas = 3, opLim, limMin, limMax;


            Console.WriteLine("Opções: \n 1 - Sim \n 2 - Não");
            Console.Write("Deseja um tamanho personalizado para matriz ?: ");
            opTam = int.Parse(Console.ReadLine());

            if(opTam == 1)
            {
                Console.Write("Digite a quantidade de linhas: ");
                linhas = int.Parse(Console.ReadLine());

                Console.Write("Digite a quantidade de colunas: ");
                colunas = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nOpções: \n 1 - Sim \n 2 - Não");
            Console.Write("Deseja que os numeros da matriz sejam gerados randomicamente ?: ");
            opLim = int.Parse(Console.ReadLine());

            if(opLim == 1)
            {
                Console.Write("\nDigite o limite inicial: ");
                limMin = int.Parse(Console.ReadLine());

                Console.Write("Digite o limite final: ");
                limMax = int.Parse(Console.ReadLine());
            
                Matrizes mat = new Matrizes(limMin, limMax, linhas, colunas);
                mat.ListaMatriz();
            } else
            {
                Matrizes mat = new Matrizes(linhas, colunas);
                mat.PreencheMatriz();
                mat.ListaMatriz();
            }

            Console.ReadKey();
        }
    }
}
