using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo5
{
    class Program
    {
        static void Main(string[] args)
        {
            double cateto1, cateto2, hipotenusa;
            Console.WriteLine("Digite o valor do primeiro cateto:");
            cateto1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do segundo cateto:");
            cateto2 = double.Parse(Console.ReadLine());

            hipotenusa = Math.Sqrt(Math.Pow(cateto1, 2) + Math.Pow(cateto2, 2));
            Console.WriteLine("O resultado da Hipotenusa é :"+ hipotenusa);
            Console.ReadKey();
        }
    }
}
