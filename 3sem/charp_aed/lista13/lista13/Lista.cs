using System;

namespace lista13
{
    class Lista
    {
        private Elemento Inicio;
        private Elemento Fim;

        public Lista()
        {
            Inicio = null;
            Fim = null;
        }

        public void Inserir(int Valor)
        {
            Elemento Elemento = new Elemento();

            Elemento.Numero = Valor;

            if (Inicio == null)
            {
                Inicio = Elemento;
                Fim = Elemento;

                Elemento.Proximo = null;
            } else
            {
                Fim.Proximo = Elemento;
                Fim = Elemento;
                Fim.Proximo = null;
            }
        }

        public void Imprimir()
        {
            Elemento aux;
            aux = Inicio;

            while (aux != null)
            {
                Console.Write(aux.Numero + "  ");
                aux = aux.Proximo;
            }
        }

        public void ConcatenarListas(Lista lista1, Lista lista2)
        {
            Elemento auxLista1 = lista1.Inicio;
            Elemento auxLista2 = lista2.Inicio;

            while (auxLista1 != null || auxLista2 != null)
            {
                if (auxLista1 != null && (auxLista2 == null || auxLista1.Numero <= auxLista2.Numero))
                {
                    Inserir(auxLista1.Numero);
                    auxLista1 = auxLista1.Proximo;
                } 

                if (auxLista2 != null && (auxLista1 == null || auxLista2.Numero <= auxLista1.Numero))
                {
                    Inserir(auxLista2.Numero);
                    auxLista2 = auxLista2.Proximo;
                }
            }
        }
    }
}
