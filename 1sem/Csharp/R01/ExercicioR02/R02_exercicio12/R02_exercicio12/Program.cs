using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R02_exercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, resultado;

            Console.WriteLine("Informe o salário:");
            salario = double.Parse(Console.ReadLine());

            if (salario <= 350)
            {
                resultado = salario + 100;
            } else if (salario > 350 && salario < 600)
            {
                resultado = salario + 75;
            } else if (salario >= 600 && salario <= 900)
            {
                resultado = salario + 50;
            } else
            {
                resultado = salario + 35;
            }
            resultado = resultado - (resultado * 0.07);
            Console.WriteLine("O novo salario é " + resultado);
            Console.ReadKey();
        }
    }
}
