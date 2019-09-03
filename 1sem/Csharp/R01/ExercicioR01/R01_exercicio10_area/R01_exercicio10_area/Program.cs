using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R01_exercicio10_area
{
    class Program
    {
        static void Main(string[] args)
        {
            double lado, result; 
            Console.Title = "Área do quadrado";
            Console.WriteLine("Digite o valor do lado:");
            lado = double.Parse(Console.ReadLine());

            result = Math.Pow(lado, 2);
            
            Console.WriteLine("A área do quadrado é:"+result);
            Console.ReadKey();
        }
    }
}
