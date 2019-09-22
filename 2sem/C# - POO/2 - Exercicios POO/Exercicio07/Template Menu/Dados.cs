using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Menu
{
    class Dados
    {
        private ArrayList cadastro;

        public Dados()
        {
            this.cadastro = new ArrayList();
        }

        public void inserirCategoria(Categoria x)
        {
            x.leDados();

            this.cadastro.Add(x);
        }

        public void inserirProduto(Produto x)
        {
            x.leDados();

            this.cadastro.Add(x);
        }

        public void listar()
        {
            Console.Clear();

            foreach (object x in this.cadastro)
            {
                if (x is Produto)
                {
                    Produto p = (Produto)x;
                    Console.WriteLine($"{p.nomeProduto}");
                    Console.WriteLine($"Preço Unitário: R$ {p.precoUnit:F2} - {p.qntEstoque} unidades");

                    foreach (var c in cadastro)
                    {
                        if (c is Categoria)
                        {
                            Categoria categoria = (Categoria)c;
                            if (categoria.codigo == p.categoria)
                            {
                                Console.WriteLine($"Categoria:  {categoria.descricao}");
                            }
                        }
                    }
                }
            }

            Console.ReadKey();
        }

        public void gerarInventario()
        {
            double total = 0;

            foreach (object x in this.cadastro)
            {
                if (x is Produto)
                {
                    Produto p = (Produto)x;
                    total = total + p.qntEstoque * p.precoUnit;
                }
            }

            Console.WriteLine($"    Total do estoque: R$ {total:F2}");
            Console.ReadKey();
        }
    }
}
