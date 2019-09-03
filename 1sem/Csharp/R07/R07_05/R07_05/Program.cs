using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R07_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0; 
            string cliente, linha = "texto";
            string[] vetor = new string[4];
            string[] vetLer;
            Boolean encontrado = false;

            while (opcao != 3)
            {
                Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine("\nInfome a opção desejada: ");
                Console.WriteLine("1 - Cadastrar cliente \n2 - Pesquisar cliente \n3 - Sair\n");
                opcao = int.Parse(Console.ReadLine());

                if (opcao == 3)
                {
                    break;

                } else if(opcao == 1)
                {
                    StreamWriter escrever = new StreamWriter("Cadastro.txt", true);

                    vetor[0] = "Nulo";
                    Console.Write("\nDigite o nome: ");
                    vetor[0] = Console.ReadLine();

                    vetor[1] = "Nulo";
                    Console.Write("Digite o endereço: ");
                    vetor[1] = Console.ReadLine();

                    vetor[2] = "Nulo";
                    Console.Write("Digite o telefone: ");
                    vetor[2] = Console.ReadLine();

                    vetor[3] = "Nulo";
                    Console.Write("Digite o cpf: ");
                    vetor[3] = Console.ReadLine();
                    
                    escrever.WriteLine(vetor[0] + ";" + vetor[1] + ";" + vetor[2] + ";" + vetor[3]);
                    escrever.Close();

                } else if(opcao == 2)
                {
                    StreamReader ler = new StreamReader("Cadastro.txt", true);

                    Console.Write("Digite o nome do cliente: ");
                    cliente = Console.ReadLine();

                    linha = "text";
                    while (linha != null)
                    {
                        linha = ler.ReadLine();
                        if(linha != null)
                        {
                            vetLer = linha.Split(';');

                            if(vetLer[0] == cliente)
                            {
                                Console.WriteLine("\nInfomações encontradas do cliente "+cliente);
                                Console.WriteLine("nome: " + vetLer[0] + "\nEndereço: " + vetLer[1] +
                                            "\nTelefone: " + vetLer[2] + "\nCPF: " + vetLer[3]);
                                encontrado = true;
                                linha = null;
                                break;
                            }
                        }
                    }

                    ler.Close();
                    if(encontrado == false)
                        Console.WriteLine("\nUsuário não encontrado");

                } else
                {
                    Console.WriteLine("Opção não disponível !\n");
                }
            }

            Console.ReadKey();
        }
    }
}
