using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R02_01
{
    class Program
    {
        static void Main(string[] args)
        {
            double peso;
            int opcao;

            Console.WriteLine("Digite seu peso");
            peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Escolha uma das opções: \n 1- engordar \n 2- emagrecer");
            opcao = int.Parse(Console.ReadLine());
            
            if (opcao == 1)
            {
                peso = peso + (peso * 0.15);
                Console.WriteLine("O novo peso é " + peso);
            } else if (opcao == 2)
            {
                peso = peso - (peso * 0.20);
                Console.WriteLine("O novo peso é "+ peso);
            } else
            {
                Console.WriteLine("A opção marcada não corresponde a nenhuma das opções");
            }
            Console.ReadKey();
        }
    }
}
