using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R02_exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3;
            Console.WriteLine("Digite o primeiro número");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número");
            num3 = double.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("O maior numero é:" + num1);
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("O maior numero é: " + num2);
            }
            else
            {
                Console.WriteLine("O maior numero é: " + num3);
            }
            Console.ReadKey();
        }
    }
}
