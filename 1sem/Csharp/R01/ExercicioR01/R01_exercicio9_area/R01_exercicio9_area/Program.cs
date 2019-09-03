using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R01_exercicio9_area
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseMenor, baseMaior, altura, result;
            Console.Title = "Área do trapézio";
            Console.WriteLine("Digite o valor da base menor");
            baseMenor = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da base maior");
            baseMaior = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da altura");
            altura = double.Parse(Console.ReadLine());

            result = ((baseMaior + baseMenor) * altura) / 2;

            Console.WriteLine("A área do trapézio é:" + result);
            Console.ReadKey();
        }
    }
}
