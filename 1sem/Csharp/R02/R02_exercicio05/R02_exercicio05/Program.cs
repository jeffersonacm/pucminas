using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R02_exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, result;
            int opcao;
            Console.WriteLine("Informe o primeiro número:");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo número:");
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Escolha a opção desejada:");
            Console.WriteLine("1 - Media entre os números digitados:");
            Console.WriteLine("2 - Diferença do maior pelo menor:");
            Console.WriteLine("3 - Produto entre os números digitados:");
            Console.WriteLine("4 - Divisão do primeiro pelo segundo número digitado:");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                result = (num1 + num2) / 2;
                Console.WriteLine("A média entre os números é: "+result);
            } else if (opcao == 2)
            {
                if(num1 > num2)
                {
                    result = num1 - num2;
                } else
                {
                    result = num2 - num1;
                }
                Console.WriteLine("A diferença do maior para o menor é: " + result);
            } else if (opcao == 3)
            {
                result = num1 * num2;
                Console.WriteLine("O produto é : " + result);
            } else if (opcao == 4)
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Na opção 4, o segundo número deve ser diferente de 0");
                    Console.ReadKey();
                } else
                {
                    result = num1 / num2;
                    Console.WriteLine("A divisão entre os números é: " +result);
                }
            } else
            {
                Console.WriteLine("O valor digitado não corresponde a nenhuma das opções acima: ");
            }          
            Console.ReadKey();
        }
    }
}
