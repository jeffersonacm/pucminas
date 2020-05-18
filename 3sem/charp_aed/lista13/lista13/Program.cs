using System;

namespace lista13
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista minhaLista1 = new Lista();
            minhaLista1.Inserir(3);
            minhaLista1.Inserir(4);
            minhaLista1.Inserir(7);
            minhaLista1.Inserir(9);
            minhaLista1.Inserir(10);
            minhaLista1.Inserir(12);

            Lista minhaLista2 = new Lista();
            minhaLista2.Inserir(2);
            minhaLista2.Inserir(4);
            minhaLista2.Inserir(6);
            minhaLista2.Inserir(8);
            minhaLista2.Inserir(10);
            minhaLista2.Inserir(11);

            Lista minhaLista3 = new Lista();

            Console.WriteLine("Listas concatenadas: ");

            minhaLista3.ConcatenarListas(minhaLista1, minhaLista2);
            minhaLista3.Imprimir();

            Console.ReadKey();
        }
    }
}
