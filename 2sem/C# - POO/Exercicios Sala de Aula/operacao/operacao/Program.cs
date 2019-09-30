using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operacao
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, result;
            Console.Write("X: ");
            x = double.Parse(Console.ReadLine());

            Console.Write("Y: ");
            y = double.Parse(Console.ReadLine());

            result = setaOperacao(new Soma(), x, y);
            Console.WriteLine("\n Soma: {0}", result);

            result = setaOperacao(new Subtracao(), x, y);
            Console.WriteLine("\n Subtração: {0}", result);

            Console.ReadKey();
        }

        static double setaOperacao(OperacaoMatematica op, double x, double y)
        {
            return op.calcular(x, y);
        }
    }
}
