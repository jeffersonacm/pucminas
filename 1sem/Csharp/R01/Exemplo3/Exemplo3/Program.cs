using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result;

            Console.WriteLine("Digite o primeiro número");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            num2 = int.Parse(Console.ReadLine());
            result = (num1 + num2) * num1;
            Console.WriteLine("O resultado é: " + result);
            Console.ReadKey();
        }
    }
}
