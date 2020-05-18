using System;

namespace Filas
{
    class Program
    {
        static void Main(string[] args)
        {
            Fila fila = new Fila();
            fila.InserirElemento(1);
            fila.InserirElemento(2);
            fila.InserirElemento(3);
            fila.InserirElemento(4);
            fila.InserirElemento(5);
            fila.InserirElemento(6);
            fila.InserirElemento(7);
            fila.InserirElemento(8);

            Console.WriteLine("Fila principal: ");
            fila.MostraFila();

            Console.Write("Fila invertida: ");
            fila.InverterOrdem();
            fila.MostraFila();

            Console.ReadKey();
        }
    }
}
