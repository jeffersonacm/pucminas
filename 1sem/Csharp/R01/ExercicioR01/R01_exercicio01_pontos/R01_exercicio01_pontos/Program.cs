using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R01_exercicio01_pontos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Distância entre pontos";

            double x1, x2, y1, y2, subtr1, subtr2, result;
            Console.WriteLine("Digite o X1: ");
            x1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o X2: ");
            x2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Y1: ");
            y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Y2: ");
            y2 = double.Parse(Console.ReadLine());

            subtr1 = x2 - x1;
            subtr2 = y2 - y1;

            result = Math.Sqrt(Math.Pow(subtr1, 2) + Math.Pow(subtr2, 2));
            Console.WriteLine("Resultado é: " + result);
            Console.ReadKey();
        }
    }
}
