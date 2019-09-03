using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            double salarioAtual, salarioNovo, porcentagem;
            Console.WriteLine("Digite o salário atual:");
            salarioAtual = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a porcentagem de aumento:");
            porcentagem = double.Parse(Console.ReadLine());
            salarioNovo = salarioAtual + (porcentagem * salarioAtual / 100);
            Console.WriteLine("O salário novo é:" + salarioNovo);
            Console.ReadKey();
        }
    }
}
