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

        public void InserirTime(Times x)
        {
            x.LerDados();

            this.cadastro.Add(x);
        }

        public void Listar()
        {
            Console.Clear();

            foreach (Times x in this.cadastro)
            {
                Console.WriteLine("\nTime {0} ", x.Nome);
                Console.WriteLine("Presidente: {0} ", x.Presidente);
                Console.WriteLine("Técnico: {0} ", x.Tecnico);
                Console.WriteLine("Data de fundação: {0}", x.DtFundacao);
                Console.WriteLine("Digite a cidade do time: {0}", x.Cidade);
                Console.WriteLine("Digite o estado do time: {0}", x.Uf);
            }

            Console.ReadKey();
        }
    }
}
