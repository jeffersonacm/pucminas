using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, inverso;

            Console.WriteLine("Digite o numero: ");

            num = int.Parse(Console.ReadLine());
            inverso = Inverso(num);

            if(num == inverso)
                Console.WriteLine("O numero é palíndromo! ");
            else
                Console.WriteLine("O numero não é palíndromo! ");

            Console.ReadKey();
        }

        static int Inverso(int num) {
            int inverso = 0, antigo;

            for (; num > 0;)
            {
                antigo = num % 10;
                inverso = inverso * 10 + antigo;
                num /= 10;
            }

            return inverso;
        }
    }
}
