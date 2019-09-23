using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Dados
    {
        private ArrayList cadastro;

        public Dados()
        {
            this.cadastro = new ArrayList();
        }

        public void InserirTimeP(Profissionais x)
        {
            x.LerDados();
            this.cadastro.Add(x);
        }

        public void InserirTimeV(Varzea x)
        {
            x.LerDados();
            this.cadastro.Add(x);
        }

        public void Listar()
        {
            Console.Clear();

            foreach (object x in this.cadastro)
            {
                Times t = (Times)x;

                Console.WriteLine("\nTime {0} ", t.Nome);
                Console.WriteLine("Presidente: {0} ", t.Presidente);
                Console.WriteLine("Técnico: {0} ", t.Tecnico);
                Console.WriteLine("Data de fundação: {0}", t.DtFundacao);
                Console.WriteLine("Digite a cidade do time: {0}", t.Cidade);
                Console.WriteLine("Digite o estado do time: {0}", t.Uf);

                if(x is Profissionais) {
                    Profissionais p = (Profissionais)x;
                    Console.WriteLine("Patriocinador {0} ", p.Patricinador);
                }

                if(x is Varzea)
                {
                    Varzea v = (Varzea)x;
                    Console.WriteLine("Bairro {0} ", v.Bairro);
                }
            }

            Console.ReadKey();
        }
    }
}
