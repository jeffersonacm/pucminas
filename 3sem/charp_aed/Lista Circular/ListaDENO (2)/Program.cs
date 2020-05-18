using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaDENO
{
    class Program
    {
        static void Main(string[] args)
        {
            int nAlunos, primeiroAluno = 10, intervalo = 0, lider;
            
            Lista lista = new Lista();
            Console.WriteLine("-----------Aula 08 – Lista Circular-----------");
            Console.WriteLine("Buscando líder para turma");

            Console.Write("Digite a quantidade de alunos: ");
            nAlunos = int.Parse(Console.ReadLine());

            while (primeiroAluno > nAlunos)
            {
                Console.Write("Digite o primeiro aluno a receber o papel: ");
                primeiroAluno = int.Parse(Console.ReadLine());

                if (primeiroAluno > nAlunos)
                {
                    Console.WriteLine("Oops! O primeiro aluno não consta na lista de alunos!");
                    Console.WriteLine("\n");
                }
            }

            Console.WriteLine("Digite o intervalo: ");
            intervalo = int.Parse(Console.ReadLine());

            lider = lista.BuscaLiderTurma(nAlunos, primeiroAluno, intervalo);

            Console.WriteLine("O lider da turma é o aluno {0}", lider);
            Console.ReadKey();
        }
    }
}
