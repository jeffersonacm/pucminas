using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaDENO
{
    class Program
    {
        static void Main(string[] args)
        {
            int Op;

            Lista MinhaLista = new Lista();     // Instância da classe

            do
            {
                Console.Clear();

                Console.WriteLine("LISTA DUPLAMENTE ENCADEADA - NÃO ORDENADA");             // Menu de Opções
                Console.WriteLine("=========================================\n");
                Console.WriteLine("Opções: \n");
                Console.WriteLine("1 - Inserir Elemento no Início da Lista");
                Console.WriteLine("2 - Inserir Elemento no Final da Lista");
                Console.WriteLine("3 - Mostrar os Elementos da Lista do Início ao Fim");
                Console.WriteLine("4 - Mostrar os Elementos da Lista do Fim ao Início");
                Console.WriteLine("5 - Remover Elemento da Lista");
                Console.WriteLine("6 - Esvaziar a Lista");
                Console.WriteLine("7 - Trocar dois elementos");
                Console.WriteLine("8 - Sair\n");


                Console.Write("Digite sua Opção: ");
                Op = int.Parse(Console.ReadLine());

                if (Op == 1)                    // Inserir no Início da Lista
                {
                    int x;                      // Valor a ser inserido
                    Console.Clear();            // Limpa a Tela

                    Console.Write("Digite um Número Inteiro: ");
                    x = int.Parse(Console.ReadLine());                      // Lê o valor a ser inserido

                    MinhaLista.InserirInício(x);                            // Chama o método

                    Console.WriteLine("\nElemento inserido na lista... Tamanho: {0}\n\n", MinhaLista.Tamanho);
                    Console.ReadKey();
                }

                if (Op == 2)                    // Inserir no Final da Lista
                {
                    int x;                      // Valor a ser inserido
                    Console.Clear();            // Limpa a Tela

                    Console.Write("Digite um Número Inteiro: ");
                    x = int.Parse(Console.ReadLine());                      // Lê o valor a ser inserido

                    MinhaLista.InserirFinal(x);                             // Chama o método

                    Console.WriteLine("\nElemento inserido na lista... Tamanho: {0}\n\n", MinhaLista.Tamanho);
                    Console.ReadKey();
                }

                if (Op == 3)                    // Listar os Elementos da Lista do Início ao Fim
                {
                    MinhaLista.MostraListaINIFIM();
                }

                if (Op == 4)                    // Listar os Elementos da Lista do Fim ao Início
                {
                    MinhaLista.MostraListaFIMINI();
                }

                if (Op == 5)                    // Retirar um Elemento da Lista
                {
                    int x;                      // Valor a ser retirado
                    Console.Clear();            // Limpa a Tela

                    Console.Write("Digite um Número Inteiro: ");            // Lê o valor a ser inserido
                    x = int.Parse(Console.ReadLine());

                    MinhaLista.RetiraElemento(x);                           // Chama o método
                }

                if (Op == 6)                        // Esvaziar a Lista
                {
                    Console.Clear();                // Limpa a Tela

                    MinhaLista.EsvaziarLista();     // Chama o Método

                    Console.WriteLine("Lista Vazia!!\n\n");
                    Console.ReadKey();
                }

                if (Op == 7)
                {
                    Console.Clear();
                    MinhaLista.InserirFinal(1);
                    MinhaLista.InserirFinal(2);
                    MinhaLista.InserirFinal(3);
                    MinhaLista.InserirFinal(4);

                    MinhaLista.TrocarElementos(1, 3);
                    MinhaLista.MostraListaINIFIM();

                    Console.ReadKey();
                }

            } while (Op != 8);
        }
    }
}
