using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;

            Console.WriteLine("Os números perfeitos são...: ");

            for (int x = 2; x < 1000; x++)
            {
                soma = 0; 

                for (int i = x; i > 0; i--)
                {
                    if (x != i && x % i == 0) {
                        soma += i;
                    }
                }

                if (soma == x)
                {
                    Console.Write(" | {0}", x);
                }
            }

            Console.ReadLine();
        }
    }
}
