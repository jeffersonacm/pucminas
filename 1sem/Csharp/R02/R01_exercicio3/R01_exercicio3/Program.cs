using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R01_exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;
            Console.WriteLine("Digite o primeiro número");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            num2 = double.Parse(Console.ReadLine());

            if(num1 > num2)
            {
                Console.WriteLine("O menor numero é:"+num2);
            } else
            {
                Console.WriteLine("O menor numero é: " + num1);
            }
            Console.ReadKey();

        }
    }
}
