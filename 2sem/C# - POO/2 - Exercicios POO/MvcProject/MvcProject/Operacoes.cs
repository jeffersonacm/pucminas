using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MvcProject
{
    class Operacoes
    {
        private Dados MeusDados;

        public Operacoes()
        {
            MeusDados = new Dados();
        }

        public void Inserir()
        {
            Aluno MeuAluno;

            do
            {
                MeuAluno = new Aluno();

                Console.Clear();

                Console.WriteLine("Cadastramento de Aluno");
                Console.WriteLine("======================\n");

                Console.WriteLine("Código..........: {0}", MeuAluno.Codigo);

                Console.Write("Nome do Aluno...: ");
                MeuAluno.Nome = Console.ReadLine();

                Console.Write("Telefone........: ");
                MeuAluno.Telefone = Console.ReadLine();

                Console.Write("Mail............: ");
                MeuAluno.Mail = Console.ReadLine();

                MeusDados.InserirAluno(MeuAluno);

                Console.WriteLine("\nInserir outro Registro? (ESC cancela...)");

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }

        public void Listar()
        {
            ArrayList Lista;

            Console.Clear();

            Console.WriteLine("Listagem de alunos cadastrados");
            Console.WriteLine("==============================\n");

            Lista = MeusDados.ListarAlunos();

            foreach(Aluno x in Lista)
            {
                Console.WriteLine("Nome do aluno: {0} ({1})", x.Nome, x.Codigo);
                Console.WriteLine("Telefone.....: {0}", x.Telefone);
                Console.WriteLine("Mail.........: {0}", x.Mail);
            }

            Console.ReadKey();
        }

        public void Pesquisar()
        {
            Aluno MeuAluno;
            string CodPesquisa;

            Console.Clear();

            Console.WriteLine("Pesquisa no cadastro de aluno");
            Console.WriteLine("=============================\n");

            Console.Write("Código do aluno: ");
            CodPesquisa = Console.ReadLine().ToUpper();

            MeuAluno = MeusDados.PesquisarAluno(CodPesquisa);

            if(MeuAluno != null)
            {
                Console.WriteLine("Nome do aluno: {0} ({1})", MeuAluno.Nome, MeuAluno.Codigo);
                Console.WriteLine("Telefone.....: {0}", MeuAluno.Telefone);
                Console.WriteLine("Mail.........: {0}", MeuAluno.Mail);
            }
            else
            {
                Console.Write("\nAluno não existe no cadastro!");
                Thread.Sleep(1500);
            }

            Console.ReadKey();
        }

        public void Excluir()
        {
            Aluno MeuAluno;
            string CodPesquisa;

            Console.Clear();

            Console.WriteLine("Exclusão de aluno do cadastro de aluno");
            Console.WriteLine("======================================\n");

            Console.Write("Código do aluno: ");
            CodPesquisa = Console.ReadLine().ToUpper();

            MeuAluno = MeusDados.PesquisarAluno(CodPesquisa);

            if (MeuAluno != null)
            {
                Console.WriteLine("Nome do aluno: {0} ({1})", MeuAluno.Nome, MeuAluno.Codigo);
                Console.WriteLine("Telefone.....: {0}", MeuAluno.Telefone);
                Console.WriteLine("Mail.........: {0}", MeuAluno.Mail);

                MeusDados.ExcluirAluno(MeuAluno);

                Console.Write("\nAluno excluido do cadastro!");
                Thread.Sleep(1500);
            }
            else
            {
                Console.Write("\nAluno não existe no cadastro!");
                Thread.Sleep(1500);
            }

            Console.ReadKey();
        }

        public void Alterar()
        {
            Aluno MeuAluno;
            Aluno MeuAlunoAlterado;
            MeuAlunoAlterado = new Aluno();
            string CodPesquisa;

            Console.Clear();

            Console.WriteLine("Alteração de dados do aluno no cadastro");
            Console.WriteLine("=======================================\n");

            Console.Write("Código do aluno: ");
            CodPesquisa = Console.ReadLine().ToUpper();

            MeuAluno = MeusDados.PesquisarAluno(CodPesquisa);

            if (MeuAluno != null)
            {
                Console.WriteLine("Nome do aluno: {0} ({1})", MeuAluno.Nome, MeuAluno.Codigo);
                Console.WriteLine("Telefone.....: {0}", MeuAluno.Telefone);
                Console.WriteLine("Mail.........: {0}", MeuAluno.Mail);

                Console.WriteLine("\nDados de atualização: \n");

                MeuAlunoAlterado.Codigo = MeuAluno.Codigo;

                Console.Write("Nome do aluno....: ");
                MeuAlunoAlterado.Nome = Console.ReadLine();

                Console.Write("Telefone do aluno: ");
                MeuAlunoAlterado.Telefone = Console.ReadLine();

                Console.Write("Mail do aluno....: ");
                MeuAlunoAlterado.Mail = Console.ReadLine();

                MeusDados.AlterarAluno(MeuAluno, MeuAlunoAlterado);

                Console.Write("Dados atualizados!");
                Thread.Sleep(1500);
            }
            else
            {
                Console.Write("\nAluno não existe no cadastro!");
                Thread.Sleep(1500);
            }
        }
    }
}
