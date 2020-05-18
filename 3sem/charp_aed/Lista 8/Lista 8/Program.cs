using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            Circular Aluno = new Circular();

            Console.WriteLine("Qual o valor de N?");
            N = int.Parse(Console.ReadLine());

            Aluno.Inserir(N);

            Aluno.imprimir();

            Console.ReadKey();
        }
    }
}
