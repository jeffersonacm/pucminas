using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tad_classes_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario[] funcionario = new Funcionario[2];
            for (int i = 0; i < funcionario.Length; i++)
            {
                Console.WriteLine("Tipo do Funcionario {0}:\n1 - Administrador\n2 - Professor: ", i + 1);
                char op1 = Convert.ToChar(Console.ReadLine());
                switch (op1)
                {
                    case '1':
                        funcionario[i] = cadastrarAdministrador();
                        break;
                    case '2':
                        funcionario[i] = cadastrarProfessor();
                        break;
                    default:
                        Console.WriteLine("Opção Invalida, tente novamente!");
                        i--;
                        break;
                }
                Console.Clear();
            }

            char op = '1';
            while (op != 0)
            {
                Console.Clear();
                Console.WriteLine("Menu de Funções:\n1 - Listar Funcionarios: ");
                op = Convert.ToChar(Console.ReadLine());
                switch (op)
                {
                    case '1':
                        listarFuncionarios(funcionario);
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opção Invalida, tente novamente!");
                        break;
                }
            }
        }

        public static Administrador cadastrarAdministrador()
        {
            Administrador administrador = new Administrador();
            Console.Write("Nome...................: "); administrador.Nome = Console.ReadLine();
            Console.Write("Endereço...............: "); administrador.Endereco = Console.ReadLine();
            Console.Write("Telefone...............: "); administrador.Telefone = Console.ReadLine();
            Console.Write("Email..................: "); administrador.Email = Console.ReadLine();
            Console.Write("Admissão...............: "); administrador.Admissao = Console.ReadLine();
            Console.Write("Nascimento.............: "); administrador.Nascimento = Console.ReadLine();
            Console.Write("Nome do Pai............: "); administrador.NomePai = Console.ReadLine();
            Console.Write("Nome da Mãe............: "); administrador.NomeMae = Console.ReadLine();
            Console.Write("Identidade.............: "); administrador.Identidade = Console.ReadLine();
            Console.Write("CPF....................: "); administrador.Cpf = Console.ReadLine();
            Console.Write("Carteira de Trabalhado.: "); administrador.CarteiraTrabalhador = Console.ReadLine();
            Console.Write("Cargo..................: "); administrador.Cargo = Console.ReadLine();
            Console.Write("Setor..................: "); administrador.Setor = Console.ReadLine();
            return administrador;
        }

        public static Professor cadastrarProfessor()
        {
            Professor professor = new Professor();
            Console.Write("Nome...................: "); professor.Nome = Console.ReadLine();
            Console.Write("Endereço...............: "); professor.Endereco = Console.ReadLine();
            Console.Write("Telefone...............: "); professor.Telefone = Console.ReadLine();
            Console.Write("Email..................: "); professor.Email = Console.ReadLine();
            Console.Write("Admissão...............: "); professor.Admissao = Console.ReadLine();
            Console.Write("Nascimento.............: "); professor.Nascimento = Console.ReadLine();
            Console.Write("Nome do Pai............: "); professor.NomePai = Console.ReadLine();
            Console.Write("Nome da Mãe............: "); professor.NomeMae = Console.ReadLine();
            Console.Write("Identidade.............: "); professor.Identidade = Console.ReadLine();
            Console.Write("CPF....................: "); professor.Cpf = Console.ReadLine();
            Console.Write("Carteira de Trabalhado.: "); professor.CarteiraTrabalhador = Console.ReadLine();
            Console.Write("Horas Aula.............: "); professor.HorasAula = Convert.ToInt32(Console.ReadLine());
            Console.Write("Aulas Semanais.........: "); professor.AulasSemanais = Convert.ToInt32(Console.ReadLine());
            Console.Write("Titulação..............: "); professor.Titulacao = Console.ReadLine();
            return professor;
        }

        public static void listarFuncionarios(Funcionario[] funcionarios)
        {
            foreach (Funcionario funcionario in funcionarios)
            {
                if (funcionario is Administrador)
                {
                    Administrador administrador = (Administrador)funcionario;
                    Console.WriteLine("Nome: {0}", administrador.Nome);
                    Console.WriteLine("Endereço: {0}", administrador.Endereco);
                    Console.WriteLine("Email: {0}", administrador.Email);
                    Console.WriteLine("Admissão: {0}", administrador.Admissao);
                    Console.WriteLine("Nascimento: {0}", administrador.Nascimento);
                    Console.WriteLine("Nome do Pai: {0}", administrador.NomePai);
                    Console.WriteLine("Nome da Mãe: {0}", administrador.NomeMae);
                    Console.WriteLine("Identidade: {0}", administrador.Identidade);
                    Console.WriteLine("Carteira de Trabalho: {0}", administrador.Nome);
                    Console.WriteLine("Cargo: {0}", administrador.Nome);
                    Console.WriteLine("Setor: {0}", administrador.Nome);
                }
                else if (funcionario is Professor)
                {
                    Professor professor = (Professor)funcionario;
                    Console.WriteLine(
                        "Nome.................: {0} \n" +
                        "Endereço.............: {1} \n" +
                        "Telefone.............: {2} \n" +
                        "Email................: {3} \n" +
                        "Admissão.............: {4} \n" +
                        "Nascimento...........: {5} \n" +
                        "Nome do Pai..........: {6} \n" +
                        "Nome da Mãe..........: {7} \n" +
                        "Identidade...........: {8} \n" +
                        "CPF..................: {9} \n" +
                        "Carteira de Trabalho.: {10}\n" +
                        "Horas Aula...........: {11}\n" +
                        "Aulas Semanais.......: {12}\n" +
                        "Titulação............: {13}\n",
                        professor.Nome,
                        professor.Endereco,
                        professor.Telefone,
                        professor.Email,
                        professor.Admissao,
                        professor.Nascimento,
                        professor.NomePai,
                        professor.NomeMae,
                        professor.Identidade,
                        professor.Cpf,
                        professor.CarteiraTrabalhador,
                        professor.HorasAula,
                        professor.AulasSemanais,
                        professor.Titulacao);
                }
            }
        }
    }
}
