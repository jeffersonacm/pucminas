using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filas
{
    class Elemento
    {
        public Item item;
        public Elemento prox;

        public Elemento()
        {
            item = new Item();
            prox = null;
        }

        public Elemento(String _item, int prioridade)
        {
            item = new Item(_item, prioridade);
            prox = null;
        }
    }
}
