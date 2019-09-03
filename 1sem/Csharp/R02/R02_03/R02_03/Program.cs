using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R02_03
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, result;


            Console.WriteLine("Digite a nota do trabalho de laboratorio:");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota da avaliação semestral:");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota exame final:");
            n3 = double.Parse(Console.ReadLine());

            n1 = n1 * 2;
            n2 = n2 * 3;
            n3 = n3 * 5;

            result = (n1 + n2 + n3) / 10;
            Console.WriteLine("Sua nota final é:" + result);
            Console.ReadKey();
        }
    }
}
