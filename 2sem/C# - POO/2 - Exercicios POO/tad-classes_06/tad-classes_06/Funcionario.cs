using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tad_classes_06
{
    class Funcionario
    {
        public string Nome;
        public string Endereco;
        public string Telefone;
        public string Email;
        public string Admissao;
        public string Nascimento;
        public string NomePai;
        public string NomeMae;
        public string Identidade;
        public string Cpf;
        public string CarteiraTrabalhador;
    }

    class Administrador : Funcionario
    {
        public string Cargo;
        public string Setor;
    }
    
    class Professor : Funcionario
    {
        public int HorasAula;
        public int AulasSemanais;
        public string Titulacao;
    }
}
