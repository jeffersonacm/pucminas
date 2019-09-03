using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repeticao1
{
    class Program
    {
        /**
         * Faca um programa que preencha um vetor com 10 numeros inteiros, em seguida calcule e mostre 
         * a) quantidade de numeros pares armazenados 
         * b) a soma dos numeros impares 
         * c) o maior numero e sua posicao
         * d) o vetor completo
         * */
        static void Main(string[] args)
        {

            int [] vet = new int[5];
            int maior=0, par=0, impar=0;

            for (int i = 0; i < 5; i++){
                Console.WriteLine("Digite o numero");
                vet[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vet.Length; i++)
            {
                if (vet[i] == 0)
                {
                    maior = vet[i];
                }

                if (vet[i] % 2 == 0)
                {
                    par++;
                } else
                {
                    impar += impar;
                }

                if(vet[i] > maior)
                {
                    maior = vet[i];
                }
                
                
            }
            Console.ReadKey();


        }
    }
}
