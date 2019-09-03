using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R06_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int semanasL, menor=0;
            double media = 0, diasAcimaMedia=0;

            Console.Write("Informe o número de semanas: ");
            semanasL = int.Parse(Console.ReadLine());

            int[,] matriz = new int[semanasL, 7];
            int[] vetor = new int[semanasL];

            Console.WriteLine("\n");
            for (int l = 0; l < semanasL; l++)
            {
                Console.WriteLine("------------Semana "+ (l+1)+ " ------------");

                for (int c = 0; c < 7; c++)
                {
                    Console.Write("Digite a produção do " + (c+1) +"º dia: ");
                    matriz[l,c] = int.Parse(Console.ReadLine());
                    media += matriz[l, c];
                }
            }

            media = media / (matriz.GetLength(0) * matriz.GetLength(1));

            for (int l = 0; l < semanasL; l++)
            {
                for (int c = 0; c < 7; c++)
                {
                    if (c == 0)
                    {
                        menor = matriz[l, c];
                    }

                    if (matriz[l,c] < menor)
                    {
                        menor = matriz[l, c];
                    }

                    if (matriz[l, c] > media)
                    {
                        diasAcimaMedia++;
                    }
                }

                vetor[l] = menor;
            }

            Console.WriteLine("\nA Produção média é " + media);
            Console.WriteLine("Número de dias com produção acima da média: " + diasAcimaMedia);

            Console.WriteLine("\nINDICAÇÃO DOS DIAS DE MÍNIMA PRODUÇÃO:");

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Semana "+(i+1)+ ".............. Dia "+vetor[i]);
            }

            Console.ReadKey();



        }
    }
}
