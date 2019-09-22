using System;
using System.Collections;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList Cadastro = new ArrayList();

            DVD MeuDVD;

            for (int i = 0; i < 3; i++)
            {
                MeuDVD = new DVD();
                MeuDVD.LerDados();

                Cadastro.Add(MeuDVD);
            }

            DVD imprimir = new DVD();
            imprimir.ImprimeDados(Cadastro);
        }

        class DVD
        {
            public string nome;
            public string categoria;
            public string valorLocacao;

            public void ImprimeDados(ArrayList Cadastro)
            {
                Console.Clear();

                foreach (DVD x in Cadastro)
                {
                    Console.WriteLine("\n{0}  - Categoria: {1} ", x.nome, x.categoria);
                    Console.WriteLine("Valor da locação: R${0}", x.valorLocacao);
                }

                Console.ReadKey();
            }

            public void LerDados()
            {
                Console.Write("\nNome do filme: ");
                nome = Console.ReadLine();

                Console.Write("Categoria: ");
                categoria = Console.ReadLine();

                Console.Write("Valor locação: ");
                valorLocacao = Console.ReadLine();
            }
        }
    }
}
