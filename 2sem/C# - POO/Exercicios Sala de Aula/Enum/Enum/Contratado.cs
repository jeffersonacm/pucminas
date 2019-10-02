using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Contratado:Professores
    {
        public string dataAdmissao { get; set; }

        public override void mostraDados()
        {
            Console.WriteLine("\n{0} - Disciplina: {1}", nome, disciplina);
            Console.WriteLine("Data de nascimento: {0}", dataNasc);
            Console.WriteLine("Data de admissão: {0}", dataAdmissao);
        }

        public override void mostraDiaAniversario()
        {
            base.mostraDiaAniversario();

            int mesNasc = int.Parse(dataNasc.Substring(3, 2));

            mes mesAniversario;
            mesAniversario = mes.Janeiro;
            mesAniversario += mesNasc - 1;

            Console.WriteLine("O mês de aniversário é: {0}", mesAniversario);
        }
    }
}
