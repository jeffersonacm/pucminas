using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filas2
{
    class Program
    {
        static void Main(string[] args)
        {
            Aviao aviao;

            Console.WriteLine("---------- Fila de decolagem ----------");
            Fila fila = new Fila();
            aviao = new Aviao("Boeng", 1, "manaus", "sao paulo");
            fila.InserirAviao(aviao);
            aviao = new Aviao("azul", 2, "rio de janeiro", "sao paulo");
            fila.InserirAviao(aviao);
            aviao = new Aviao("737", 3, "minas gerais", "sao paulo");
            fila.InserirAviao(aviao);
            aviao = new Aviao("tico tico", 4, "espirito santo", "sao paulo");
            fila.InserirAviao(aviao);


            Console.WriteLine("\n" + fila.count + " aviões estão aguardando");
            fila.Autorizar("decolagem");

            Console.WriteLine("\nLista de espera: ");
            fila.ListarFilaEspera();

            Console.WriteLine("\nCaracterísticas do primeiro avião: ");
            fila.DetalhesPrimeiroDaFila();


            Console.WriteLine("---------- Fila de pouso ----------");


            Fila fila2 = new Fila();

            aviao = new Aviao("Maggi", 1, "manaus", "sao paulo");
            fila2.InserirAviao(aviao);
            aviao = new Aviao("Vermelho", 2, "rio de janeiro", "sao paulo");
            fila2.InserirAviao(aviao);
            aviao = new Aviao("Covid", 3, "minas gerais", "sao paulo");
            fila2.InserirAviao(aviao);
            aviao = new Aviao("tico teco", 4, "sao paulo", "minas gerais");
            fila2.InserirAviao(aviao);

            aviao = new Aviao("maia", 5, "sao paulo", "brasilia");
            fila2.InserirAviao(aviao);

            Console.WriteLine("\n" + fila.count + " aviões estão aguardando");
            fila2.Autorizar("pousar");

            Console.WriteLine("\nLista de espera: ");
            fila2.ListarFilaEspera();

            Console.WriteLine("\nCaracterísticas do primeiro avião: ");
            fila2.DetalhesPrimeiroDaFila();

            Console.ReadKey();
        }
    }
}
