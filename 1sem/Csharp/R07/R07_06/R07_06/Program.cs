using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R07_06
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] matriz = new double[3, 3];
            int count = 1;
            double mult, valor;
            string line;

            Console.WriteLine("Digite o número para multiplicação");
            mult = double.Parse(Console.ReadLine());

            StreamReader ler = new StreamReader("entrada.txt");

            line = "text";
            for (int i = 0; i < 3; i++)
            {
                line = ler.ReadLine();

                if (line != null)
                {
                    double.Parse(line);
                }
            }


            ler.Close();

              for (int l = 0; l < 3; l++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Console.Write("Digite o " + count + "º número: ");
                    matriz[l, c] = double.Parse(Console.ReadLine());
                }
                Console.WriteLine("\n");
            }
        }
    }
}
