using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Template_Menu
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

                Console.WriteLine("1 - Inserir Categoria");
                Console.WriteLine("2 - Inserir Produto");
                Console.WriteLine("3 - Listar tudo");
                Console.WriteLine("4 - Gerar inventário de estoque");
                Console.WriteLine("5 - Sair");

                Console.Write("Digite uma Opção: ");
                Op = int.Parse(Console.ReadLine());

                switch (Op)
                {
                    case 1:
                        MeusDados.inserirCategoria(new Categoria());
                        break;
                    case 2:
                        MeusDados.inserirProduto(new Produto());
                        break;
                    case 3:
                        MeusDados.listar();
                        break;
                    case 4:
                        MeusDados.gerarInventario();
                        break;
                    case 5:
                        Console.WriteLine("\nSaída do Programa...");
                        Thread.Sleep(1500);
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.Write("\nOpção Inválida!");
                        Thread.Sleep(1500);
                        break;
                }
            } while (Op != 5);
        }
    }
}
