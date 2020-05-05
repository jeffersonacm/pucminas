using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filas2
{
    class Fila
    {
        public Aeroporto inicio;
        public Aeroporto fim;
        public Aeroporto aux;

        public int count;

        public Fila()
        {
            inicio = null;
            fim = null;
            count = 0;
        }

        public void InserirAviao(Aviao aviao)
        {
            Aeroporto aeroporto = new Aeroporto();
            aeroporto.item = aviao;
            aeroporto.prox = null;

            if (inicio == null)
            {
                inicio = aeroporto;
                fim = aeroporto;
            }
            else
            {
                fim.prox = aeroporto;
                fim = aeroporto;
            }

            count++;
        }

        public void ListarFilaEspera()
        {
            if (inicio == null)
            {
                Console.WriteLine("A lista de espera está vazia");
            }
            else
            {
                aux = inicio;

                while (aux != null)
                {
                    Console.WriteLine(aux.item.nome);
                    aux = aux.prox;
                }
            }
        }

        public void Autorizar(String pOUd)
        {
            String x;

            if (inicio == null)
            {
                Console.WriteLine("A fila está vazia");
            }
            else
            {
                x = inicio.item.nome;
                inicio = inicio.prox;
                count--;

                Console.WriteLine("\nAvião {0} autorizado a " + pOUd + " \n", x);
            }
        }

        public void DetalhesPrimeiroDaFila()
        {
            Aviao x;

            if (inicio == null)
            {
                Console.WriteLine("A fila está vazia");
            }
            else
            {
                x = inicio.item;
                Console.WriteLine("Identificacao: {0} \nNome: {1} \nOrigem:{2}\nDestino: {3}", x.identificador, x.nome, x.origem, x.destino);
            }
        }

        public Boolean IsEmpty()
        {
            return inicio == null;
        }

    }
}
