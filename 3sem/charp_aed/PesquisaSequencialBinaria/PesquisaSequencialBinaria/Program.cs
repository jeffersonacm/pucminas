using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesquisaSequencialBinaria
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            int CodigoBarras;
            ListaProdutos lista = new ListaProdutos();
            Produto produto;

            do
            {
                Console.Clear();

                Console.WriteLine("Supermercado");
                Console.WriteLine("Opções:");
                Console.WriteLine("1 - Inserir produto");
                Console.WriteLine("2 - Busca Binária");
                Console.WriteLine("3 - Busca Sequencial");
                Console.WriteLine("4 - Sair");
                Console.Write("Digite uma opção: ");

                op = int.Parse(Console.ReadLine());

                if (op == 1)
                {
                    lista.Adicionar(IncluirProduto());

                    Console.WriteLine("Produto adicionado, digite qualquer tecla para continuar.....");
                    Console.ReadKey();
                }
                else if (op == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Busca binária: ");
                    Console.Write("Digite o código de barras: ");
                    CodigoBarras = int.Parse(Console.ReadLine());

                    produto = lista.BuscaBinaria(CodigoBarras);

                    if (produto == null)
                    {
                        Console.WriteLine("Produto com o código de barras {0} não encontrado.", CodigoBarras);
                    } else
                    {
                        Console.WriteLine("Nome: {0} \nCódigo Barras: {1} \nPreço unitário: {2}", 
                             produto.Nome, produto.CodBarras, produto.PrecoUnitario);
                        Console.WriteLine("Interações: " + lista.Interacoes);
                        Console.WriteLine("Digite qualquer tecla para continuar.....");
                        Console.ReadKey();
                    }
                } else if (op == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Busca sequencial: ");
                    Console.Write("Digite o código de barras: ");
                    CodigoBarras = int.Parse(Console.ReadLine());

                    produto = lista.BuscaSequencial(CodigoBarras);

                    if (produto == null)
                    {
                        Console.WriteLine("Produto com o código de barras {0} não encontrado.", CodigoBarras);
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Nome: {0} \nCódigo Barras: {1} \nPreço unitário: {2}",
                            produto.Nome, produto.CodBarras, produto.PrecoUnitario);
                        Console.WriteLine("Interações: " + lista.Interacoes);
                        Console.WriteLine("Digite qualquer tecla para continuar.....");
                        Console.ReadKey();
                    }
                } else if (op == 4)
                {
                    continue;
                } else
                {
                    Console.WriteLine("Opção inválida!");
                    Console.ReadKey();
                }

            } while (op != 4);
            
            Console.ReadKey();
        }

        public static Produto IncluirProduto()
        {
            Produto produto = new Produto();

            Console.Clear();
            Console.WriteLine("Inclusão de produto: ");

            Console.Write("Digite o codigo de barras: ");
            produto.CodBarras = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome: ");
            produto.Nome = Console.ReadLine();

            Console.Write("Digite o valor unitário: ");
            produto.PrecoUnitario = double.Parse(Console.ReadLine());

            return produto;
        }
    }
}
