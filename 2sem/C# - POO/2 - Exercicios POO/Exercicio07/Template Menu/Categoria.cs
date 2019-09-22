using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Menu
{
    class Categoria
    {
        public string codigo { get; set; }
        public string descricao { get; set; }

        public void leDados()
        {
            Console.Clear();

            Console.Write("Código da categoria: ");
            this.codigo = Console.ReadLine();

            Console.Write("Descrição da categoria: ");
            this.descricao = Console.ReadLine();
        }

    }
}
