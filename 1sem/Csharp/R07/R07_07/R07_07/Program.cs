using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R07_07
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter escrever = new StreamWriter("temperatura.txt");
            double temperatura, media = 0, maior=0, menor=0;
            string linha;
            int count=1, acimaMedia = 0, menosde16=0;
            string[] vetor = new string[7] {"Segunda","Terça","Quarta","Quinta","Sexta","Sábado","Domingo"};

            for (int i = 0; i < 7; i++)
            {
                Console.Write("Digite a temperatura de "+vetor[i]+": ");
                temperatura = double.Parse(Console.ReadLine());
                escrever.WriteLine(temperatura);
                media += temperatura;
            }

            media = media / 7;

            escrever.Close();

            StreamReader ler = new StreamReader("temperatura.txt");

            linha = "text";

            while (linha != null)
            {
                linha = ler.ReadLine();

                if (linha == null)
                    break;

                temperatura = double.Parse(linha);

                if(count == 1)
                {
                    maior = temperatura;
                    menor = temperatura;
                }

                maior = temperatura > maior ? temperatura : maior;
                menor = temperatura < maior ? temperatura : menor;

                if(temperatura > media)
                {
                    acimaMedia++;
                }

                if(temperatura < 16)
                {
                    menosde16++;
                }

                count++;
            }

            Console.WriteLine("\nA temperatura esteve acima da média em: " +acimaMedia+" dias");
            Console.WriteLine("A temperatura ficou abaixo de 16 graus celsius em: " + menosde16 + " dias");
            Console.WriteLine("A maior temperatura foi " + maior + "°C e a menor " + menor+"°C" );
            Console.ReadKey();
        }
    }
}
