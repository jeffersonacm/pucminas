using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma
{
    class Program
    {
        static void Main(string[] args)
        {
            Quadrado meuQuadrado = new Quadrado();
            meuQuadrado.lado = 2;

            meuQuadrado.mensagem();

            Console.WriteLine("Área do quadrado : {0:F2}", meuQuadrado.calcArea());

            Console.WriteLine("Perímetro do quadrado : {0:F2}", meuQuadrado.calcPerimetro());
            Console.ReadKey();

            Circulo meuCirculo = new Circulo();
            meuCirculo.raio = 3;

            meuCirculo.mensagem();
            Console.WriteLine("Área do círculo: {0:F2}", meuCirculo.calcArea());
            Console.WriteLine("Perímetro do círculo: {0:F2}", meuCirculo.calcPerimetro());
            Console.ReadKey();

        }
    }
}
