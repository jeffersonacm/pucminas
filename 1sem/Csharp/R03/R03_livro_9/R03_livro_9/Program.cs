using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R03_livro_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade=0, i, mediaIdade=0,countPesoAltura = 0, countIdadeAltura=0;
            double peso;
            decimal altura;

            for(i=1; i<=10; i++)
            {
                Console.WriteLine("Informe a idade da "+i+"º pessoa");
                idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe a peso da " + i + "º pessoa");
                peso = double.Parse(Console.ReadLine());

                Console.WriteLine("Informe a altura da " + i + "º pessoa (em centímetros)");
                altura = decimal.Parse(Console.ReadLine());

                mediaIdade = mediaIdade + idade;

                if (peso > 90 && altura < 1.50)
                {
                    countPesoAltura++;
                }

                if (idade > 10 && idade < 30 && altura > 190)
                {
                    countIdadeAltura++; 
                }
                
            }
            mediaIdade = mediaIdade / i;

            Console.WriteLine("A media das idades é: "+mediaIdade + " anos\n" +
                "A quantidade de pessoas com peso maior que 90 e altura menor que 150 cm é de: "+countPesoAltura+"\n"+
                "A quantidade de pessoas com a idade entre 10 e 30 anos e altura superior a 190 cm é de :" + countIdadeAltura);
            Console.ReadKey();
        }
    }
}
