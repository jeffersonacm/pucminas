using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R01_exercicio02_hipotenusa
{
    class Program
    {
        static void Main(string[] args)
        {
            double fistCateto, secondCateto;
            Console.WriteLine("Digite o valor do primeiro cateto:");
            fistCateto = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do segundo cateto:");
            secondCateto = double.Parse(Console.ReadLine());
            Console.WriteLine("O valor da Hipotenusa é :" + Math.Sqrt(Math.Pow(fistCateto, 2) + Math.Pow(secondCateto, 2)));
            Console.ReadKey();
        }
    }
}
