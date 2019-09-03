using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R01_exercicio17_mat
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, comprimento, area, volume;
            Console.Title = "Calculos matemáticos de uma esfera";
            Console.WriteLine("Infome o valor do raio");
            raio = double.Parse(Console.ReadLine());

            comprimento = 2 * Math.PI * raio;
            area = 4 * Math.PI * Math.Pow(raio, 2);
            volume = (4 * Math.PI * Math.Pow(raio, 3)) / 3;

            Console.WriteLine("O comprimento da esfera é "+ comprimento);
            Console.WriteLine("O area da esfera é " + area);
            Console.WriteLine("O volume da esfera é " + volume);
            Console.ReadKey();
        }
    }
}
