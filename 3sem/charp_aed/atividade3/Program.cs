using System;

namespace atividade3
{
    class Program
    {
        static void Main(string[] args)
        {
            Ponto [] pontos = getPontosAleatorios(10000);

            Ponto pontoMaisProx = calculaMaisProximo(pontos, new Ponto(3,4));

            System.Console.WriteLine("O ponto mais próximo se localiza em: x: {0} y: {1}", pontoMaisProx.x, pontoMaisProx.y);
            System.Console.WriteLine();
        }

        static Ponto[] getPontosAleatorios(int n) {
            Ponto [] pontos = new Ponto[n];

            Random r = new Random();

            for (int i = 0; i < n; i++)
            {
                pontos[i] = new Ponto(r.Next(0, n), r.Next(0, n));
            }

            return pontos;
        }

        static Ponto calculaMaisProximo(Ponto [] pontos, Ponto ponto) {
            double a, b, d, menor = Double.NaN;
            Ponto menorPonto = new Ponto(1,1);

            for (int i = 0; i < pontos.Length; i++)
            {
                a = Math.Pow(pontos[i].x - ponto.x, 2);
                b = Math.Pow(pontos[i].y - ponto.y, 2);
                d = Math.Sqrt(a + b);

                if(menor == Double.NaN) {
                    menor = d;
                    menorPonto = pontos[i];
                }

                if(menor > d) {
                    menor = d;
                    menorPonto = pontos[i];
                }
            }

            return menorPonto;
        }
    }
    public class Ponto {

        public int x { get; set; }
        public int y { get; set; }

        public Ponto(int _x, int _y) {
            x = _x;
            y = _y;
        }
    }
}
