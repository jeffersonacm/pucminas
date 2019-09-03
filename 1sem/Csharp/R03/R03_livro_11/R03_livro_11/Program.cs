using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R03_livro_11
{
    class Program
    {
        static void Main(string[] args)
        {
            double precoCarro, precoFinal=0;
            int i, parcelaDispo=0, acrescimo=0;

            Console.WriteLine("Infome o preço do carro:");
            precoCarro = double.Parse(Console.ReadLine());
          
            Console.WriteLine("\n PREÇO FINAL    QUANTIDADE DE PARCELAS     VALOR DA PARCELA");

            for (i=1; i<=11; i++)
            {
                if (i == 1)
                {
                    precoFinal = precoCarro - (precoCarro * 0.20);
                    Console.WriteLine("   "+precoFinal + "                      1                   " + precoFinal);
                }
                parcelaDispo += 6;
                acrescimo += 3;
          
                precoFinal = precoCarro + ((precoCarro * acrescimo) / 100);
                Console.WriteLine("   "+precoFinal + "                     " + parcelaDispo + "                   " + precoFinal / parcelaDispo);
            }
            Console.ReadKey();
        }
    }
}

