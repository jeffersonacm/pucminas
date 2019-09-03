using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetor01
{
    class Program
    {
        /**
         * Faça um programa que carregue um vetor de seis elementos numéricos inteiros,
         * calcule e mostre na tela: 
         * A quantidade de números pares e quais são os números pares 
         * A quantidade de números ímpares e quais são os números ímpares
         */
         
        static void Main(string[] args)
        {
            int[] vetor = new int[6];
            int pares = 0, impares = 0;

            for(int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite um numero");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Numeros pares");
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    pares++;
                    Console.Write(vetor[i] + " |");

                }
            }

            Console.WriteLine("\n Numeros impares");
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 != 0)
                {
                    impares++;
                    Console.Write(vetor[i] + " |");
                }
            }

            Console.WriteLine("\n Foram digitados "+pares+" números pares");
            Console.WriteLine("Foram digitados " + impares + " números impares");

            Console.ReadKey();

        }
    }
}
