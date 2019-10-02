using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Contratado meuContratado = new Contratado();

            meuContratado.nome = "Jefferson Monteiro";
            meuContratado.dataNasc = "23/02/2000";
            meuContratado.disciplina = "Sistemas de Frustração";
            meuContratado.dataAdmissao = "10/06/2017";

            meuContratado.mostraDados();
            meuContratado.mostraDiaAniversario();

            Temporario meuTemporario = new Temporario();
            meuTemporario.nome = "\nMonteiro Jefferson";
            meuTemporario.dataNasc = "10/10/1991";
            meuTemporario.disciplina = "Sixstemas de conhecimento";
            meuTemporario.dtInicioContrato = "10/02/2010";
            meuTemporario.dtFimContrato = "31/11/2011";

            meuTemporario.mostraDados();
            meuTemporario.mostraDiaAniversario();

            Console.ReadKey();
        }
    }
}
