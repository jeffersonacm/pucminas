using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0.8, b = 1.30;
            int ano = 0;

            while (b > a) {
                a += 0.12;
                b += 0.08;

                ano++;
            }

            Console.WriteLine("Em {0} anos a árvore A vai ser maior que a arvore B", ano);
            Console.ReadKey();
        }
    }
}
