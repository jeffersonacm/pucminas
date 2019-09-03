using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R01_exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, result;

            Console.Title = "Média ponderada";
            Console.WriteLine("Digite a primeira nota:");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota:");
            nota2 = double.Parse(Console.ReadLine());

            result = ((nota1 * 2) + (nota2 * 3)) / 5;

            Console.WriteLine("A média ponderada é:"+result);
            Console.ReadKey();
        }
    }
}
