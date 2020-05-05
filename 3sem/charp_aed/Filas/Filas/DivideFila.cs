using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filas
{
    class DivideFila
    {

        public Fila fila1 = new Fila();
        public Fila fila2 = new Fila();

        public void dividir(Fila fila, int prioridade)
        {
            if (fila.IsEmpty())
            {
                Console.WriteLine("Não foi possível dividir a fila, pois a mesma está vazia!");
            }

            fila.aux = fila.inicio;

            while (fila.aux != null)
            {
                if (fila.aux.item.prioridade <= prioridade)
                {
                    fila1.InserirElemento(fila.aux.item);
                }
                else
                {
                    fila2.InserirElemento(fila.aux.item);
                }


                fila.aux = fila.aux.prox;
            }
        }
    }
}
