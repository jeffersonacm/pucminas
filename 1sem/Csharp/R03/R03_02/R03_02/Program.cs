using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R03_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,i,soma=0,a=0,b=1;
            Console.WriteLine("Qual o termo da sequencia fibonacci deseja ?");
            n = int.Parse(Console.ReadLine());

            if (n == 1)
            {
                Console.WriteLine("O valor é "+a);
            } else if (n==2)
            {
                Console.WriteLine("O valor é "+b);
            } else if (n >= 3)
            {
                for (i = 3; i <= n; i++)
                {
                    soma = a + b;
                    a = b;
                    b = soma;
                }
                Console.WriteLine("O valor é "+ soma);
            }
            Console.ReadKey();
        }
    }
}
