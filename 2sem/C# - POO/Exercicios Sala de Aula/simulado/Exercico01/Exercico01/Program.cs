using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercico01
{
    class Program
    {
        static void Main(string[] args)
        {
            int operacao;

            Numero Operacoes = new Numero();

            do
            {
                Console.Clear();

                Console.Write("Informe o primeiro número..: ");
                Operacoes.op1 = int.Parse(Console.ReadLine());

                Console.Write("Informe o segundo número...: ");
                Operacoes.op2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Operações:");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtracao");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("4 - Sair");
                Console.WriteLine("Digite a operação..........: ");
                operacao = int.Parse(Console.ReadLine());
                switch (operacao)
                {
                    case 1:
                        Console.WriteLine(Operacoes.op1 + " + " + Operacoes.op2 + " = " + Operacoes.soma());
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine(Operacoes.op1 + " - " + Operacoes.op2 + " = " + Operacoes.subtracao());
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine(Operacoes.op1 + " * " + Operacoes.op2 + " = " + Operacoes.multiplicacao());
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine(Operacoes.op1 + " / " + Operacoes.op2 + " = " + Operacoes.divisao());
                        Console.ReadKey();
                        break;
                    case 5:
                        Thread.Sleep(1500);
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        Thread.Sleep(1500);
                        break;
                }
            } while (operacao != 5);
        }
    }
}
