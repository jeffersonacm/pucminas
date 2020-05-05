using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filas
{
    class Fila
    {
        public Elemento inicio;
        public Elemento fim;
        public Elemento aux;

        public int count;

        public Fila()
        {
            inicio = null;
            fim = null;
            count = 0;
        }

        public void InserirElemento(Item item)
        {
            Elemento elemento = new Elemento();
            elemento.item = item;
            elemento.prox = null;

            if (inicio == null)
            {
                inicio = elemento;
                fim = elemento;
            } else
            {
                fim.prox = elemento;
                fim = elemento;
            }

            count++;
        }

        public void MostraFila()
        {
            if (inicio == null)
            {
                Console.WriteLine("A fila está vazia");
            } else
            {
                Console.WriteLine("Elementos na fila: " + count);

                aux = inicio;

                while (aux != null)
                {
                    Console.WriteLine("{0,5}", aux.item.valor);
                    aux = aux.prox;
                }
            }
        }

        public void RetiraElemento()
        {
            String x;

            Console.Clear();

            if (inicio == null)
            {
                Console.WriteLine("A fila está vazia");
            }
            else
            {
                x = inicio.item.valor;
                inicio = inicio.prox;
                count--;

                Console.WriteLine("Elemento {0} retirado da fila \n Tamanho da fila: {1} \n", x, count);
                Console.ReadKey();
            }
        }

        public Boolean IsEmpty()
        {
            return inicio == null;
        }
    }
}
