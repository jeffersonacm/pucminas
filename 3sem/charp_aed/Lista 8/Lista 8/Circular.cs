using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_8
{
    class Circular
    {
        private Elemento Ini;
        private Elemento Fim;

        public Circular()
        {
            Ini = Fim;
            Fim = null;
        }
        public bool ListaVazia()
        {

            if (Ini == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Inserir(int n)
        {
            do
            {
                Elemento Valor = new Elemento();

                Valor.Num = n;
                if (Ini == null)
                {
                    Ini = Valor;
                    Fim = Ini;
                    Valor.Prox = Ini;
                }
                else
                {
                    Valor.Prox = Ini;
                    Ini = Valor;
                    Fim.Prox = Ini;
                }

                n--;

            } while (n >= 1);
        }

        public void imprimir()
        {
            Elemento aux = new Elemento();
            aux = Ini.Prox;

            if (aux == null)
            {
                Console.WriteLine("A lista de contas-correntes está vazia.");
            }
            else
            {
                // enquanto o ponteiro aux não tiver percorrido toda a lista encadeada...
                while (aux != null)
                {
                    // imprime os dados da conta-corrente apontada pelo ponteiro aux.
                    Console.WriteLine("Numero: " + aux.Num);

                    // avançamos na lista encadeada.
                    aux = aux.Prox;
                    break;
                }
            }
        }
    }
}
