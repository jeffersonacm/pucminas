using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Varzea:Times
    {
        public string Bairro { get; set; }

        public void LerDados()
        {
            base.LerDadosTime();

            Console.Write("Digite o bairro............: ");
            Bairro = Console.ReadLine();
        }
    }
}
