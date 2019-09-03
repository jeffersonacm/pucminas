using System;

namespace R05_01
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] num = new double[10]; 
            int qtde = 0;
            double soma = 0, media;
            for (int x = 0; x < 10; x++) // percorrendo os indices do array
            {
                Console.WriteLine("Digite o valor " + x + ": "); //pedindo o usuario que digite o valor
                num[x] = int.Parse(Console.ReadLine()); //lendo o que o usuario digita e armazenando em um array
            }
            for (int x = 0; x < 10; x++) //loop
            {

                if (x > 5)
                {
                    qtde++;
                    soma = soma + num[x]; //caso x seja maior que 5, somar os valores do vetor, de acordo com o indice I
                }
            }
            Console.WriteLine("Valores do vetor: ");
            for (int x = 0; x < 10; x++)  // impressão do vetor
            {
                Console.Write(num[x] + " | ");

            }
            media = soma / qtde; //media dos valores, apartir do 5º elemento do vetor
            Console.WriteLine("\nA media é: " + media);
            Console.ReadKey();
        }
    }
}
