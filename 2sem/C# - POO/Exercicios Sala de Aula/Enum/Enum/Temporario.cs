using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Temporario:Professores
    {
        public string dtInicioContrato { get; set; }
        public string dtFimContrato { get; set; }

        public override void mostraDados()
        {
            Console.WriteLine("\n{0} - Disciplina: {1}", nome, disciplina);
            Console.WriteLine("Data de nascimento: {0}", dataNasc);
            Console.WriteLine("Contrato válido de {0} até {1}", dtInicioContrato, dtFimContrato);
        }
    }
}
