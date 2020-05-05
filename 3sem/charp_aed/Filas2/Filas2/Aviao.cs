using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filas2
{
    class Aviao
    {

        public String nome { get; set; }
        public int identificador { get; set; }
        public String origem { get; set; }
        public String destino { get; set; }

        public Aviao()
        {

        }

        public Aviao(String _nome, int _identificador, String _origem, String _destino)
        {
            nome = _nome;
            identificador = _identificador;
            origem = _origem;
            destino = _destino;
        }

    }
}
