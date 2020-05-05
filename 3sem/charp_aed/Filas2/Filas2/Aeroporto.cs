using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filas2
{
    class Aeroporto
    {
        public Aviao item { get; set; }
        public Aeroporto prox { get; set; }

        public Aeroporto()
        {
            item = new Aviao();
            prox = null;
        }

        public Aeroporto(String nome, int identificado, String origem, String destino)
        {
            item = new Aviao(nome, identificado, origem, destino);
            prox = null;
        }
    }
}
