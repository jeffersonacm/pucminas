using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R02_exercicio20
{
    class Program0
    {
        static void Main(string[] args)
        {
            int idade;

            Console.WriteLine("Informe sua idade");
            idade = int.Parse(Console.ReadLine());

            if(idade >= 5 && idade <= 7)
            {
                Console.WriteLine("Sua categoria é infantil");
            } else if (idade >= 8 && idade <=10) {
                Console.WriteLine("Sua categoria é juvanil");
            } else if (idade >= 11 && idade <= 15)
            {
                Console.WriteLine("Sua categoria é adolescente");
            } else if (idade >= 16 && idade <= 30)
            {
                Console.WriteLine("Sua categoria é adulto");
            } else if (idade > 30)
            {
                Console.WriteLine("Sua categoria é senior");
            } else
            {
                Console.WriteLine("Sua idade não corresponde a nenhuma categoria");
            }
            Console.ReadKey();
        }
    }
}
