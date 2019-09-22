using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList pessoaList = new ArrayList();

            do
            {
                Pessoa pes = new Pessoa();

                pes.Cadastrar();
                pessoaList.Add(pes);

                Console.WriteLine("\nDeseja cadastrar outra pessoa ? (esc para sair)");

            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Pessoa pessoaLista = new Pessoa();
            pessoaLista.Listar(pessoaList);

            Console.ReadKey();
        }
    }
}
