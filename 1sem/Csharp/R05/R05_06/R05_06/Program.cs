using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R05_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] peso = new int[10];
            int[] idade = new int[10];
            int idadeSuperior = 0, pesoSuperior = 0, pesoMedia = 0, countpesoMedia = 0, i;
            string media;

            for (i = 0; i < peso.Length; i++)
            {
                Console.Write("Digite a "+(i + 1)+"º idade: ");
                peso[i] = int.Parse(Console.ReadLine());

                if(peso[i] <= 0)
                {
                    Console.WriteLine("Digite um peso válido");
                    i--;
                    continue;
                }

                Console.Write("Digite o " + (i + 1) + "º peso: ");
                idade[i] = int.Parse(Console.ReadLine());

                if(idade[i] <= 0)
                {
                    Console.WriteLine("Digite uma idade válido");
                    i--;
                    continue;
                }
                Console.WriteLine("\n");
            }

            for(int x = 0; x < peso.Length; x++)
            {
                if(idade[x] > 50)
                {
                    idadeSuperior++;
                } 

                if(peso[x] > 70)
                {
                    pesoSuperior++;
                }
                
                if(idade[x] > 20 && idade[x] < 30)
                {
                    pesoMedia += peso[x];
                    countpesoMedia++;
                }
            }

            media = "Não existe pessoas com a idade entre 20 e 30 anos";
            if(countpesoMedia > 0)
            {
                media = "A média do peso das pessoas com idades entre 20 e 30 anos: " + pesoMedia / countpesoMedia;
            }

            Console.WriteLine("Quantidade de pessoas com idade superior a 50 anos: "+idadeSuperior);
            Console.WriteLine("quantidade de pessoas com peso superior a 70 kilos: "+pesoSuperior);
            Console.WriteLine(media);

            Console.ReadKey();
        }
    }
}
