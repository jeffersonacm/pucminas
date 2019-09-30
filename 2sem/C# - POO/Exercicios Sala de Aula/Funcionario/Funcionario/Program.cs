using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionario
{
    //desing pattern estrategy
    class Program
    {
        static void Main(string[] args)
        {
            AumentoSalarial meuAumentoSalarial = new AumentoSalarial();

            ArrayList cad = new ArrayList();

            do
            {
                Funcionario func = new Funcionario();

                Console.Write("Nome..........:");
                func.nome = Console.ReadLine();

                Console.Write("Salário.......:");
                func.salario = double.Parse(Console.ReadLine());

                if (func.salario < 2000)
                {
                    meuAumentoSalarial.setaEstrategia(new AumentoN2());
                } else
                {
                    meuAumentoSalarial.setaEstrategia(new AumentoN1());
                }

                func.salarioNovo = meuAumentoSalarial.executeEstrategia(func.salario);

                cad.Add(func);

                Console.Write("ESC para sair ou outra tecla para continuar");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.Clear();

            foreach(Funcionario x in cad)
            {
                Console.WriteLine("{0} - De R$ {1:F2} para {2:F2}", x.nome, x.salario, x.salarioNovo);
            }

            Console.ReadKey();
        }
    }
}
