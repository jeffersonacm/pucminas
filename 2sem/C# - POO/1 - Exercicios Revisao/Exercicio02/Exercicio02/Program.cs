using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            double mediaM = 0;
            double altura = 0;
            double maior = 0;
            double menor = 0;
            char sexo;
            int quantH = 0;

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("-------------------------");
                Console.Write("\nDigite o sexo M ou F.....: ");
                sexo = char.Parse(Console.ReadLine());
                
                Console.Write("Digite a altura..........: ");
                altura = double.Parse(Console.ReadLine());

                if (sexo == 'M')
                    quantH++;
                else 
                    mediaM += altura;
                
                if (i == 0)
                {
                    maior = altura;
                    menor = altura;
                }

                if (maior < altura)
                    maior = altura;

                if (menor > altura)
                    menor = altura;
            }

            Console.WriteLine("A maior altura é {0} e a menor altura é {1}", maior, menor);
            Console.WriteLine("A media de altura das mulheres é {0}", mediaM / 15 - quantH);
            Console.WriteLine("A quantidade de homens é {0}", quantH);
            Console.ReadKey();
        }
    }
}
