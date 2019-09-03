using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R02_exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            double salarioAtual, salarioNovo = 0;
            Console.WriteLine("Informe o salário:");
            salarioAtual = double.Parse(Console.ReadLine());

            if (salarioAtual < 500)
            {
                salarioNovo = salarioAtual + (salarioAtual * 0.30);
                Console.WriteLine("O novo salário é: "+salarioNovo);
            } else
            {
                Console.WriteLine("O seu salário não atende os requisitos para reajuste");
            }
            Console.ReadKey();
        }
    }
}
