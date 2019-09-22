using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcProject
{
    class Dados
    {
        private ArrayList Cadastro;

        public Dados()
        {
            Cadastro = new ArrayList();
        }

        public void InserirAluno(Aluno x)
        {
            Cadastro.Add(x);
        }

        public ArrayList ListarAlunos()
        {
            return Cadastro;
        }

        public Aluno PesquisarAluno(String CodAluno)
        {
            foreach (Aluno x in Cadastro)
            {
                if (x.Codigo == CodAluno)
                    return x;
            }

            return null;
        }

        public void ExcluirAluno(Aluno aluno)
        {
            Cadastro.Remove(aluno);
        }

        public void AlterarAluno(Aluno AlunoVelho, Aluno NovoAluno)
        {
            int pos;
            pos = Cadastro.IndexOf(AlunoVelho);
            Cadastro.Remove(AlunoVelho);
            Cadastro.Insert(pos, NovoAluno);
        }
    }
}
