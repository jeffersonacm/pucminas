using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filas
{
    class Item
    {
        public int prioridade;
        public String valor;

        public Item()
        {
            prioridade = int.MinValue;
            valor = null;
        }

        public Item(String _valor, int _prioridade)
        {
            valor = _valor;
            prioridade = _prioridade;
        }
    }
}
