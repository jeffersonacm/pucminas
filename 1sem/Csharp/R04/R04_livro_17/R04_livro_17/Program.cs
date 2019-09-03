using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R04_livro_17
{
    class Program
    {
        static void Main(string[] args)
        {
            double canal_4=0, canal_5=0, canal_7=0, canal_12=0, tot;
            int canal = 1, pessoas;
            Console.Title = "Pesquisa de audiência";

            while(canal != 0)
            {
                Console.WriteLine("Informe o número do canal:");
                canal = int.Parse(Console.ReadLine());

                if (canal == 0)
                    break;
                if(canal != 4 && canal != 5 && canal != 7 && canal != 12)
                {
                    Console.WriteLine("Canal não encontrado!");
                    continue;
                }
                Console.WriteLine("Informe o numero de pessoas que estão assistindo:");
                pessoas = int.Parse(Console.ReadLine());

                if (canal == 4)
                {
                    canal_4 += canal;
                } else if (canal == 5)
                {
                    canal_5 += canal;
                } else if (canal == 7)
                {
                    canal_7 += canal;
                } else 
                {
                    canal_12 += canal;
                } 
            }

            tot = canal_4 + canal_5 + canal_7 + canal_12;

            Console.WriteLine("O canal 4 possui audiência de "+ Math.Round((canal_4 / tot) * 100, 2) + "%\n" +
                                "O canal 5 possui audiência de " + Math.Round((canal_5 / tot) * 100, 2) + "%\n" +
                                "O canal 7 possui audiência de " + Math.Round((canal_7 / tot) * 100, 2) + "%\n" +
                                "O canal 12 possui audiência de " + Math.Round((canal_12 / tot) * 100, 2) + "%");
            Console.ReadKey();
            
        }
    }
}
