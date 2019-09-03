using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R03_livro_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, i, idadePeso=0, mediaPessoas=0, countAzul=0, countRuivas=0;
            string corOlhos, corCabelo;
            double peso, altura, mediaIdade=0;

            for (i=1; i<=6; i++)
            {
                Console.WriteLine("Infome a idade da "+ i+"º pessoa");
                idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Infome a peso da " + i + "º pessoa");
                peso = double.Parse(Console.ReadLine());

                Console.WriteLine("Infome a altura da " + i + "º pessoa (em centimetros)");
                altura = double.Parse(Console.ReadLine());

                Console.WriteLine("Infome a cor dos olhos da " + i + "º pessoa \n" +
                    " A - Azul \n P - Preto \n V - Verde \n C - Castanho");
                corOlhos = Console.ReadLine().ToLower();

                Console.WriteLine("Infome a cor do cabelo da " + i + "º pessoa \n" +
                    " P - Preto \n C - Castanho \n L - Loiro \n R - Ruivo");
                corCabelo = Console.ReadLine().ToLower();

                if (idade > 50 && peso < 60)
                {
                    idadePeso++;
                }

                if (altura < 150)
                {
                    mediaPessoas++;
                    mediaIdade = mediaIdade + idade;
                }

                if (corOlhos == "a")
                {
                    countAzul++;
                }

                if (corCabelo == "r" && corOlhos!= "a")
                {
                    countRuivas++;
                }
            }

            countAzul = (countAzul / i) * 100;
            mediaIdade = mediaIdade / mediaPessoas;
            
            Console.WriteLine("A quantidade de pessoas com idade superior a 50 anos e peso inferior a 60 é:" +idadePeso+ "\n" +
                                "A media das idades das pessoas com altura inferior a 150 cm é:" + mediaIdade + "\n" +
                                "A porcentagem de pessoas com olhos azuis é de:" +countAzul+"% \n" +
                                "A quantidade de pessoas ruivas que não possuem olhos azuis é de : "+countRuivas);
            Console.ReadKey();



        }
    }
}
