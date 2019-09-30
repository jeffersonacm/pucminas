using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Paciente
    {
        private string _nome;
        public string nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private string _telefone;
        public string telefone
        {
            get { return _telefone;  }
            set { _telefone = value; }
        }

        private string _dtNasc;
        public string dtNasc
        {
            get { return _dtNasc;  }
            set { _dtNasc = value; }
        }

        private string _email;
        public string email
        {
            get { return _email;  }
            set { _email = value; }
        }

        public void Cadastrar()
        {
            Console.WriteLine("------- Cadastro de paciente -------");
            Console.Write("Digite o nome..............: ");
            this.nome = Console.ReadLine();

            Console.Write("Digite o telefone..........: ");
            this.telefone = Console.ReadLine();

            Console.Write("Digite a Data de Nascimento: ");
            this.dtNasc = Console.ReadLine();

            Console.Write("Digite o Email.............: ");
            this.email = Console.ReadLine();
        }

        public void Listar(ArrayList arrayPacientes)
        {
            foreach (Paciente x in arrayPacientes)
            {
                Console.WriteLine("\nPaciente {0} ", x.nome);
                Console.WriteLine("Telefone...........: {0} ", x.telefone);
                Console.WriteLine("Data de nascimento.: {0} ", x.dtNasc);
                Console.WriteLine("Enail..............: {0} ", x.email);
            }

            Console.ReadKey();
        }
    }
}
