using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R02_06
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2;
            int opcao;

            Console.WriteLine("Digite o primeiro numero");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero");
            n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Escolha uma opção \n 1-O primeiro número elevado ao segundo número \n 2-Raiz quadrada de cada um dos números");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Console.WriteLine("O resultado é "+ Math.Pow(n1, n2));

            } else if (opcao == 2)
            {
                Console.WriteLine("As raizes são: " + Math.Sqrt(n1) +" e "+ Math.Sqrt(n2));
            } else
            {
                Console.WriteLine("Opção digitada não corresponde as opções");
            }
            Console.ReadKey();




            //
        }
    }
}
