using System;
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

        public void InserirElemento(int numero)
        {
            Elemento elemento = new Elemento();
            elemento.num = numero;
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
                    Console.WriteLine("{0,5}", aux.num);
                    aux = aux.prox;
                }
            }
        }

        public void InverterOrdem()
        {
            Elemento aux = inicio, prox = null, aux2 = aux;
            
            while (aux != null)
            {
                aux = aux.prox;
                aux2.prox = prox;
                prox = aux2;
                aux2 = aux.prox;
            }

            inicio = fim;
        }
    }
}
