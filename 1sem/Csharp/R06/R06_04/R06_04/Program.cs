using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R06_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[5, 5];
            int linhaQuatro = 0, colunaDois = 0, todosElementos = 0;

            for (int l = 0; l < 5; l++)
            {
                 Console.WriteLine("----------- Linha " + (l+1)+" -----------");

                for (int c = 0; c < 5; c++)
                {
                    Console.Write("Digite o valor da " + (c + 1) + "º coluna: ");
                    matriz[l, c] = int.Parse(Console.ReadLine());
                }
            }

            for (int l = 0; l < 5; l++)
            {
                for (int c = 0; c < 5; c++)
                {
                    if (l == 3)
                    {
                        linhaQuatro += matriz[l, c];
                    }

                    if (c == 1)
                    {
                        colunaDois += matriz[l, c];
                    }

                    todosElementos += matriz[l, c];
                }
            }

            Console.WriteLine("\nA soma dos elementos da linha 4 é: "+linhaQuatro);
            Console.WriteLine("A soma dos elementos da coluna 2 é: "+colunaDois);
            Console.WriteLine("A soma de todos os elementos é: "+todosElementos);
            Console.ReadKey();
        }
    }
}
 