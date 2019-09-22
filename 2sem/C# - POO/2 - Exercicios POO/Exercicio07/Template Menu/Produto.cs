using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Menu
{
    class Produto
    {
        public string nomeProduto { get; set; }
        public string categoria { get; set; }
        public double precoUnit { get; set; }
        public int qntEstoque { get; set; }

        public void leDados()
        {
            Console.Clear();

            Console.Write("Nome do produto: ");
            this.nomeProduto = Console.ReadLine();

            Console.Write("Categoria: ");
            this.categoria = Console.ReadLine();

            Console.Write("Preço unitário: ");
            this.precoUnit = double.Parse(Console.ReadLine());

            Console.Write("Quantidade em estoque: ");
            this.qntEstoque = int.Parse(Console.ReadLine());

        }
    }
}
