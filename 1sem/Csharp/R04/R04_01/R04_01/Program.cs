using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R04_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i=1;
            double maior=0, menor=0,num;

            Console.Title = "Maior e menor número";
            Console.WriteLine("Digite a quantidade de números que deseja digitar:");
            n = int.Parse(Console.ReadLine());

            while(i <= n)
            {
                Console.WriteLine("Digite o "+i+"º número");

                num = double.Parse(Console.ReadLine());

                if (i == 1)
                {
                    maior = num;
                    menor = num;
                }

                if (num > maior)
                    maior = num;
                if (num < menor)
                    menor = num;
                i++;
            }
            Console.WriteLine("O maior número é:"+maior+"\n" +
                "O menor número é:"+menor);
            Console.ReadKey();
        }
    }
}
