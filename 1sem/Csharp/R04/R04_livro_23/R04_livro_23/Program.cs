using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R04_livro_23
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario;
            int opcao, meses;

            Console.WriteLine("Informe a opção desejada: \n 1-Novo salário \n 2-Férias \n 3-Décimo Terceiro \n 4-Sair");
            opcao = int.Parse(Console.ReadLine());
            
            while(opcao != 1 && opcao!=2 && opcao!=3 && opcao != 4)
            {
                Console.WriteLine("Opção não encotrada, digite novamente a opção");
                opcao = int.Parse(Console.ReadLine());
            }
            if (opcao == 4)
                Environment.Exit(0);

            Console.WriteLine("Informe o salário:");
            salario = double.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                if(salario < 210)
                {
                    salario = salario + (salario * 0.15);
                } else if(salario > 210 && salario <= 600)
                {
                    salario = salario + (salario * 0.10);
                } else
                {
                    salario = salario + (salario * 0.05);
                }
                Console.WriteLine("O novo salário é "+salario);
            } else if(opcao == 2)
            {
                salario = salario + (salario / 3);
                Console.WriteLine("O valor das férias é "+Math.Round(salario,2));
            } else
            {
                Console.WriteLine("Digite a quantidade de meses trabalhados: (maxido de 12 meses)");
                meses = int.Parse(Console.ReadLine());
                if (meses > 12)
                    meses = 12;
                salario = (salario * meses) / 12;
                Console.WriteLine("O valor do décimo terceiro é:"+Math.Round(salario,2));
            } 
            Console.ReadKey();
        }
    }
}
