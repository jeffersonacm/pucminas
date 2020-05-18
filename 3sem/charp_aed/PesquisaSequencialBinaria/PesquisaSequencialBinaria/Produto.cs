using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesquisaSequencialBinaria
{
    class Produto
    {
        public int CodBarras { get; set; }
        public string Nome { get; set; }
        public double PrecoUnitario { get; set; }

        public Produto()
        {

        }

        public Produto(int CodBarras, string Nome, double PrecoUnitario)
        {
            this.CodBarras = CodBarras;
            this.Nome = Nome;
            this.PrecoUnitario = PrecoUnitario;
        }
    }
}
