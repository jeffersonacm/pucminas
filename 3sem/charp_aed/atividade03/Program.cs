using System;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using TheThreadState = System.Threading.ThreadState;

namespace atividade3
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
                Verificar funcionamento

                Ponto [] pontos = getPontosAleatorios(1000);

                Ponto pontoMaisProx = calculaMaisProximo(pontos, new Ponto(62,92));

                Ponto [] pontos1 = calculaMaisProximos(pontos);

                System.Console.WriteLine("O ponto mais próximo se localiza em: x: {0} y: {1}", pontoMaisProx.x, pontoMaisProx.y);
                System.Console.WriteLine("Os pontos mais próximos são: "+
                "\n Ponto 1 - x: {0} y: {1} "+
                "\n Ponto 2 - x: {2} y: {3}", pontos1[0].x, pontos1[0].y, pontos1[1].x, pontos1[1].y);
                System.Console.WriteLine();
            */

            var watch = System.Diagnostics.Stopwatch.StartNew();

            rodarTeste(1000, 10000);

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds / 1000.0;
            System.Console.WriteLine("Tempo gasto: " + elapsedMs + " segundos");

            var ramUsage = System.Diagnostics.Process.GetCurrentProcess().PeakWorkingSet64;
            var allocationInMB = ramUsage / (1024*1024);
            System.Console.WriteLine("Memória usada: " + allocationInMB + "MB");

        }

        static void rodarTeste(int inicio, int fim) {

            for (int i = inicio; i < fim; i+=1000)
            {
                Ponto [] pontos = getPontosAleatorios(i);

                Ponto pontoMaisProx = calculaMaisProximo(pontos, new Ponto(30,40));

                Ponto [] pontos1 = calculaMaisProximos(pontos);
            }

        }

        // Complexidade o(n)
        static Ponto[] getPontosAleatorios(int n) {
            Ponto [] pontos = new Ponto[n];

            Random r = new Random();

            for (int i = 0; i < n; i++)
            {
                pontos[i] = new Ponto(r.Next(0, n), r.Next(0, n));
            }

            return pontos;
        }

        // Complexidade o(n)
        static Ponto calculaMaisProximo(Ponto [] pontos, Ponto ponto) {
            double a, b, d, menor = Double.MaxValue;
            Ponto menorPonto = new Ponto(3, 3);

            for (int i = 0; i < pontos.Length; i++)
            {
                a = Math.Pow(pontos[i].x - ponto.x, 2);
                b = Math.Pow(pontos[i].y - ponto.y, 2);
                d = Math.Sqrt(a + b);

                if(menor > d) {
                    menor = d;
                    menorPonto = pontos[i];
                }
            }

            return menorPonto;
        }

        // Complexidade o(n²)
        static Ponto [] calculaMaisProximos(Ponto [] pontos) {
            double a, b, d, menor = Double.MaxValue;
            Ponto [] menorPonto = new Ponto[2] { new Ponto(1,1), new Ponto(1,1) };

            for (int x = 0; x < pontos.Length; x++)
            {
                for (int y = 0; y < pontos.Length; y++)
                {
                    if(pontos[x].x == pontos[y].x && pontos[x].y == pontos[y].y)
                        continue;

                    a = Math.Pow(pontos[x].x - pontos[y].x, 2);
                    b = Math.Pow(pontos[x].y - pontos[y].y, 2);
                    d = Math.Sqrt(a + b);

                    if (menor > d) {
                        menor = d;
                        menorPonto[0] = pontos[x];
                        menorPonto[1] = pontos[y];
                    }
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
