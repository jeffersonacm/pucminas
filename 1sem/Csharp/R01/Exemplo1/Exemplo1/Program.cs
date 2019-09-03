using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, soma;
            Console.WriteLine("Digite o valor de X");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de Y");
            y = int.Parse(Console.ReadLine());
            soma = x + y;
            Console.WriteLine("A soma é: " + soma);
            Console.ReadKey();                  
        }
    }
}
