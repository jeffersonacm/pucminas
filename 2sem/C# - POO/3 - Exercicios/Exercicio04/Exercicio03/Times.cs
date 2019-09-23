using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    abstract class Times
    {
        public string Nome { get; set; }
        public string Presidente { get; set; }
        public string Tecnico { get; set; }
        public string DtFundacao { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }

        public void LerDadosTime() {
            Console.Write("Digite o nome do time......: ");
            Nome = Console.ReadLine();

            Console.Write("Digite o nome do presidente: ");
            Presidente = Console.ReadLine();

            Console.Write("Digite o nome do técnico...: ");
            Tecnico = Console.ReadLine();

            Console.Write("Digite a Data de fundação..: ");
            DtFundacao = Console.ReadLine();

            Console.Write("Digite a cidade do time....: ");
            Cidade = Console.ReadLine();

            Console.Write("Digite o estado do time....: ");
            Uf = Console.ReadLine();
        }
    }
}
