using System;
using System.Linq;
using System.Collections.Generic;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] r = new double[10];
            double[] s = new double[10];

            Console.WriteLine("----------- Vetor 1 -------------");
            r = preencheVetor(r);
            Console.WriteLine("----------- Vetor 2 -------------");
            s = preencheVetor(s);

            Console.WriteLine("Resultante: ");
            mostraLista(mesclaVetor(r, s));

            Console.ReadKey();
        }

        static double [] preencheVetor(double [] vetor) {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write("Digite o {0}º número..: ", (i + 1));
                vetor[i] = double.Parse(Console.ReadLine());
            }

            return vetor;
        }

        static List<double> mesclaVetor(double [] r, double [] s)
        {
            var resultante = new List<double>();

            for (int i = 0; i < r.Length; i++)
            {
                resultante.Add(r[i]);
                resultante.Add(s[i]);
            }

            var diferentes = resultante.Distinct().ToList();

            return diferentes;
        }

        static void mostraLista(List<double> resultante)
        {
            foreach (var item in resultante)
            {
                Console.Write("| {0}",item);
            }
        }
    }
}
