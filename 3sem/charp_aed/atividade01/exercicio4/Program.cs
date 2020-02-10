using System;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] vet = new int[15];

            Random r = new Random();
            for (int i = 0; i < 15; i++) {
                vet[i] = r.Next(1,100);
            }

            //yes ?
            //Array.Sort(vet);
            vet = sort(vet);

            System.Console.WriteLine("Menor: " + vet[0] + " posição: 1");
            System.Console.WriteLine("Maior: " + vet[14] + " posição: 15");
        }

        public static int[] sort(int [] vet) {
            int aux;

            for (int l = 14; l >= 0; l--)
            {
                for (int c = 14; c >= 0; c--)
                {
                    if (vet[l] > vet[c]) {
                        aux = vet[l];
                        vet[l] = vet[c];
                        vet[c] = aux;
                    }
                }
            }

            return vet;
        }

    }
}
