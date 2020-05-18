using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesquisaSequencialBinaria
{
    class ListaProdutos
    {
        public Produto [] Produtos { get; set; }
        public int Interacoes = 0;

        public ListaProdutos()
        {

            //por que não usar lista ?
            Produtos = new Produto[1];
        }

        public void Adicionar(Produto p)
        {
            int NumeroProdutos = Produtos.Length;

            if (Produtos[0] == null)
            {
                Produtos[0] = p;
                return;
            }

            Produto[] AuxProdutos = new Produto[NumeroProdutos+1];

            for (int i = 0; i < Produtos.Length; i++)
            {
                AuxProdutos[i] = Produtos[i];
            }

            AuxProdutos[NumeroProdutos] = p;

            //Produtos = new Produto[AuxProdutos.Length];
            Produtos = AuxProdutos;
        }

        public Produto BuscaBinaria(int CodBarras)
        {
            int Inicio = 0;
            int Fim = Produtos.Length;
            int Meio;
            Interacoes = 0;
            Boolean Continuar = true;

            while (Continuar)
            {
                Interacoes++;
                Meio = ((Fim - Inicio) / 2) + Inicio;

                if (Inicio > Fim)
                {
                    return null;
                } else if (Produtos[Meio].CodBarras == CodBarras)
                {
                    return Produtos[Meio];
                } else if (CodBarras > Produtos[Meio].CodBarras)
                {
                    Inicio = Meio + 1;
                } else if (CodBarras < Produtos[Meio].CodBarras)
                {
                    Fim = Meio - 1;
                }
            }

            return null;
        }

        public Produto BuscaSequencial(int CodBarras)
        {
            Interacoes = 0;

            for (int i = 0; i < Produtos.Length; i++)
            {
                Interacoes++;

                if (Produtos[i].CodBarras == CodBarras)
                {
                    return Produtos[i];
                }
            }

            return null;
        }
    }
}
