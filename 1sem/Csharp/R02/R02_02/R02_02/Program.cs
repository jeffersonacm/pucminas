using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R02_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, x2, x3;
            Console.WriteLine("Digite o primeiro numero:");
            x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero:");
            x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro numero:");
            x3 = int.Parse(Console.ReadLine());
 
            if (x1 > x2 && x2 > x3)
            {
                Console.WriteLine("Os numeros digitados em ordem decrescente são:" + x1 + '-' + x2 + '-' + x3);
            }
            else if (x1 > x2 && x3 > x2 && x1 > x3)
            {
                Console.WriteLine("Os numeros digitados em ordem decrescente são:" + x1 + '-' + x3 + '-' + x2);
            }
            else if (x2 > x1 && x1 > x3 && x2 > x1)
            {
                Console.WriteLine("Os numeros digitados em ordem decrescente são:" + x2 + '-' + x1 + '-' + x3);
            }
            else if (x2 > x3 && x3 > x1 && x2 > x3)
            {
                Console.WriteLine("Os numeros digitados em ordem decrescente são:" + x2 + '-' + x3 + '-' + x1);
            }
            else if (x3 > x1 && x1 > x2 && x3 > x2)
            {
                Console.WriteLine("Os numeros digitados em ordem decrescente são:" + x3 + '-' + x1 + '-' + x2);
            }
            else if (x3 > x1 && x2 > x1 && x3 > x1)
            {
                Console.WriteLine("Os numeros digitados em ordem decrescente são:" + x3 + '-' + x2 + '-' + x1);
            }
            Console.ReadKey();
        }
    }
}
