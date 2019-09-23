using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Profissionais:Times
    {
        public string Patricinador { get; set; }

        public void LerDados()
        {
            base.LerDadosTime();

            Console.Write("Digite o patriocinador.....:");                        
            Patricinador = Console.ReadLine();
        }
    }
}
