using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filas
{
    class Program
    {
        static void Main(string[] args)
        {
            int p;
            Item item;
            Fila fila = new Fila();

            item = new Item("item 1", 1);
            fila.InserirElemento(item);
            item = new Item("item 2", 5);
            fila.InserirElemento(item);
            item = new Item("item 3", 3);
            fila.InserirElemento(item);
            item = new Item("item 4", 4);
            fila.InserirElemento(item);
            item = new Item("item 5", 6);
            fila.InserirElemento(item);
            item = new Item("item 6", 1);
            fila.InserirElemento(item);
            item = new Item("item 7", 10);
            fila.InserirElemento(item);
            item = new Item("item 8", 8);
            fila.InserirElemento(item);
            item = new Item("item 9", 12);
            fila.InserirElemento(item);
            item = new Item("item 10", 20);

            Console.WriteLine("Fila principal: ");
            fila.MostraFila();

            Console.Write("Digite a prioridade: ");
            p = int.Parse(Console.ReadLine());

            DivideFila divide = new DivideFila();
            divide.dividir(fila, p);


            Console.WriteLine("\n\nFila 1:");
            divide.fila1.MostraFila();

            Console.WriteLine("\n\nFila 2:");
            divide.fila2.MostraFila();

            Console.ReadKey();
        }
    }
}
