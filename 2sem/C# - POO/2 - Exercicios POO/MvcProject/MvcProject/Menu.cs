using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MvcProject
{
    static class Menu
    {
        public static void MostraMenu()
        {
            Operacoes MinhaOperacao = new Operacoes();

            int Op;

            do
            {
                Console.Clear();

                Console.WriteLine("Sistema de Cadastro de Alunos");
                Console.WriteLine("=============================\n");
                Console.WriteLine("1 - Inserir");
                Console.WriteLine("2 - Alterar");
                Console.WriteLine("3 - Excluir");
                Console.WriteLine("4 - Pesquisar");
                Console.WriteLine("5 - Listar");
                Console.WriteLine("6 - Ordenar");
                Console.WriteLine("7 - Salvar Dados em Arquivo");
                Console.WriteLine("8 - Ler Dados do Arquivo");
                Console.WriteLine("9 - Sair");

                Console.Write("\nOpção: ");
                Op = int.Parse(Console.ReadLine());

                switch (Op)
                {
                    case 1:
                        MinhaOperacao.Inserir();
                        break;
                    case 2:
                        MinhaOperacao.Alterar();
                        break;
                    case 3:
                        MinhaOperacao.Excluir();
                        break;
                    case 4:
                        MinhaOperacao.Pesquisar();
                        break;
                    case 5:
                        MinhaOperacao.Listar();
                        break;
                    case 6:
                        // Ordenar
                        break;
                    case 7:
                        // SalvarXML
                        break;
                    case 8:
                        // CarregarXML
                        break;
                    case 9:
                        Console.Write("\nSaída do Sistema...");
                        Thread.Sleep(2000);
                        break;
                    default:
                        Console.Write("\nOpção Inválida!!!");
                        Thread.Sleep(2000);
                        break;
                }
            } while (Op != 9);
        }
    }
}
