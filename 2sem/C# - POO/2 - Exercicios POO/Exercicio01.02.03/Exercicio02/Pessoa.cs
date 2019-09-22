using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class Pessoa
    {
        public string nome;
        public string email;
        public int telefone;
        public int dia;
        public int mes;
        public int ano;

        public void Cadastrar()
        {
            Console.Write("Infome o nome............: ");
            this.nome = Console.ReadLine();

            Console.Write("Infome o email...........: ");
            this.email = Console.ReadLine();

            Console.Write("Infome a Data de nasc....: ");
            Console.Write("\nDia...:");
            this.dia = int.Parse(Console.ReadLine());

            Console.Write("Mês...:");
            this.mes = int.Parse(Console.ReadLine());

            Console.Write("Ano...:");
            this.ano = int.Parse(Console.ReadLine());

            Console.Write("Infome o telefone........: ");
            this.telefone = int.Parse(Console.ReadLine());
        }

        public void Listar(ArrayList pessoa)
        {
            foreach (Pessoa x in pessoa)
            {
                Console.WriteLine("Nome: {0}", x.nome);
                Console.WriteLine("Email: {0}", x.email);
                Console.WriteLine("Dt. Nasc.: {0}/{1}/{2}", x.dia, x.mes, x.ano);
                Console.WriteLine("Telefone: {0} \n", x.telefone);
            }
        }
    }
}
