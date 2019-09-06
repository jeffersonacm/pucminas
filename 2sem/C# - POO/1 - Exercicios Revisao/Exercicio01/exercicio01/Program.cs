using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, a = 0, b = 100;

            Console.WriteLine("Digite um número....: ");
            n = double.Parse(Console.ReadLine());

            for (int i = 2; i <= n; i++)
            {
                a+= (n - 1) / n;
            }

            for (double i = 1; i <= n; i++)
            {
                b += (i * -1); 
            }

            Console.WriteLine("a....: {0}", a);
            Console.WriteLine("b....: {0}", b);
            Console.ReadKey();
        }
    }
}
