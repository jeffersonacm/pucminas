using System;
using System.Linq; 

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Double [] lados = new double[3];

            for (int i = 0; i < 3; i++) {
                System.Console.Write("Digite o " + (i + 1) + "º lado: ");
                lados[i] = double.Parse(Console.ReadLine());
            }

            lados = lados.OrderByDescending(i => i).ToArray(); 
            System.Console.WriteLine(lados[0]);

            double a = Math.Pow(lados[0], 2);
            double b = Math.Pow(lados[1], 2);
            double c = Math.Pow(lados[2], 2);
            
            if (lados[0] > lados[1] + lados[2]) {
                System.Console.WriteLine("Os valores não formam um triangulo");

            } else if (a == b + c) {
                System.Console.WriteLine("Os valores são de um triangulo retângulo");

            } else if (a > b + c) {
                System.Console.WriteLine("Os valores são de um triangulo obtusângulo");

            } else if (a == b || b == c || a == c){
                System.Console.WriteLine("Os valores são de um triangulo isósceles");

            } else if (a < b + c) {
                System.Console.WriteLine("Os valores são de um triangulo acutângulo");

            } else if (a == b && b == c) {
                System.Console.WriteLine("Os valores são de um triangulo equilátero");

            } else if (a != b || b != c || a != c){
                System.Console.WriteLine("Os valores são de um triangulo escaleno");
            }

            Console.ReadKey();
        }
    }
}
