using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            int Op;
            Dados MeusDados = new Dados();

            do
            {
                Console.Clear();

                Console.WriteLine("Menu de Opções:\n");

                Console.WriteLine("1 - Inserir Time");
                Console.WriteLine("2 - Listar Time");
                Console.WriteLine("3 - Sair");

                Console.Write("Digite uma Opção: ");
                Op = int.Parse(Console.ReadLine());

                switch (Op)
                {
                    case 1:
                        MeusDados.InserirTime(new Times());
                        break;
                    case 2:
                        MeusDados.Listar();
                        break;
                    case 3:
                        Console.WriteLine("\nSaída do Programa...");
                        Thread.Sleep(1500);
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.Write("\nOpção Inválida!");
                        Thread.Sleep(1500);
                        break;
                }
            } while (Op != 3);
        }
    }
}
