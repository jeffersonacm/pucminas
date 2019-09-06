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
            int n = 1;
            int divisor;
            int perfeito;
            int soma = 0;

            for (int x = 0; x < 1000; x++)
            {

                for (int i = n; i > 0; i--)
                {
                    soma = 0;

                    if (i % 2 == 0) {
                        soma += i;
                    }

                    if(soma == n)
                    {

                    }
                }
            }

            Console.ReadLine();
        }
    }
}
