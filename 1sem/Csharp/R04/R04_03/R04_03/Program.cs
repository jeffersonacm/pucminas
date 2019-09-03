using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R04_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int pos=1;
            double salario;
            string opcao = "";

            while (opcao != "d")
            {
                Console.WriteLine("Digite uma opção: \n A – Para aumento de 8% \n B – Para aumento de 11 % \n C – Para aumento fixo de R$ 450,00 \n D – Sair do programa");
                opcao = Console.ReadLine().ToLower();
                if(opcao == "d")
                {
                    Environment.Exit(0);
                }

                Console.WriteLine("Digite o "+pos+"º salário");
                salario = double.Parse(Console.ReadLine());

                if (opcao == "a")
                {
                    salario = salario + (salario * 0.08);
                } else if (opcao == "b")
                {
                    salario = salario + (salario * 0.11);
                } else if (opcao == "c")
                {
                    salario = salario + 450;
                } 

                Console.WriteLine("O novo salario é " + salario);
                pos++;
            }
            Console.ReadKey();       
        }
    }
}
