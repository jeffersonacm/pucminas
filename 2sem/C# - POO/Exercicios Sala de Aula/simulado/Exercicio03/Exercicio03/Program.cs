using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            ArrayList Pacientes = new ArrayList();

            do
            {
                Console.Clear();

                Paciente objP = new Paciente();

                Console.WriteLine("Clinica Médica");
                Console.WriteLine("1 - Cadastrar");
                Console.WriteLine("2 - Listar");
                Console.WriteLine("3 - Sair");
                Console.Write("Infome uma opção: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        objP.Cadastrar();
                        Pacientes.Add(objP);
                        break;
                    case 2:
                        objP.Listar(Pacientes);
                        break;
                    case 3:
                        Environment.Exit(0);
                        Thread.Sleep(1500);
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        Thread.Sleep(1500);
                        break;
                }
            } while (op != 3);
        }
    }
}
