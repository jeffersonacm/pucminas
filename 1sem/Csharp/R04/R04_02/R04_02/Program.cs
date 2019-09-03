using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R04_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0;
            double lucro = 0, desconto = 0, idade = 0;

            while (idade != -1)
            {
                i++;
                Console.WriteLine("Informe a "+ i + "º idade: (Digite -1 para sair)");

                idade = double.Parse(Console.ReadLine());

                if(idade > 130)
                {
                    Console.WriteLine("Não estrague meu programa");
                    i--;
                    continue;
                }

                if(idade != -1)
                {
                    desconto = ((idade / 2) * 1000) / 100;
                    lucro += 1000 - desconto;
                    Console.WriteLine("O percentual de desconto é de "+ (idade / 2) + "% \n" +
                        "O valor a ser pago é "+ (1000 - desconto)+ "$ \n");
                }
            }
            Console.WriteLine("O lucro da loja foi de "+ lucro+"$");
            Console.ReadKey();
        }
    }
}
