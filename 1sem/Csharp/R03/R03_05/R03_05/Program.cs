using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R03_05
{
    class Program
    {
        static void Main(string[] args)
        {
            double votos,i=0, can1=0, can2=0, can3=0, eleitores=0, primeiro=0, segundo=0, terceiro=0;
            string municipio,priC="", segC="", terC="";

            Console
                WriteLine("Informe o municipio de votação");
            municipio = Console.ReadLine();
            
            Console.WriteLine("Digite o numero de eleitores aptos");
            eleitores = double.Parse(Console.ReadLine());

            for (i=1; i<=eleitores; i++)
            {
                Console.WriteLine("Infome seu canditado pelo numero correspondente: \n 1- Joãozinho \n 2- José \n 3- Mariano");
                votos = double.Parse(Console.ReadLine());

                if (votos == 1)
                {
                    can1++;
                } else if (votos == 2)
                {
                    can2++;
                }
                else if (votos == 3)
                {
                    can3++;
                } else
                {
                    Console.WriteLine("Candidato não encontrado, digite novamente");
                    i--;
                }
            }
            
            if (can1 > can2 && can1 > can3)
            {
                priC = "Joãozinho";
                primeiro = can1;
                if (can2 > can3)
                {
                    segC = "José";
                    terC = "Mariano";
                    segundo = can2;
                    terceiro = can3;
                } else
                {
                    segC = "Mariano";
                    terC = "José";
                    segundo = can3;
                    terceiro = can2;
                }
            } else if (can2 > can1 && can2 > can3)
            {
                priC = "José";
                primeiro = can2;
                if(can1 > can3)
                {
                    segC = "Joãozinho";
                    terC = "Mariano";
                    segundo = can1;
                    terceiro = can3;
                } else
                {
                    segC = "Mariano";
                    terC = "Joãozinho";
                    segundo = can3;
                    terceiro = can1;
                }
            } else if (can3 > can1 && can3 > can2)
            {
                priC = "Mariano";
                primeiro = can3;
                if (can1 > can2)
                {
                    segC = "Joãozinho";
                    terC = "José";
                    segundo = can1;
                    terceiro = can2;
                }
                else
                {
                    segC = "José";
                    terC = "Joãozinho";
                    segundo = can2;
                    terceiro = can1;
                }
            }

            Console.WriteLine("O primeiro canditado é:" + priC + " com " + (primeiro / eleitores) * 100 + " % dos votos");
            Console.WriteLine("O segundo canditado é:" + segC + " com " +  (segundo / eleitores) * 100 + " % dos votos");
            Console.WriteLine("O terceiro canditado é:" + terC + " com " + (terceiro / eleitores) * 100 + " % dos votos");

            if(eleitores > 20000)
            {
                Console.WriteLine("Vai ocorrer segundo turno entre os candidatos" + priC + " e " + segC);
            }

            Console.ReadKey();

        }
    }
}
